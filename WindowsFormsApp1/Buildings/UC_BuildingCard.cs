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
                return;
            }

            _FillBuildingInfo();


        }

        private void _FillBuildingInfo()
        {
            lbTenantID.Text=Building.BuildingID.ToString();
            lbBuildingName.Text = Building.BuildingName;
            lbAddress.Text = Building.City;
            lbC.Text = Building.Address;
            lbFloors.Text=Building.NumberOfFloors.ToString();
            lbProperties.Text=Building.NumberOfProperties.ToString();



        }

        private void UC_BuildingCard_Load(object sender, EventArgs e)
        {

        }
    }
}
