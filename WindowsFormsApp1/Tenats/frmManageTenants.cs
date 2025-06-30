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
    public partial class frmManageTenants : Form
    {
        public frmManageTenants()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllTenants= clsTenantBL.GetAllTenants();
        private void _GetAllTenants()
        {
            dataGridView1.DataSource = _dtAllTenants;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;

            lbNumberOfRecords.Text=dataGridView1.RowCount.ToString();

            cbFilter.Items.Add("None");
            cbFilter.SelectedIndex = 0;

        }

        private void _FillComboBox()
        {

            foreach(DataColumn dr in _dtAllTenants.Columns)
            {
                cbFilter.Items.Add(dr.ColumnName.ToString());
            }
        }
        private void frmManageTenants_Load(object sender, EventArgs e)
        {
            _GetAllTenants();
            _FillComboBox();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frm = new frmAddNewTenant((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _GetAllTenants();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTenatDetails frm = new frmShowTenatDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frm = new frmAddNewTenant();
            frm.ShowDialog();
            _GetAllTenants(); // Refereash 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TenantId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if(MessageBox.Show($"Are you sure you want to delete Tenant with ID = {TenantId}" ,"Error",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {

                if(clsTenantBL.Delete(TenantId))
                {

                    MessageBox.Show($"Tenant with ID ={TenantId} has been deleted succussfully ", "Deleted");
                }else
                    MessageBox.Show($"Tenant with ID ={TenantId} has not been deleted", "Failed to be Deleted");


            }
        }

        private void addNewTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frmAddNewTenant = new frmAddNewTenant();
            frmAddNewTenant.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           if(txtSearch.Text.Trim()=="" || cbFilter.SelectedIndex==0)
            {
                _dtAllTenants.DefaultView.RowFilter = "";
                lbNumberOfRecords.Text=_dtAllTenants.Rows.Count.ToString();
                return;
            }

            if (cbFilter.SelectedIndex == 1) // Because TenantID is a number so we do this 
                _dtAllTenants.DefaultView.RowFilter = string.Format("[{0}]={1}", cbFilter.SelectedItem, txtSearch.Text.Trim());
            else
            _dtAllTenants.DefaultView.RowFilter = string.Format(" [{0}] Like '{1}%'",cbFilter.SelectedItem,txtSearch.Text.Trim());

            lbNumberOfRecords.Text = _dtAllTenants.Rows.Count.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Focus();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
