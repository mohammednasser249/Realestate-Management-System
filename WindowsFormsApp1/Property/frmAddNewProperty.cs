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

namespace WindowsFormsApp1.Property
{
    public partial class frmAddNewProperty : Form
    {

        private int _PropertyID;
        private int _BuildingID;

        clsPropertyBL Property;

        enum enMode
        {
            AddNew,
            Update
        }
        private enMode _EnMode;

        public frmAddNewProperty()
        {
            InitializeComponent();
           
        }
        public frmAddNewProperty(int buidlingID,int PropertyID)
        {
            InitializeComponent();
            if (PropertyID == -1)
            {
                _BuildingID = buidlingID;
                _PropertyID = -1;
                _EnMode = enMode.AddNew;
            }
            else
            {
                _PropertyID = PropertyID;
                _EnMode = enMode.Update;
            }
        }


        private async void _LoadData()
        {
            if (_EnMode == enMode.AddNew)
            {
                 Property = new clsPropertyBL();
               
                lbTitle.Text = "Add New Property";
                lbID.Text=_BuildingID.ToString();

            }else
            {
                Property = await clsPropertyBL.FindAsync(_PropertyID);

                if (Property == null)
                {

                    MessageBox.Show("This property could not be found ");
                }

                lbTitle.Text = "Update Property";

                txtRentPrice.Text = Property.RentPrice.ToString();
                txtPropertyName.Text = Property.PropertyName;
                txtNumberOFfloors.Text = Property.NumberOfFloors.ToString();
                txtNumberOfKitchens.Text = Property.NumberOfKitchens.ToString();
                txtNumberOfrooms.Text = Property.NumberOfRooms.ToString();
                txtArea.Text = Property.Area.ToString();
                dateTimePicker1.Value = Property.AvailableFrom;
                rbYes.Checked = Property.IsOccupied;
                rbNo.Checked = !Property.IsOccupied;
                comboBox1.SelectedItem = Property.Status;
                txtNotes.Text = Property.Notes;
                lbID.Text= Property.BuildingID.ToString();


            }

        }

        private void frmAddNewProperty_Load(object sender, EventArgs e)
        {
            // Adding the building id where we want to add the property to 
            comboBox1.Items.Add("Maintenance");
            comboBox1.Items.Add("Occupied");
            comboBox1.Items.Add("Available");
            
          
                _LoadData();
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Filling the object 
            Property.BuildingID = _BuildingID;
            Property.RentPrice = Convert.ToInt32(txtRentPrice.Text);
            Property.PropertyName = txtPropertyName.Text;
            Property.NumberOfFloors=Convert.ToInt32(txtNumberOFfloors.Text);
            Property.NumberOfKitchens=Convert.ToInt32(txtNumberOfKitchens.Text);
            Property.NumberOfRooms=Convert.ToInt32(txtNumberOfrooms.Text);
            Property.Area = Convert.ToInt32(txtArea.Text);
            Property.AvailableFrom = dateTimePicker1.Value;
            if (rbYes.Checked)
                Property.IsOccupied = true;
            else
                Property.IsOccupied = false;
            Property.Status = comboBox1.SelectedItem.ToString();
            Property.Notes = txtNotes.Text;

            if(Property.Save())
            {
                lbTitle.Text = "Update Property";
                MessageBox.Show("Property has been save succussfully");
            }else
            {
                MessageBox.Show("Property failed to be saved");
            }



        }
    }
}
