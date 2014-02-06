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

namespace SharedClass
{
    public class SharedCode
    {
        #region "Declaration"
        public string CurrentPath = Directory.GetCurrentDirectory();
        const string Database = "\\UserDataBase\\";
        public struct appUser
        {
            public string Name;
            public string IC;
            public string HomeAddress;
            public string HouseNumber;
            public string PhoneNumber;
            public string Email;
            public string Password;
        }
        public struct Tenant
        {
            public string Name;
            public string LotNo;
            public string PhoneNo;
            public string LandNo;
            public string Email;
            public string Remarks;
            public string Address;
            public DateTime TenureStart;
            public DateTime TenureEnd;
            public decimal MonthlyRent;
            public decimal CumulativeRent;
        }
        #endregion

        #region "Encryption"
        public void EncryptFile(string inputFile, string outputFile, string securityKey)
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
        public bool DecryptFile(string inputFile, string outputFile, string securityKey)
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

        public appUser loadGeneral()
        {
            appUser currentUser = new appUser();
            XmlReader readXML = XmlReader.Create("currentload.db");
            while (readXML.Read())
            {
                if (readXML.NodeType == XmlNodeType.Element && readXML.Name == "Database")
                {
                    while (readXML.NodeType != XmlNodeType.EndElement)
                    {
                        readXML.Read();
                        if (readXML.Name == "Details")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.Name == "UserName")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.Name = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                                if (readXML.Name == "IC")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.IC = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                                if (readXML.Name == "Address")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.HomeAddress = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                                if (readXML.Name == "HouseNo")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.HouseNumber = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                                if (readXML.Name == "PhoneNo")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.PhoneNumber = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                                if (readXML.Name == "Email")
                                {
                                    while (readXML.NodeType != XmlNodeType.EndElement)
                                    {
                                        readXML.Read();
                                        if (readXML.NodeType == XmlNodeType.Text)
                                        {
                                            currentUser.Email = readXML.Value;
                                        }
                                    }
                                    readXML.Read();
                                }
                            }
                        }
                    }
                }
            }
            readXML.Close();
            return currentUser;
        } //Loads a user's general settings

        public void saveGeneral(appUser setUser)
        {
            XmlReader readXML = XmlReader.Create("currentload.db");
            XmlDocument saveXML = new XmlDocument();
            saveXML.Load(readXML);
            saveXML.SelectSingleNode("//Database/Details/UserName").InnerText = setUser.Name;
            saveXML.SelectSingleNode("//Database/Details/IC").InnerText = setUser.IC;
            saveXML.SelectSingleNode("//Database/Details/Address").InnerText = setUser.HomeAddress;
            saveXML.SelectSingleNode("//Database/Details/HouseNo").InnerText = setUser.HouseNumber;
            saveXML.SelectSingleNode("//Database/Details/PhoneNo").InnerText = setUser.PhoneNumber;
            saveXML.SelectSingleNode("//Database/Details/Email").InnerText = setUser.Email;
            saveXML.Save("saveNew.db");
        } //Saves a user's general settings

        public Tenant loadTenantInfo(string tenantDir)
        {
            Console.WriteLine("Loading tenant from direcory {0}", tenantDir);
            Tenant loadTenant = new Tenant();
            XmlReader readXML = XmlReader.Create(tenantDir);
            while (readXML.Read())
            {
                if (readXML.NodeType == XmlNodeType.Element && readXML.Name == "Details")
                {
                    while (readXML.NodeType != XmlNodeType.EndElement)
                    {
                        readXML.Read();
                        if (readXML.Name == "UserName")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.Name = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "LotNo")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.LotNo = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "PhoneNo")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.PhoneNo = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "LandNo")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.LandNo = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Email")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.Email = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Address")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.Address = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Remarks")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.Remarks = readXML.Value;
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Start")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.TenureStart = Convert.ToDateTime(readXML.Value);
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "End")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.TenureEnd = Convert.ToDateTime(readXML.Value);
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Rent")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.MonthlyRent = Convert.ToDecimal(readXML.Value);
                                }
                            }
                            readXML.Read();
                        }
                        if (readXML.Name == "Total")
                        {
                            while (readXML.NodeType != XmlNodeType.EndElement)
                            {
                                readXML.Read();
                                if (readXML.NodeType == XmlNodeType.Text)
                                {
                                    loadTenant.CumulativeRent = Convert.ToDecimal(readXML.Value);
                                }
                            }
                            readXML.Read();
                        }
                    }
                }
            }
            readXML.Close();
            return loadTenant;
        } //Reads a tenant database and returns the information as a tenant structure

        public void txtFocus(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.SelectAll();
        }//Selects all the text in the textbox

        public bool alphanumericTest(String testString)
        {
            Regex testREGEX = new Regex("^[a-zA-Z0-9]*$");
            if (testREGEX.IsMatch(testString) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//Tests if a string is alphanumeric
    }
}