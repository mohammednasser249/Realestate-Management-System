using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Global_Classes;
using Microsoft.Win32;

namespace WindowsFormsApp1.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUserBL User = clsUserBL.Find(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (User != null)
            {
                clsGlobal.CurrentUser = User;
                this.Hide();
                Form1 frm = new Form1(this);
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\RealestateProject";

                if (cbRemeberMe.Checked)
                {
                    string valueName = txtUsername.Text.Trim();
                    string valueData = txtPassword.Text.Trim();

                    try
                    {
                        // Write the User Name and password  to the Registry
                        Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }



                }
                else
                {
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\RealestateProject", true); // open with write access

                        if (key != null)
                        {
                            string valueName = txtUsername.Text.Trim(); // same key used for storing
                            if (key.GetValue(valueName) != null)
                            {
                                key.DeleteValue(valueName);
                            }

                            key.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }

                frm.ShowDialog();

               

               
            }else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password .", "Wrong credintals", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
         
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string keyPath = @"SOFTWARE\RealestateProject";

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath);

                if (key != null)
                {
                    // Get all value names (e.g., all usernames)
                    string[] valueNames = key.GetValueNames();

                    foreach (string name in valueNames)
                    {
                        string value = key.GetValue(name) as string;


                    // Fill the UI with the first one
                        txtUsername.Text = name;
                        txtPassword.Text = value;
                    }

                    key.Close();
                }
                else
                {
                    Console.WriteLine("Registry key not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }



        }
    }
}
