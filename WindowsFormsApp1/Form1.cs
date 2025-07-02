using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Buildings;
using WindowsFormsApp1.Login;
using WindowsFormsApp1.Tenats;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        frmLogin _frmLogin;

        public Form1(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin=frm;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTenantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewTenant frm = new frmAddNewTenant();
            frm.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTenants frm = new frmManageTenants();
            frm.ShowDialog();
        }

        private void addNewBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBuilding frm = new frmAddNewBuilding();
            frm.ShowDialog();
        }

        private void viewListOfAllBuildingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBuildings frm = new frmManageBuildings();
            frm.ShowDialog();
        }
    }
}
