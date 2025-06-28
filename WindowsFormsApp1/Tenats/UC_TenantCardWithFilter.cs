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

namespace WindowsFormsApp1.Tenats
{
    public partial class UC_TenantCardWithFilter : UserControl
    {
        public UC_TenantCardWithFilter()
        {
            InitializeComponent();
        }


        private bool _ShowAddTenant = true;
        public bool ShowAddTenant
        {
            get
            {
                return _ShowAddTenant;
            }
            set
            {
                _ShowAddTenant=value;
                btnAddTenant.Visible=_ShowAddTenant;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled=value;
                groupBox1.Enabled = _FilterEnabled;
            }
        }


        private int _TenantID = -1;

        public  int TenantID
        {
            get
            {
                return uC_Tenant1.TenantId;
            }
        }

        public clsTenantBL SelectedTenant
        {
            get
            {
                return uC_Tenant1.Tenant;
            }
        }

        public void LoadTenantInfo(int TenantID)
        {
            cbFilter.SelectedIndex = 0;
            txtSearch.Text = TenantID.ToString();
            FindNow();
            
        }

        private void FindNow()
        {
            uC_Tenant1.LoadTenantInfo(int.Parse(txtSearch.Text));
            if(OnTenantSelected!=null && FilterEnabled)
            {
                OnTenantSelected(uC_Tenant1.TenantId);
            }
        }

        // Define a custom event handler delegate with parameters 
        public event Action<int> OnTenantSelected;

        // Create a protected method to raise the event with a parameter 

        protected virtual void TenantSelected(int TenantID)
        {

            Action<int> handler = OnTenantSelected;
            if (handler != null)
            {
                handler(TenantID);
            }
        }


        private void UC_TenantCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Add("Tenant ID");
            cbFilter.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frm = new frmAddNewTenant();
            frm.DataBack+=DataBackEvent; // subscribe to the event 
            frm.ShowDialog();

        }

        private void DataBackEvent(object sender, int TenantID)
        {
            cbFilter.SelectedIndex = 0;
            txtSearch.Text=TenantID.ToString();
            uC_Tenant1.LoadTenantInfo(TenantID);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {

                btnSearchTenant.PerformClick();
            }
            // Only Numebrs 
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
