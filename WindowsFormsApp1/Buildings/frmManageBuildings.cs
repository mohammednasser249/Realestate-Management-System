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

namespace WindowsFormsApp1.Buildings
{
    public partial class frmManageBuildings : Form
    {
        public frmManageBuildings()
        {
            InitializeComponent();
        }

        private DataTable _dtAllBuildings = clsBuildingBL.GetAllBuildings();


        private void _FillComboBox()
        {
            cbFilter.Items.Add("None");
            cbFilter.SelectedIndex = 0;

            foreach (DataColumn dataColumn in _dtAllBuildings.Columns)
            {

                cbFilter.Items.Add(dataColumn.ColumnName);
            }
        }

        private void _GetAllBuildings()
        {

            dataGridView1.DataSource = _dtAllBuildings;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[5].Width = 120;
            lbNumberOfRecords.Text = _dtAllBuildings.Rows.Count.ToString();



        }

        private void frmManageBuildings_Load(object sender, EventArgs e)
        {
            _FillComboBox();
            _GetAllBuildings();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                
            }
            else
                txtSearch.Visible = true;
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" || cbFilter.SelectedIndex == 0)
            {
                _dtAllBuildings.DefaultView.RowFilter = " ";
                lbNumberOfRecords.Text = _dtAllBuildings.Rows.Count.ToString();

                return;

            }



            if (cbFilter.SelectedIndex == 1)
            {
                _dtAllBuildings.DefaultView.RowFilter = string.Format("[{0}]={1}", cbFilter.SelectedItem, txtSearch.Text.Trim());
            }else
                _dtAllBuildings.DefaultView.RowFilter = string.Format("[{0}] like '%{1}'", cbFilter.SelectedItem, txtSearch.Text);

            lbNumberOfRecords.Text = _dtAllBuildings.Rows.Count.ToString();


        }

        private void showBuildingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBuildingDetails frmShowBuildingDetails = new frmShowBuildingDetails((int)dataGridView1.CurrentRow.Cells[0].Value); ;
            frmShowBuildingDetails.ShowDialog();
        }

        private void addNewBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBuilding frm = new frmAddNewBuilding();
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBuilding frm = new frmAddNewBuilding((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
