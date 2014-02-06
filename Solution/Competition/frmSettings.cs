//Tenant Administration System
//============

//A simple program that gives returns a specified number
//of random values give user provided information.
//Copyright (C)  2014  Timur Lavrenti Kiyivinski & Brenton Edi

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Xml;
using System.Xml.XPath;
using System.Security;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using SharedClass;

namespace Competition
{
    public partial class frmSettings : Form
    {
        #region "Declaration"
        public string CurrentPath = Directory.GetCurrentDirectory();
        public bool isClosed;
        const string Database = "/UserDataBase/";
        public struct UserNamePath
        {
            public string Name;
            public string Path;
        }
        public List<SharedCode.appUser> UserAdminList = new List<SharedCode.appUser>();
        public List<UserNamePath> UserNamePathList = new List<UserNamePath>();
        public SharedCode share = new SharedCode();
        public string originUsername;
        const string currentLoad = "curLoad\\";
        #endregion

        public frmSettings()
        {
            SharedCode.appUser currentUser = new SharedCode.appUser();
            InitializeComponent();
            currentUser = share.loadGeneral();
            showData(currentUser);
            originUsername = currentUser.Name;
            isClosed = false;
            foreach(Control txtControl in tGeneral.Controls)
            {
                if(txtControl is TextBox)
                {
                    txtControl.Enter += share.txtFocus;
                }
            }
        }

        #region "Functions & Procedures"
        private void showData(SharedCode.appUser setUser)
        {
            txtT1Username.Text = setUser.Name;
            txtT1IC.Text = setUser.IC;
            txtT1Address.Text = setUser.HomeAddress;
            txtT1HouseNo.Text = setUser.HouseNumber;
            txtT1PhoneNo.Text = setUser.PhoneNumber;
            txtT1Email.Text = setUser.Email;
        }

        private void populateUsers()
        {
            DatabaseCheck();
            cbT2Users.Items.Clear();
            foreach(UserNamePath user in UserNamePathList)
            {
                cbT2Users.Items.Add(user.Name);
            }
            cbT2Users.SelectedIndex = 0;
        }

        private void DatabaseCheck()
        {
            UserAdminList.Clear();
            UserNamePathList.Clear();
            if (Directory.Exists(CurrentPath + Database) == true)
            {
                //We load the Users
                String[] fileList;
                fileList = Directory.GetFiles(CurrentPath + Database, "*.db");
                double fileCount = 0;
                foreach (string fileName in fileList)
                {
                    if (fileName.Substring(fileName.Length - 2, 2) == "db")
                    {
                        Console.WriteLine("File {0} was loaded.", fileName);
                        LoadUser(Path.GetFileNameWithoutExtension(fileName), fileName);
                        fileCount += 1;
                    }
                    else
                    {
                        Console.WriteLine("Non .db file loaded. This should not happen");
                        break;
                    }
                }
                Console.WriteLine("{0} file(s) loaded.", fileList.Length);
            }
            else
            {
                MessageBox.Show("Please ensure that the database exists! If not, please create a user.");
                Directory.CreateDirectory(CurrentPath + Database);
                return;
            }
        } //Checks the database and loads verified user databases

        private void LoadUser(String UserName, String FilePath)
        {
            UserNamePath loadUser = new UserNamePath();
            loadUser.Name = UserName;
            loadUser.Path = FilePath;
            UserNamePathList.Add(loadUser);
        }

        private void properExit()
        {
            isClosed = true;
            this.Hide();
            frmLogin loginFrm = new frmLogin();
            loginFrm.Show();
        }
        #endregion

        private void btnT1_Save_Click(object sender, EventArgs e)
        {
            foreach(Control txtControl in tGeneral.Controls)
            {
                if(txtControl is TextBox && txtControl.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all the entries!", "Warning!");
                    txtT1Username.Focus();
                    return;
                }
            }
            if(txtT1Password.Text != txtT1PasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!", "Warning");
                txtT1Password.Text = string.Empty;
                txtT1PasswordConfirm.Text = string.Empty;
                txtT1Password.Focus();
                return;
            }
            if(share.alphanumericTest(txtT1Username.Text) == true)
            {
                MessageBox.Show("Username must be alphanumeric!", "Warning!");
                return;
            }
            if (share.alphanumericTest(txtT1Password.Text) == true)
            {
                MessageBox.Show("Password must be alphanumeric!", "Warning!");
                return;
            }
            DialogResult confirmSave = new DialogResult();
            confirmSave = MessageBox.Show("Saving these changes will log you out of this current session. Continue?", "Warning", MessageBoxButtons.OKCancel);
            if(confirmSave == System.Windows.Forms.DialogResult.Cancel)
            {
                //User doesn't want to save changes
                return;
            }
            SharedCode.appUser saveUser = new SharedCode.appUser();
            saveUser.Name = txtT1Username.Text;
            saveUser.IC = txtT1IC.Text;
            saveUser.HomeAddress = txtT1Address.Text;
            saveUser.HouseNumber = txtT1HouseNo.Text;
            saveUser.PhoneNumber = txtT1PhoneNo.Text;
            saveUser.Email = txtT1Email.Text;
            saveUser.Password = txtT1Password.Text;
            share.saveGeneral(saveUser);
            if(originUsername != saveUser.Name)
            {
                Console.WriteLine("Username changed!");
                System.IO.File.Delete(CurrentPath + Database + originUsername + ".db");
            }
            share.EncryptFile(CurrentPath + "\\saveNew.db", CurrentPath + Database + saveUser.Name + ".db", saveUser.Password);
            //Encrypt all tenants with new name
            String[] fileList;
            fileList = Directory.GetFiles(CurrentPath + Database + currentLoad, "*.db");
            //Encrypt all user tenants
            foreach (string fileName in fileList)
            {
                string tenantName;
                tenantName = Path.GetFileNameWithoutExtension(fileName);
                share.EncryptFile(fileName, CurrentPath + Database + saveUser.Name + "\\" + tenantName + ".db", saveUser.Password);
            }
            if (System.IO.File.Exists(CurrentPath + "\\saveNew.db") == true)
            {
                System.IO.File.Delete(CurrentPath + "\\saveNew.db");
            }
            properExit();
        }

        private void checkExist(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(CurrentPath + Database + txtT1Username.Text + ".db") == true && txtT1Username.Text != originUsername)
            {
                Console.WriteLine("User is requesting a username already in the database! Possible nuclear threat detected.");
                MessageBox.Show("The user requested already exists!", "Warning");
                txtT1Username.Focus();
                txtT1Username.Text = originUsername;
                return;
            }
        }

        private void gChange(object sender, EventArgs e)
        {
            if(gSettings.SelectedTab == tGeneral)
            {
                Console.WriteLine("General settings selected.");
            }
            else if(gSettings.SelectedTab == tAdmin && originUsername == "Administrator")
            {
                foreach (Control adminCtrl in tAdmin.Controls)
                {
                    adminCtrl.Visible = true;
                    adminCtrl.Update();
                }
                populateUsers();
            }
            else
            {
                foreach(Control adminCtrl in tAdmin.Controls)
                {
                    adminCtrl.Visible = false;
                    adminCtrl.Update();
                }
                MessageBox.Show("Access Denied.", "Warning");
                gSettings.SelectedTab = tGeneral;
            }
        }

        private void btnT2Remove_Click(object sender, EventArgs e)
        {
            int popIndex;
            popIndex = cbT2Users.SelectedIndex;
            UserNamePath popUser = new UserNamePath();
            popUser = UserNamePathList[popIndex];
            if (popUser.Name == "Administrator")
            {
                MessageBox.Show("Invalid action.", "Error");
                return;
            }
            Console.WriteLine("Deleting user {0}.", popUser.Name);
            UserNamePathList.RemoveAt(popIndex);
            if(System.IO.File.Exists(popUser.Path) == true)
            {
                System.IO.File.Delete(popUser.Path);
                string[] fileList;
                fileList = Directory.GetFiles(CurrentPath + Database + popUser.Name);
                foreach (string fileName in fileList)
                {
                    System.IO.File.Delete(fileName);
                }
                Directory.Delete(CurrentPath + Database + popUser.Name);
            }
            else
            {
                Console.WriteLine("No user file to delete?");
                return;
            }
            populateUsers();
        }

        private void frmClose(object sender, FormClosingEventArgs e)
        {
            if(isClosed == false)
            {
                isClosed = true;
                MessageBox.Show("You have been signed out.", "Warning");
                this.Hide();
                frmLogin loginFrm = new frmLogin();
                loginFrm.Show();
            }
            
        }
    }
}
