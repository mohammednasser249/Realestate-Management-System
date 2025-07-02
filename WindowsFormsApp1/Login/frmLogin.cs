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
using WindowsFormsApp1.Global_Classes;

namespace WindowsFormsApp1.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUserBL User = clsUserBL.Find(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (User != null)
            {
                clsGlobal.CurrentUser = User;
                this.Hide();
                Form1 frm = new Form1(this);
                frm.ShowDialog();

               
            }else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password .", "Wrong credintals", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }    
        }
    }
}
