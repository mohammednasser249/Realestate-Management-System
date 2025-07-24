using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Property
{
    public partial class frmAllProperties : Form
    {
        private int _BuldingID;
        public frmAllProperties(int buldingID)
        {
            InitializeComponent();
            _BuldingID = buldingID; 
        }

        private void frmAllProperties_Load(object sender, EventArgs e)
        {
            lbBuildingID.Text = _BuldingID.ToString();
            ucShowAllProperties1.GetAllProperties(_BuldingID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddNewProperty frm = new frmAddNewProperty(_BuldingID,-1);
            frm.ShowDialog();
        }

       
    }
}
