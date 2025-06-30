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
using WindowsFormsApp1.Tenats;

namespace WindowsFormsApp1.Buildings
{
    public partial class frmAddNewBuilding : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int BuildingID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

       public enum enMode { AddNew , Update}

        public enMode Mode;

        private int BuildingId = -1;

        clsBuildingBL Building;
        
        public frmAddNewBuilding()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddNewBuilding(int buildingId )
        {
            InitializeComponent();
            BuildingId = buildingId;
            Mode = enMode.Update;
            
        }


       
        private void _ResetValues()
        {

            if( Mode == enMode.AddNew )
            {
                lbTitle.Text = "Add New Building";
                Building = new clsBuildingBL();
            }
            else
                lbTitle.Text = "Update Building";
        }

        private void frmAddNewBuilding_Load(object sender, EventArgs e)
        {

            _ResetValues();

            if (Mode==enMode.Update)
            {
                Building = clsBuildingBL.Find(BuildingId);
                _LoadData();
                
            }
        }

        private void _LoadData()
        {

            txtAddress.Text=Building.Address.ToString();
            txtCity.Text=Building.City;
            txtFloors.Text=Building.NumberOfFloors.ToString();
            txtProperties.Text=Building.NumberOfProperties.ToString();
            lbTenantID.Text=Building.BuildingID.ToString();
            txtBuildingName.Text=Building.BuildingName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            Building.BuildingName = txtBuildingName.Text;
            Building.Address = txtAddress.Text;
            Building.City = txtCity.Text;
            if (int.TryParse(txtFloors.Text, out int floors) && int.TryParse(txtProperties.Text, out int properties))
            {
                Building.NumberOfFloors = floors;
                Building.NumberOfProperties = properties;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for floors and properties.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Building.CreatedByUser = 1; // For now only one user 

            if(Building.Save())
            {

                MessageBox.Show("Building has been saved succussfully", "Saved", MessageBoxButtons.OK);
                Mode=enMode.Update;
                lbTitle.Text = "Update Building";

                DataBack?.Invoke(this, Building.BuildingID); // To raise the event once we saved 


            }
            else
                MessageBox.Show("Building has failed to be saved", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);




        }
    }
}
