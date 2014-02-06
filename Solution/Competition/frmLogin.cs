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


namespace Competition
{
    public partial class frmLogin : Form
    {
        #region "Declaration"
        public string CurrentPath = Directory.GetCurrentDirectory();
        const string Database = "/UserDataBase/";
        public struct UserAdmin
        {
            public string Name;
            public string IC;
            public string HomeAddress;
            public string HouseNumber;
            public string PhoneNumber;
            public string Email;
            public string Password;
        }
        public struct UserNamePath
        {
            public string Name;
            public string Path;
        }
        public List<UserAdmin> UserAdminList = new List<UserAdmin>();
        public List<UserNamePath> UserNamePathList = new List<UserNamePath>();
        public static string currentPassword;
        public frmLogin theLoginFrm;
        const string currentLoad = "curLoad\\";
        public bool isLogin = false;
        #endregion

        public frmLogin()
        {
            InitializeComponent();
            DatabaseCheck();
            //Add txtBox Enter handlers
            txtUserName.Enter += txtFocus;
            txtUserName.Click += txtFocus;
            txtPassword.Enter += txtFocus;
            txtPassword.Click += txtFocus;
            this.Height = 220;
            this.Update();
            foreach(Control txtControl in gNewUser.Controls)
            {
                if(txtControl is TextBox)
                {
                    txtControl.Enter += txtFocus;
                    txtControl.Click += txtFocus;
                }
            }
            if (System.IO.File.Exists(CurrentPath + "\\currentload.db") == true && FileInUse(CurrentPath + "\\currentload.db") == false)
            {
                Console.WriteLine("Improper previous close detected.");
                System.IO.File.Delete(CurrentPath + "\\currentload.db");
            }
            theLoginFrm = this;
        }
        #region "Functions & Procedures"

        #region "Encryption"
        private static void EncryptFile(string inputFile, string outputFile, string securityKey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(securityKey);
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes("1234567890qwerty");
                    //aes.Padding = PaddingMode.None;
                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                    {
                        Console.WriteLine("File created.");
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                        {
                            Console.WriteLine("Encrypt mode initiated.");
                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                            {
                                Console.WriteLine("Encrypt stream initiated.");
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                                {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1)
                                    {
                                        cs.WriteByte((byte)data);
                                    }
                                    Console.WriteLine("File encrypted.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("This exception was caught: " + ex.ToString());
            }
        }
        private static bool DecryptFile(string inputFile, string outputFile, string securityKey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(securityKey);
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes("1234567890qwerty");
                    //aes.Padding = PaddingMode.None;
                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open, FileAccess.ReadWrite))
                    {
                        Console.WriteLine("Reading input file.");
                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite))
                        {
                            Console.WriteLine("Creating output file.");
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                            {
                                Console.WriteLine("Decryption beginning.");
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                    cs.Close();
                                    Console.WriteLine("Success!");
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("This exception was caught: " + ex.ToString());
                return false;
            }
        }
        #endregion

        public void SuccessLogin()
        {
            isLogin = true;
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Dispose();
            this.Close();
        }

        public static System.Boolean FileInUse(System.String file)
        {
            try
            {
                if (!System.IO.File.Exists(file)) // The path might also be invalid.
                {
                    return false;
                }

                using (System.IO.FileStream stream = new System.IO.FileStream(file, System.IO.FileMode.Open))
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }

        private void DatabaseCheck()
        {
            rmOldData();
            UserAdminList.Clear();
            UserNamePathList.Clear();
            if(Directory.Exists(CurrentPath + Database) == true)
            {
                //We load the Users
                String[] fileList;
                fileList = Directory.GetFiles(CurrentPath + Database, "*.db");
                double fileCount = 0;
                foreach(string fileName in fileList)
                {
                    if(fileName.Substring(fileName.Length - 2, 2) == "db")
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
                Directory.CreateDirectory(CurrentPath + Database + "curLoad");
                return;
            }
        } //Checks the database and loads verified user databases

        private void rmOldData()
        {
            if (Directory.Exists(CurrentPath + Database) == true)
            {
                //We load the Users
                String[] fileList;
                fileList = Directory.GetFiles(CurrentPath + Database + currentLoad, "*.db");
                foreach (string fileName in fileList)
                {
                    if (fileName.Substring(fileName.Length - 2, 2) == "db")
                    {
                        System.IO.File.Delete(fileName);
                    }
                }
                Console.WriteLine("{0} file(s) in curLoad deleted.", fileList.Length);
            }
        }

        private void LoadUser(String UserName, String FilePath)
        {
            UserNamePath loadUser = new UserNamePath();
            loadUser.Name = UserName;
            loadUser.Path = FilePath;
            UserNamePathList.Add(loadUser);
        }

        private void HideUserCreate()
        {
            gNewUser.Enabled = false;
            PanelLogin.Enabled = true;
            int heightSize;
            heightSize = this.Height;
            while (this.Height > 220)
            {
                heightSize -= 1;
                this.Size = new System.Drawing.Size(505, heightSize);
            }
        }

        private void txtFocus(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.SelectAll();
        }//Selects all the text in the textbox

        private void clearChildren(Control childrenParent)//Clears all children textboxes of parent control
        {
            foreach (Control clearTXT in childrenParent.Controls)
            {
                if (clearTXT is TextBox)
                {
                    clearTXT.Text = string.Empty;
                }
            }
        }

        private bool alphanumericTest(String testString)
        {
            Regex testREGEX = new Regex("^[a-zA-Z0-9]*$");
            if(testREGEX.IsMatch(testString) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//Tests if a string is alphanumeric
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(CurrentPath + Database + txtUserName.Text) == true)
            {
                //All is good
            }
            else
            {
                Console.WriteLine("Database corrupted?");
                MessageBox.Show("The database is corrupted, please remove the current user using the Administrator account and re-create it.", "Error");
                return;
            }
            bool matchFound = false;
            UserNamePath myLoginUser = new UserNamePath();
            foreach(UserNamePath testUser in UserNamePathList)
            {
                Console.WriteLine(testUser.Name);
                if(txtUserName.Text == testUser.Name)
                {
                    matchFound = true;
                    myLoginUser = testUser;
                    Console.WriteLine(matchFound.ToString());
                    break;
                }
                else
                {
                    matchFound = false;
                }
            }
            if(matchFound == true)
            {
                bool successLogin;
                successLogin = DecryptFile(myLoginUser.Path, CurrentPath + "\\currentload.db", txtPassword.Text);
                if(successLogin == true)
                {
                    currentPassword = txtPassword.Text;
                    String[] fileList;
                    fileList = Directory.GetFiles(CurrentPath + Database + txtUserName.Text, "*.db");
                    //Decrypt all user tenants
                    foreach(string fileName in fileList)
                    {
                        string tenantName;
                        tenantName = Path.GetFileNameWithoutExtension(fileName);
                        DecryptFile(fileName, CurrentPath + Database + currentLoad + tenantName + ".db", currentPassword);
                    }
                    SuccessLogin();
                }
                else
                {
                    MessageBox.Show("Incorrect password!", "Warning");
                    txtPassword.Focus();
                }
            }
            else if(matchFound == false)
            {
                MessageBox.Show("The user " + txtUserName.Text + " does not exist.", "Error");
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            gNewUser.Visible = true;
            gNewUser.Update();
            PanelLogin.Enabled = false;
            int heightSize;
            heightSize = this.Height;
            while(this.Height < 475)
            {
                heightSize += 15;
                this.Size = new System.Drawing.Size(505, heightSize);
            }
            gNewUser.Enabled = true;
            txtNewUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideUserCreate();
            clearChildren(gNewUser);
            gNewUser.Visible = false;
            gNewUser.Update();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text == txtNewPasswordConfirm.Text)
            {
                //Testing fields
                foreach(UserNamePath tempTest in UserNamePathList)
                {
                    if(txtNewUsername.Text == tempTest.Name)
                    {
                        MessageBox.Show("User already exists!", "Warning!");
                        txtNewUsername.Focus();
                        return;
                    }
                }
                foreach (Control tempTest in gNewUser.Controls)
                {
                    if (tempTest is TextBox && tempTest.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please fill out all the entries!", "Warning!");
                        tempTest.Focus();
                        return;
                    }
                }
                if (alphanumericTest(txtNewUsername.Text) == true)
                {
                    MessageBox.Show("Username must be alphanumeric!", "Warning!");
                    txtNewUsername.Focus();
                    return;
                }
                if (alphanumericTest(txtNewPassword.Text) == true)
                {
                    MessageBox.Show("Password must be alphanumeric!", "Warning!");
                    txtNewPassword.Text = string.Empty;
                    txtNewPasswordConfirm.Text = string.Empty;
                    txtNewPassword.Focus();
                    return;
                }
                if(txtNewPassword.Text.Length < 8)
                {
                    MessageBox.Show("Password length must be at least 8 characters!", "Warning!");
                }
                //Get new user information
                UserAdmin newUser = new UserAdmin();
                newUser.Name = txtNewUsername.Text;
                newUser.IC = txtNewIC.Text;
                newUser.HomeAddress = txtNewAddress.Text;
                newUser.HouseNumber = txtNewHouseNo.Text;
                newUser.PhoneNumber = txtNewPhoneNo.Text;
                newUser.Email = txtNewEmail.Text;
                newUser.Password = txtPassword.Text;
                //Create a temporary unencrypted user database
                string tmpNewUser = newUser.Name + ".tmp";
                XmlWriterSettings writer_settings = new XmlWriterSettings();
                writer_settings.Indent = true; ;
                writer_settings.OmitXmlDeclaration = true;
                writer_settings.Encoding = Encoding.ASCII;
                using (XmlWriter writer = XmlWriter.Create(tmpNewUser, writer_settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Database");//Database
                    //----------
                    writer.WriteStartElement("Details"); //Details
                    //----------
                    writer.WriteElementString("UserName", newUser.Name);
                    writer.WriteElementString("IC", newUser.IC);
                    writer.WriteElementString("Address", newUser.HomeAddress);
                    writer.WriteElementString("HouseNo", newUser.HouseNumber);
                    writer.WriteElementString("PhoneNo", newUser.PhoneNumber);
                    writer.WriteElementString("Email", newUser.Email);
                    //----------
                    writer.WriteEndElement(); //Details
                    //----------
                    writer.WriteEndElement();//Database
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                string tempFileDir = CurrentPath + "\\" + tmpNewUser;
                string outFileDir = CurrentPath + Database + "\\" + newUser.Name + ".db";
                Console.WriteLine(tempFileDir.ToString());
                EncryptFile(tempFileDir, outFileDir, txtNewPassword.Text);
                Console.WriteLine("Creating user tenant directory");
                Directory.CreateDirectory(CurrentPath + Database + newUser.Name);
                //Delete files
                System.IO.File.Delete(tempFileDir);
                //Success
                MessageBox.Show("User " + newUser.Name + " successfully created!", "Success");
                //Hide the create user dialog
                HideUserCreate();
                //Show new UserName in field
                txtUserName.Text = newUser.Name;
                txtPassword.Focus();
                //Clear textboxes
                clearChildren(gNewUser);
                //Reload database
                DatabaseCheck();
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Warning");
                txtNewPassword.Text = string.Empty;
                txtNewPasswordConfirm.Text = string.Empty;
                txtNewPassword.Focus();
            }
        }

        private void exitALL(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            if(isLogin == true)
            {
                return;
            }
            this.Dispose();
            try
            {
                Application.Exit();
            }
            catch
            {
                this.Hide();
                this.Close();
            }
        }
    }
}
