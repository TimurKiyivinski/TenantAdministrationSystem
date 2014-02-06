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
using ExcelLibrary;
using ExcelLibrary.SpreadSheet;

namespace Competition
{
    public partial class frmMain : Form
    {
        #region "Declaration"
        public SharedCode.Tenant xTenant = new SharedCode.Tenant();
        public SharedCode.appUser currentUser = new SharedCode.appUser();
        public List<SharedCode.Tenant> TenantList = new List<SharedCode.Tenant>();
        public string CurrentPath = Directory.GetCurrentDirectory();
        const string Database = "\\UserDataBase\\";
        const string currentLoad = "curLoad\\";
        public string userPassword = frmLogin.currentPassword;
        public SharedCode share = new SharedCode();
        public struct TenantPath
        {
            public string Name;
            public string Path;
        }
        public List<TenantPath> TenantPathList = new List<TenantPath>();
        public bool isLogOut = false;
        public bool isExit = false;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            currentUser = share.loadGeneral();
            loadUI(currentUser);
            loadTenants();
            gECTenants.Enabled = false;
            countUnpaid();
            gTenants.Visible = true;
        }

        #region "Functions & Procedures"
        private void loadUI(SharedCode.appUser currentUser)
        {
            lblWelcome.Text += currentUser.Name;
        } //Reloads the main UI

        private void loadTenants()
        {
            TenantPathList.Clear();
            TenantList.Clear();
            String[] fileList;
            string tenantDir = CurrentPath + Database + currentLoad;
            Console.WriteLine("Loading tenants from {0}", tenantDir);
            fileList = Directory.GetFiles(tenantDir, "*.db");
            TenantPath addTenantPath = new TenantPath();
            SharedCode.Tenant addTenant = new SharedCode.Tenant();
            foreach (string fileName in fileList)
            {
                addTenantPath.Name = Path.GetFileNameWithoutExtension(fileName);
                addTenantPath.Path = fileName;
                addTenant = share.loadTenantInfo(fileName);
                Console.WriteLine("Loading tenant: {0}", addTenantPath.Name);
                TenantPathList.Add(addTenantPath);
                TenantList.Add(addTenant);
            }
        } //Loads all the user tenants

        private void tenantsUI(bool hide)
        {
            Console.WriteLine(hide.ToString());
            if (hide == true)
            {
                gTenants.Visible = false;
                gTenants.Update();
                return;
            }
            else
            {
                gTenants.Visible = true;
                gTenants.Update();
            }
            gECTenants.Enabled = false;
            //
            if (TenantPathList.Count == 0)
            {
                btnRemove.Enabled = false;
                cbTenants.Enabled = false;
                btnEdit.Enabled = false;
                btnSaveChanges.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                cbTenants.Enabled = true;
                btnEdit.Enabled = true;
                btnSaveChanges.Enabled = true;
            }
            //
            cbTenants.Items.Clear();
            if(TenantPathList.Count != 0)
            {
                foreach(TenantPath tenantName in TenantPathList)
                {
                    cbTenants.Items.Add(tenantName.Name);
                    cbTenants.SelectedIndex = 0;
                }
            }

        } //Loads the tenants UI

        private void clearTenantDetails()
        {
            foreach(Control wipeControl in gECTenants.Controls)
            {
                if(wipeControl is TextBox)
                {
                    wipeControl.Text = string.Empty;
                }
            }
        }  //Clears the save/edit tenant details

        private void saveTenant(SharedCode.Tenant newTenant)
        {
            string saveTenantDir;
            saveTenantDir = CurrentPath + Database + currentLoad + newTenant.Name + ".db";
            XmlWriterSettings writer_settings = new XmlWriterSettings();
            writer_settings.Indent = true; ;
            writer_settings.OmitXmlDeclaration = true;
            writer_settings.Encoding = Encoding.ASCII;
            int noInfo = 0;
            XmlWriter writer = XmlWriter.Create(saveTenantDir, writer_settings);
            using (writer)
            {
                writer.WriteStartDocument();
                //----------
                writer.WriteStartElement("Details"); //Details
                //----------
                writer.WriteElementString("UserName", newTenant.Name);
                writer.WriteElementString("LotNo", newTenant.LotNo);
                writer.WriteElementString("PhoneNo", newTenant.PhoneNo);
                writer.WriteElementString("LandNo", newTenant.LandNo);
                writer.WriteElementString("Email", newTenant.Email);
                writer.WriteElementString("Address", newTenant.Address);
                writer.WriteElementString("Remarks", newTenant.Remarks);
                writer.WriteElementString("Start", newTenant.TenureStart.ToShortDateString());
                writer.WriteElementString("End", newTenant.TenureEnd.ToShortDateString());
                writer.WriteElementString("Rent", noInfo.ToString());
                writer.WriteElementString("Total", noInfo.ToString());
                //----------
                writer.WriteEndElement(); //Details
                writer.WriteEndDocument();
            }
            writer.Flush();
            writer.Close();
        } //Writes out tenant info into a new XML file

        private void editTenant(SharedCode.Tenant editTenant)
        {
            string saveTenantDir = CurrentPath + Database + currentLoad + editTenant.Name + ".db";
            Console.WriteLine("Saving tenant to {0}", saveTenantDir);
            XmlReader readXML = XmlReader.Create(saveTenantDir);
            XmlDocument saveXML = new XmlDocument();
            saveXML.Load(readXML);
            saveXML.SelectSingleNode("//Details/UserName").InnerText = editTenant.Name;
            saveXML.SelectSingleNode("//Details/LotNo").InnerText = editTenant.LotNo;
            saveXML.SelectSingleNode("//Details/PhoneNo").InnerText = editTenant.PhoneNo;
            saveXML.SelectSingleNode("//Details/LandNo").InnerText = editTenant.LandNo;
            saveXML.SelectSingleNode("//Details/Email").InnerText = editTenant.Email;
            saveXML.SelectSingleNode("//Details/Address").InnerText = editTenant.Address;
            saveXML.SelectSingleNode("//Details/Remarks").InnerText = editTenant.Remarks;
            saveXML.Save(saveTenantDir + ".tmp");
            readXML.Close();
            System.IO.File.Delete(saveTenantDir);
            System.IO.File.Move(saveTenantDir + ".tmp", saveTenantDir);
        } //Edits the tenant info

        private int countDue()
        {
            return 0;
        } //Calculates number of tenants with due payments

        private void countUnpaid()
        {
            SharedCode.Tenant listTenant;
            Console.WriteLine(TenantList.Count.ToString());
            int duePayments = 0;
            for(int loopVar = 0; loopVar < TenantList.Count; loopVar++)
            {
                Console.WriteLine(loopVar.ToString());
                listTenant = TenantList[loopVar];
                DateTime tenureStart = listTenant.TenureStart;
                DateTime tenureEnd = listTenant.TenureEnd;
                if(tenureEnd >= DateTime.Now)
                {
                    tenureEnd = DateTime.Now;
                }
                TimeSpan tenureSpan = tenureEnd - tenureStart;
                Console.WriteLine("Timespan between is {0}", tenureSpan.Days.ToString());
                decimal tenureMonths;
                tenureMonths = Math.Round(Convert.ToDecimal(tenureSpan.Days) / 30, 0, MidpointRounding.ToEven);
                if(tenureMonths < 1)
                {
                    Console.WriteLine("Warning, tenure month < 1!");
                }
                if(listTenant.MonthlyRent == 0)
                {
                    Console.WriteLine("Free rent detected?");
                }
                if((tenureMonths * listTenant.MonthlyRent) > listTenant.CumulativeRent)
                {
                    duePayments += 1;
                }
            }
            lblDuePayments.Text = duePayments.ToString() + " due payments.";
            if(duePayments == 1)
            {
                lblDuePayments.Text = duePayments.ToString() + " due payment.";
            }
            if(duePayments > 0)
            {
                lblDuePayments.ForeColor = Color.Red;
            }
            else
            {
                lblDuePayments.ForeColor = Color.Black;
            }
        }

        private void updateRentals()
        {
            cbRTenant.Items.Clear();
            foreach(TenantPath tenantName in TenantPathList)
            {
                cbRTenant.Items.Add(tenantName.Name);
            }
            cbRTenant.SelectedIndex = 0;
        }

        private void updateReceivable()
        {
            decimal month, receivable;
            decimal cumulative;
            decimal periodMonths;
            month = Convert.ToDecimal(txtRMonthly.Text);
            cumulative = Convert.ToDecimal(txtRCumulative.Text);
            TimeSpan timeperiod;
            DateTime endDate;
            endDate = dtREnd.Value;
            if(dtREnd.Value >= DateTime.Now)
            {
                endDate = DateTime.Now;
            }
            timeperiod = dtRStart.Value - endDate;
            periodMonths = Math.Round(Convert.ToDecimal(timeperiod.Days) / 30, 0, MidpointRounding.ToEven) * -1;
            receivable = 0;
            if((periodMonths * month) > cumulative)
            {
                receivable = (periodMonths * month) - cumulative;
            }
            lblRReceivable.Text = receivable.ToString();
            countUnpaid();
        }
        #endregion

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSettings settingsForm = new frmSettings();
            settingsForm.Show();
        } //Enters settings

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Encrypting all tenants.");
            String[] fileList;
            fileList = Directory.GetFiles(CurrentPath + Database + currentLoad, "*.db");
            //Encrypt all user tenants
            foreach (string fileName in fileList)
            {
                string tenantName;
                tenantName = Path.GetFileNameWithoutExtension(fileName);
                share.EncryptFile(fileName, CurrentPath + Database + currentUser.Name + "\\" + tenantName + ".db", userPassword);
            }
            System.IO.File.Delete(CurrentPath + "\\currentload.db");
            isLogOut = true;
            frmMain Main = this;
            Main.Hide();
            frmLogin mainLogin = new frmLogin();
            mainLogin.Show();
        } //Logs the user out

        private void btnTenants_Click(object sender, EventArgs e)
        {
            gRentals.Visible = false;
            clearTenantDetails();
            tenantsUI(gTenants.Visible);
        } //Toggles the tenant group

        private void btnRemove_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(TenantPathList[cbTenants.SelectedIndex].Path);
            TenantPathList.RemoveAt(cbTenants.SelectedIndex);
            loadTenants();
            tenantsUI(false);
        } //Removed a selected tenant

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbTenants.SelectedIndex >= 0)
            {
                gECTenants.Enabled = true;
                btnSave.Enabled = false;
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                cbTenants.Enabled = false;
                txtTCompanyName.Enabled = false;
                SharedCode.Tenant editTenant = new SharedCode.Tenant();
                editTenant = share.loadTenantInfo(TenantPathList[cbTenants.SelectedIndex].Path);
                Console.WriteLine("Path is {0}.", TenantPathList[cbTenants.SelectedIndex].Path);
                txtTCompanyName.Text = editTenant.Name;
                txtTAddress.Text = editTenant.Address;
                txtTLotNo.Text = editTenant.LotNo;
                txtTContact_Mobile.Text = editTenant.PhoneNo;
                txtTContact_Landline.Text = editTenant.LandNo;
                txtTContact_Email.Text = editTenant.Email;
                txtTRemarks.Text = editTenant.Remarks;
            }
        } //Editing a selected tenant

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gECTenants.Enabled = true;
            btnSaveChanges.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            cbTenants.Enabled = false;
            btnSave.Enabled = true;
            txtTCompanyName.Enabled = true;
        } //Adding a new tenant

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control testEmpty in gECTenants.Controls)
            {
                if (testEmpty is TextBox && testEmpty.Text == string.Empty)
                {
                    MessageBox.Show("Please fill out all the entries!", "Warning!");
                    testEmpty.Focus();
                    return;
                }
            }
            if (share.alphanumericTest(txtTCompanyName.Text) == true)
            {
                MessageBox.Show("Company name must be alphanumeric!", "Warning!");
                txtTCompanyName.Focus();
                return;
            }
            foreach (TenantPath testExists in TenantPathList)
            {
                if (testExists.Name == txtTCompanyName.Text)
                {
                    MessageBox.Show("The company already exists!", "Warning!");
                    txtTCompanyName.Focus();
                    return;
                }
            }
            tenantsUI(false);
            xTenant.Name = txtTCompanyName.Text;
            xTenant.Address = txtTAddress.Text;
            xTenant.LotNo = txtTLotNo.Text;
            xTenant.PhoneNo = txtTContact_Mobile.Text;
            xTenant.LandNo = txtTContact_Landline.Text;
            xTenant.Email = txtTContact_Email.Text;
            xTenant.Remarks = txtTRemarks.Text;
            xTenant.TenureStart = DateTime.Now;
            xTenant.TenureEnd = DateTime.Parse(DateTime.Now.ToString()).AddDays(30);

            saveTenant(xTenant);
            loadTenants();
            tenantsUI(false);
            clearTenantDetails();
        } // Saving a new tenant

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            foreach (Control testEmpty in gECTenants.Controls)
            {
                if (testEmpty is TextBox && testEmpty.Text == string.Empty)
                {
                    MessageBox.Show("Please fill out all the entries!", "Warning!");
                    testEmpty.Focus();
                    return;
                }
            }
            SharedCode.Tenant saveeditedTenant = new SharedCode.Tenant();
            saveeditedTenant.Name = txtTCompanyName.Text;
            saveeditedTenant.Address = txtTAddress.Text;
            saveeditedTenant.LotNo = txtTLotNo.Text;
            saveeditedTenant.PhoneNo = txtTContact_Mobile.Text;
            saveeditedTenant.LandNo = txtTContact_Landline.Text;
            saveeditedTenant.Email = txtTContact_Email.Text;
            saveeditedTenant.Remarks = txtTRemarks.Text;
            editTenant(saveeditedTenant);
            loadTenants();
            tenantsUI(false);
            clearTenantDetails();
            btnAdd.Enabled = true;
        } //Saving changes to an existing tenant

        private void frmClose(object sender, FormClosingEventArgs e)
        {
            if(isLogOut == true && isExit == false)
            {
                isExit = true;
                this.Close();
                frmLogin loginFrm = new frmLogin();
                loginFrm.Show();
            }
            if(isLogOut == false && isExit == false)
            {
                MessageBox.Show("Please log out.", "Warning");
                e.Cancel = true;
                btnLogout.Focus();
            }
        } //When user is about to close form

        private void btnRentals_Click(object sender, EventArgs e)
        {
            gTenants.Visible = false;
            if(TenantList.Count != 0)
            {
                if(gRentals.Visible == false)
                {
                    updateRentals();
                    gRentals.Visible = true;
                    gRentals.Update();
                }
                else
                {
                    gRentals.Visible = false;
                    gRentals.Update();
                }
            }
            else
            {
                gRentals.Visible = false;
                gRentals.Update();
            }
        }

        private void cbR_Changed(object sender, EventArgs e)
        {
            int selectedTenant = cbRTenant.SelectedIndex;
            SharedCode.Tenant tenantLoad = share.loadTenantInfo(TenantPathList[selectedTenant].Path);
            string rAddress, rLotNo;
            rAddress = tenantLoad.Address;
            rLotNo = tenantLoad.LotNo;
            if(tenantLoad.Address.Length > 20)
            {
                rAddress = tenantLoad.Address.Substring(0, 20) + "...";
            }
            if (tenantLoad.LotNo.Length > 20)
            {
                rLotNo = tenantLoad.LotNo.Substring(0, 20) + "...";
            }
            lblRAddress.Text = rAddress;
            lblRLotNo.Text = rLotNo;
            txtRMonthly.Text = tenantLoad.MonthlyRent.ToString();
            txtRCumulative.Text = tenantLoad.CumulativeRent.ToString();
            dtRStart.Value = tenantLoad.TenureStart;
            dtREnd.Value = tenantLoad.TenureEnd;
            updateReceivable();
        }

        private void txtR_Changed(object sender, EventArgs e)
        {
            //updateReceivable();
            countUnpaid();
        }

        private void dt_Changed(object sender, EventArgs e)
        {
            //updateReceivable();
            countUnpaid();
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            if(txtRCumulative.Text.Trim() == string.Empty || txtRMonthly.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all the entries!", "Warning!");
                return;
            }
            TimeSpan checkSpan = dtREnd.Value - dtRStart.Value;
            if(Convert.ToDecimal(checkSpan.Days) < 30)
            {
                MessageBox.Show("Minimum tenure span is 30 days!", "Warning");
                return;
            }
            string saveTenantDir = CurrentPath + Database + currentLoad + cbRTenant.SelectedItem.ToString() + ".db";
            Console.WriteLine("Saving tenant to {0}", saveTenantDir);
            XmlReader readXML = XmlReader.Create(saveTenantDir);
            XmlDocument saveXML = new XmlDocument();
            saveXML.Load(readXML);
            saveXML.SelectSingleNode("//Details/Start").InnerText = dtRStart.Value.ToShortDateString();
            saveXML.SelectSingleNode("//Details/End").InnerText = dtREnd.Value.ToShortDateString();
            saveXML.SelectSingleNode("//Details/Rent").InnerText = txtRMonthly.Text.ToString();
            saveXML.SelectSingleNode("//Details/Total").InnerText = txtRCumulative.Text.ToString();
            saveXML.Save(saveTenantDir + ".tmp");
            readXML.Close();
            System.IO.File.Delete(saveTenantDir);
            System.IO.File.Move(saveTenantDir + ".tmp", saveTenantDir);
            loadTenants();
            updateRentals();
            countUnpaid();
        }

        private void btnRRefresh_Click(object sender, EventArgs e)
        {
            updateReceivable();
            countUnpaid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            cbSTenant.Items.Clear();
            if(TenantPathList.Count == 0)
            {
                MessageBox.Show("Please ensure you have tenants before attempting exporting.", "Warning");
                return;
            }
            cbSTenant.Visible = true;
            cbSTenant.Items.Add("Select an Address.");
            //Check all possible addresses
            List<string> addressList = new List<string>();
            SharedCode.Tenant addTenant;
            for (int loopVar = 0; loopVar < TenantList.Count; loopVar++)
            {
                addTenant = TenantList[loopVar];
                if(addressList.IndexOf(addTenant.Address) == -1) //Check if address is already added
                {
                    addressList.Add(addTenant.Address);
                    cbSTenant.Items.Add(addTenant.Address);
                }
            }
            
        }

        private void cbSTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSTenant.SelectedIndex == 0)
            {
                return;
            }
            //Create a file save dialog so user can choose where to save the file
            SaveFileDialog exportDialog = new SaveFileDialog();
            exportDialog.Filter = "Excel File|*.xls";
            exportDialog.Title = "Export Tenants to Excel";
            if (exportDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string exportDir = exportDialog.FileName;
                Console.WriteLine("Exporting spreadsheet to {0}.", exportDir);
                Workbook tenantWorkbook = new Workbook();
                Worksheet tenantWorkSheet = new Worksheet(cbSTenant.SelectedItem.ToString());
                tenantWorkSheet.Cells[0, 0] = new Cell("Number");
                tenantWorkSheet.Cells[0, 1] = new Cell("Tenant");
                tenantWorkSheet.Cells[0, 2] = new Cell("Monthly Rental");
                tenantWorkSheet.Cells[0, 3] = new Cell("Lot No");
                tenantWorkSheet.Cells[0, 4] = new Cell("Tenure Start");
                tenantWorkSheet.Cells[0, 5] = new Cell("Tenure End");
                tenantWorkSheet.Cells[0, 6] = new Cell("Cumulative of Total Collection");
                SharedCode.Tenant exportTenant;
                int currentRow = 1;
                for (int loopVar = 0; loopVar < TenantList.Count; loopVar++)
                {
                    exportTenant = TenantList[loopVar];
                    if(exportTenant.Address == cbSTenant.SelectedItem.ToString())
                    {
                        Console.WriteLine("Exporting tenants from {0}", cbSTenant.SelectedItem);
                        tenantWorkSheet.Cells[currentRow, 0] = new Cell(currentRow);
                        tenantWorkSheet.Cells[currentRow, 1] = new Cell(exportTenant.Name);
                        tenantWorkSheet.Cells[currentRow, 2] = new Cell(exportTenant.MonthlyRent);
                        tenantWorkSheet.Cells[currentRow, 3] = new Cell(exportTenant.LotNo);
                        tenantWorkSheet.Cells[currentRow, 4] = new Cell(exportTenant.TenureStart.ToShortDateString());
                        tenantWorkSheet.Cells[currentRow, 5] = new Cell(exportTenant.TenureEnd.ToShortDateString());
                        tenantWorkSheet.Cells[currentRow, 6] = new Cell(exportTenant.CumulativeRent);
                        currentRow += 1;
                    }
                }
                tenantWorkbook.Worksheets.Add(tenantWorkSheet);
                tenantWorkbook.Save(exportDir);
            }
            cbSTenant.Items.Clear();
            cbSTenant.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.Show();
        }  
    }
}
