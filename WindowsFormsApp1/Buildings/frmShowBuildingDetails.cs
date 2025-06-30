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
    public partial class frmShowBuildingDetails : Form
    {
        public frmShowBuildingDetails(int buildingid)
        {
            InitializeComponent();
            uC_BuildingCard1.LoadBuildingInfo(buildingid);

        }

        private void frmShowBuildingDetails_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
