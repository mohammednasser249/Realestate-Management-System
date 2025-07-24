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
    public partial class UcShowAllPropertiesWithFilter : UserControl
    {
        public UcShowAllPropertiesWithFilter()
        {
            InitializeComponent();
        }

        // Event 
        public Action<int> OnSearch;

        protected virtual void SearchComplete(int buildingid)
        {
            Action<int> handler = OnSearch;
            if (handler != null)
            {
                handler(buildingid);
            }
        }

        private void UcShowAllPropertiesWithFilter_Load(object sender, EventArgs e)
        {
            ucShowAllProperties1.GetAllProperties(Convert.ToInt32(txtValue.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int buildingid = Convert.ToInt32(txtValue.Text);

            if(OnSearch != null)
                SearchComplete(buildingid);
        }
    }
}
