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
using WindowsFormsApp1.Properties;
using System.IO;

namespace WindowsFormsApp1.Tenats
{
    public partial class UC_Tenant : UserControl
    {
        private clsTenantBL _Tenant;
        private int _TenantId;
        public int TenantId
        {
            get { return _TenantId; }
        }
        public clsTenantBL Tenant
        {

        get { return _Tenant; }
        
        }


        public void LoadTenantInfo(int TenantID)
        {
            _Tenant = clsTenantBL.Find(TenantID);
            if(_Tenant==null)
            {
                MessageBox.Show($"No Person with PersonID = {TenantID} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void _LoadTenantImage()
        {
            if(_Tenant.Gender==1)
            {
                pictureBox1.Image = Resources.Male_512;
            }else
                pictureBox1.Image= Resources.Female_512;

            string ImagePath = _Tenant.ImagePath;
            if(ImagePath!=" ")
            {
                if (File.Exists(ImagePath))
                    pictureBox1.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"No Person with Tenant ID {_Tenant.TenantID} ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    

        private void _FillTenantInfo()
        {
            _TenantId = _Tenant.TenantID;
            lbFullName.Text =_Tenant.FirstName +" "+_Tenant.SecondName+" "+_Tenant.ThirdName +" " + _Tenant.LastName;
            lbEmiratesID.Text= _Tenant.EmiratesID;
            lbEIDissuedate.Text = _Tenant.EmiratesIDIssueDate.ToString();
            lbEIDExpDate.Text=_Tenant.EmiratesIDExpDate.ToString();
            lbPassportNo.Text = _Tenant.PassportNumber.ToString();
            lbPIssueDate.Text=_Tenant.PassPortIssueDate.ToString();
            lbPExpDate.Text=_Tenant.PassportExpDate.ToString();
            lbEmail.Text = _Tenant.Email;
            lbPhone.Text = _Tenant.Phone;
            if (_Tenant.Gender == 1)
                lbGender.Text = "Male";
            else
                lbGender.Text = "Female";
            lbCountry.Text = clsCountryBL.Find(_Tenant.CountryID).CountryName;

            _LoadTenantImage();


        }
        public UC_Tenant()
        {
            InitializeComponent();
        }

        private void UC_Tenant_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewTenant frmAddNewTenant = new frmAddNewTenant(_TenantId);
            frmAddNewTenant.ShowDialog();

            LoadTenantInfo(TenantId);
        }
    }
}
