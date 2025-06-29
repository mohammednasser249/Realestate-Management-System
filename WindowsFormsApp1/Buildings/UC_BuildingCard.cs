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
    public partial class UC_BuildingCard : UserControl
    {
        public UC_BuildingCard()
        {
            InitializeComponent();
        }

        private int _Buildingid;
        private clsBuildingBL _Building;
        public int Buildingid
        {
            get
            {
                return _Buildingid;
            }
        }
        public clsBuildingBL Building
        {
            get
            {
                return _Building;
            }
        }


        public void LoadBuildingInfo(int BuildingID)
        {

            _Building = clsBuildingBL.Find(BuildingID);
            if(_Building==null)
            {
                MessageBox.Show("There is no building with this id ");
            }

            _FillBuildingInfo();


        }

        private void _FillBuildingInfo()
        {

        }

        private void UC_BuildingCard_Load(object sender, EventArgs e)
        {

        }
    }
}
