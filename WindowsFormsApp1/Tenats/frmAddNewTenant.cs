using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using WindowsFormsApp1.Global_Classes;
using WindowsFormsApp1.Properties;
using System.IO;

namespace WindowsFormsApp1.Tenats
{
    public partial class frmAddNewTenant : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;
        private int _TenantID = -1;
        clsTenantBL _Tenant;
        public frmAddNewTenant()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddNewTenant(int Id)
        {
            InitializeComponent();
            _TenantID = Id;
            Mode = enMode.Update;
        }

        private bool _HandelPersonImage()
        {

            if (_Tenant.ImagePath != pictureBox1.ImageLocation)
            {
                if (_Tenant.ImagePath != " ")
                {
                    try
                    {
                        File.Delete(_Tenant.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (pictureBox1.ImageLocation !="")
            {
                string SourceImage = pictureBox1.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImage))
                {
                    
                        pictureBox1.ImageLocation=SourceImage;
                        return true;
                    
                }else
                {
                    MessageBox.Show("Error Copying image to the file","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
             
            }
            return true;
        }


            private void _FillCountrisInComboBox()
            {

                DataTable dt = clsCountryBL.GetAllCountries();
                foreach (DataRow dr in dt.Rows)
                {
                    cbCountry.Items.Add(dr["CountryName"]);
                }


            }
            private Image ResizeImage(Image image, int width, int height)
            {
                Bitmap resized = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(resized))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                    g.DrawImage(image, 0, 0, width, height);
                }
                return resized;
            }


            private void _ResetDefalutValues()
            {
                _FillCountrisInComboBox();

                if (Mode == enMode.AddNew)
                {
                    lbTitle.Text = "Add New Tenant";
                    _Tenant = new clsTenantBL();

                }
                else
                    lbTitle.Text = "Update Tenant";

                // set defalut 
                if (rdMale.Checked)
                {
                    pictureBox1.Image = Resources.Male_512;
                }
                else
                {

                    pictureBox1.Image = Resources.Female_512;
                }


                llRemove.Visible = (pictureBox1.ImageLocation != null);

                // At least 18 years old 
                dtDOB.MaxDate = DateTime.Now.AddYears(-18);

                dtDOB.MaxDate = DateTime.Now.AddDays(-100);

                cbCountry.SelectedIndex = cbCountry.FindString("Sudan");


            }

            private void _LoadData()
            {
                // Load the object with its data 
                _Tenant = clsTenantBL.Find(_TenantID);

                if (_Tenant == null)
                {
                    MessageBox.Show($"No Person with ID ={_Tenant} Tenant was not found ");
                    this.Close();
                    return;
                }

                // Filling the back the data from object 
                lbTenantID.Text=_Tenant.TenantID.ToString();
                txtFirst.Text = _Tenant.FirstName;
                txtSecond.Text = _Tenant.SecondName;
                txtThird.Text = _Tenant.ThirdName;
                txtLast.Text = _Tenant.LastName;
                txtEmail.Text = _Tenant.Email;
                txtPhone.Text = _Tenant.Phone;
                txtPassportNO.Text = _Tenant.PassportNumber;
                txtEID.Text = _Tenant.EmiratesID;

                if (_Tenant.Gender == 1)
                    rdMale.Checked = true;
                else
                    rdFemale.Checked = true;

                cbCountry.SelectedIndex = cbCountry.FindString(clsCountryBL.Find(_Tenant.CountryID).CountryName);

                // Load Image 
                if (_Tenant.ImagePath != null)
                {
                    pictureBox1.ImageLocation = _Tenant.ImagePath;
                }

                llRemove.Enabled = (_Tenant.ImagePath != null);

                dtDOB.Value = _Tenant.DateOfBirth;
                dtEIDIssueDate.Value = _Tenant.EmiratesIDIssueDate;
                dtEIDExpDate.Value = _Tenant.EmiratesIDExpDate;
                dtPassportIssueDate.Value = _Tenant.PassPortIssueDate;
                dtPassportExpDate.Value = _Tenant.PassportExpDate;

            }

            private void frmAddNewTenant_Load(object sender, EventArgs e)
            {
                _ResetDefalutValues();

                if (Mode == enMode.Update)
                {
                    _LoadData();
                }

            }

            private void btnSave_Click(object sender, EventArgs e)
            {

                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some Fields are not valid ");
                    return;

                }

            if (!_HandelPersonImage())
                return;

            int CountryID = clsCountryBL.Find(cbCountry.Text).ID;

                _Tenant.FirstName = txtFirst.Text.Trim();
                _Tenant.SecondName = txtSecond.Text.Trim();
                _Tenant.ThirdName = txtThird.Text.Trim();
                _Tenant.LastName = txtLast.Text.Trim();
                _Tenant.Email = txtEmail.Text.Trim();
                _Tenant.Phone = txtPhone.Text.Trim();
                _Tenant.DateOfBirth = dtDOB.Value;
                _Tenant.EmiratesID = txtEID.Text.Trim();
                _Tenant.EmiratesIDIssueDate = dtEIDIssueDate.Value;
                _Tenant.EmiratesIDExpDate = dtEIDExpDate.Value;
                _Tenant.PassportNumber = txtPassportNO.Text.Trim();
                _Tenant.PassPortIssueDate = dtPassportIssueDate.Value;
                _Tenant.PassportExpDate = dtPassportExpDate.Value;
                if (rdMale.Checked)
                    _Tenant.Gender = 1;
                else
                    _Tenant.Gender = 2;
                _Tenant.CountryID = CountryID;

                if (_Tenant.Save())
                {
                    lbTenantID.Text = _Tenant.TenantID.ToString();
                    //Change Mode
                    Mode = enMode.Update;
                    lbTitle.Text = "Update Tenant";

                    MessageBox.Show("Data Saved Succussfully,", "Saved", MessageBoxButtons.OK);
                    // Trigger the event to send data back to the caller form.
                    DataBack?.Invoke(this, _Tenant.TenantID);

                }
                else
                    MessageBox.Show("Data Faild to be Saved", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            private void rdMale_CheckedChanged(object sender, EventArgs e)
            {
                pictureBox1.Image = Resources.Male_512;
            }

            private void rdFemale_CheckedChanged(object sender, EventArgs e)
            {
                pictureBox1.Image = Resources.Female_512;

            }

            private void txtEmail_Validating(object sender, CancelEventArgs e)
            {

                // No need to validate if input is empty 
                if (txtEmail.Text.Trim() == " ")
                    return;

                if (clsValidation.ValidateEmail(txtEmail.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Invalid Email Format");
                }
                else
                    errorProvider1.SetError(txtEmail, null);


            }

            private void EmptyBox_Validating(object sender, CancelEventArgs e)
            {

                // No need to validate if input is empty 
                TextBox Temp = ((TextBox)sender);
                if (string.IsNullOrEmpty(Temp.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(Temp, "This field is required!");
                }
                else
                {
                    //e.Cancel = false;
                    errorProvider1.SetError(Temp, null);
                }


            }

            private void txtPhone_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtPhone_Validating(object sender, CancelEventArgs e)
            {
                if (txtPhone.Text.Trim() == " ")
                    return;
                if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPhone, "Format is wrong");

                }
                else
                    errorProvider1.SetError(txtPhone, null);
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Process the selected file
                    string selectedFilePath = openFileDialog1.FileName;
                    pictureBox1.Load(selectedFilePath);
                    llRemove.Visible = true;
                    // ...
                }
            }

            private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                pictureBox1.ImageLocation = null;

                if (rdMale.Checked)
                    pictureBox1.Image = Resources.Male_512;
                else
                    pictureBox1.Image = Resources.Female_512;

                llRemove.Visible = false;
            }
        }

    }


