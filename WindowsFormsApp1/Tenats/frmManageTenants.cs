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

        private void _GetAllTenants()
        {
            dataGridView1.DataSource = clsTenantBL.GetAllTenants();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;


        }
        private void frmManageTenants_Load(object sender, EventArgs e)
        {
            _GetAllTenants();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frm = new frmAddNewTenant((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTenatDetails frm = new frmShowTenatDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();    
        }
    }
}
