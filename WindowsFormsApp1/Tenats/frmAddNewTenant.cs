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
namespace WindowsFormsApp1.Tenats
{
    public partial class frmAddNewTenant : Form
    {

      public  enum enMode { AddNew = 0 , Update = 1 }
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

        private void _FillCountrisInComboBox()
        {

            DataTable dt = clsCountryBL.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }


        }

        private void _ResetDefalutValues()
        {
            _FillCountrisInComboBox();

            if(Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add New Tenant";
                _Tenant= new clsTenantBL();

            }
            else
                lbTitle.Text = "Update Tenant";

            // set defalut 
            if (rdMale.Checked)
            {
                Image originalImage = imageList1.Images[1];
                Image resizedImage = new Bitmap(originalImage, new Size(512, 512));
                pictureBox1.Image = resizedImage;

            }
            else
            {
                Image originalImage = imageList1.Images[0];
                Image resizedImage = new Bitmap(originalImage, new Size(512, 512));
                pictureBox1.Image = resizedImage;

            }   

            llRemove.Visible =(pictureBox1.ImageLocation != null);

            // At least 18 years old 
            dtDOB.MaxDate = DateTime.Now.AddYears(-18);

            dtDOB.MaxDate =DateTime.Now.AddDays(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Sudan");






        }

        private void _LoadData()
        {
            // Load the object with its data 
            _Tenant = clsTenantBL.Find(_TenantID);

            if(_Tenant == null )
            {
                MessageBox.Show($"No Person with ID ={_Tenant} Tenant was not found ");
                this.Close();
                return;
            }

            // Filling the back the data from object 

            txtFirst.Text = _Tenant.FirstName;
            txtSecond.Text = _Tenant.SecondName;
            txtThird.Text = _Tenant.ThirdName;
            txtLast.Text = _Tenant.LastName;
            txtEmail.Text = _Tenant.Email;
            txtPhone.Text = _Tenant.Phone;
            txtPassportNO.Text =_Tenant.PassportNumber;
            txtEID.Text = _Tenant.EmiratesID;
            
            if(_Tenant.Gender == 1 )
                rdMale.Enabled = true;
            else rdFemale.Enabled = true;

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountryBL.Find(_Tenant.CountryID).CountryName);

            // Load Image 
            if(_Tenant.ImagePath !=null )   
            {
                pictureBox1.ImageLocation=_Tenant.ImagePath;
            }

            llRemove.Enabled = (_Tenant.ImagePath!=null);

            dtDOB.Value = _Tenant.DateOfBirth;
            dtEIDIssueDate.Value = _Tenant.EmiratesIDIssueDate;
            dtEIDExpDate.Value = _Tenant.EmiratesIDExpDate;
            dtPassportIssueDate.Value= _Tenant.PassPortIssueDate;
            dtPassportExpDate.Value=_Tenant.PassportExpDate;

        }

        private void frmAddNewTenant_Load(object sender, EventArgs e)
        {
            _ResetDefalutValues();

            if(Mode==enMode.Update)
            {
                _LoadData();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int CountryID = clsCountryBL.Find(cbCountry.Text).ID;

            _Tenant.FirstName=txtFirst.Text.Trim();
            _Tenant.SecondName = txtSecond.Text.Trim();
            _Tenant.ThirdName = txtThird.Text.Trim();
            _Tenant.LastName = txtLast.Text.Trim();
            _Tenant.Email = txtEmail.Text.Trim();
            _Tenant.Phone = txtPhone.Text.Trim();
            _Tenant.DateOfBirth = dtDOB.Value;
            _Tenant.EmiratesID=txtEID.Text.Trim();
            _Tenant.EmiratesIDIssueDate=dtEIDIssueDate.Value;
            _Tenant.EmiratesIDExpDate=dtEIDExpDate.Value;
            _Tenant.PassportNumber=txtPassportNO.Text.Trim();
            _Tenant.PassPortIssueDate=dtPassportIssueDate.Value;
            _Tenant.PassportExpDate=dtPassportExpDate.Value;
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
            }
            else
                MessageBox.Show("Data Faild to be Saved", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);


        }
    }
}
