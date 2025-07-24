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
namespace WindowsFormsApp1.Property
{
    public partial class UcShowAllProperties : UserControl
    {
        public UcShowAllProperties()
        {
            InitializeComponent();
        }

        private int _BuildingID;

        private DataTable _GetAllProperties;



        public void GetAllProperties(int buildingid)
        {
            _BuildingID=buildingid;
            dataGridView1.DataSource = clsPropertyBL.GetAllProperties(buildingid);
        }

        private void UcShowAllProperties_Load(object sender, EventArgs e)
        {


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewProperty frm = new frmAddNewProperty(_BuildingID, (int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
