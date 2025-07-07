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
        public frmAllProperties()
        {
            InitializeComponent();
        }

        private void frmAllProperties_Load(object sender, EventArgs e)
        {
            ucShowAllProperties1.GetAllProperties();
        }
    }
}
