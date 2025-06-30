using DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsBuildingBL
    {
        enum enMode { AddNew,Update};
        enMode Mode;
         public int BuildingID {  get; set; }
        public string BuildingName { get; set; }
        public string Address {  get; set; }
        public string City { get; set; }
        public int NumberOfFloors {  get; set; }

        public int NumberOfProperties { get; set; }
        public int CreatedByUser {  get; set; }

        // Constructor 

        public clsBuildingBL()
        {
            BuildingID = -1;
            BuildingName = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            NumberOfFloors = -1;
            NumberOfProperties = -1;
            CreatedByUser = -1;
            Mode=enMode.AddNew;
        }

        // Parametrized constructor 

        public clsBuildingBL(int buildingid , string buildingname , string address , string city , int numberoffloors,int numberofproperties,int createdbyuser)
        {
            BuildingID = buildingid;
            BuildingName = buildingname;
            Address = address;
            City = city;
            NumberOfFloors = numberofproperties;
            CreatedByUser = createdbyuser;
            Mode= enMode.Update;

        }

        // Find 

        public static clsBuildingBL Find(int BuildingID)
        {
            string buildingname = string.Empty;
            string address = string.Empty;
            string city = string.Empty;
            int numberoffloors = 0;
            int numberofproperties = 0;
            int createdbyuser = 0;

            if(clsBuildingDL.GetBuildingInfoByID(BuildingID,ref buildingname,ref address,ref city,ref numberoffloors,ref numberofproperties,ref createdbyuser))
            {
                return new clsBuildingBL(BuildingID,buildingname,address,city,numberoffloors,numberofproperties,createdbyuser);
            }
            return null;
        }


        // Add New Building 

        private  bool _AddNewBuilding()
        {

         this.BuildingID= clsBuildingDL.AddNewBuilding(this.BuildingName,this.Address,this.City,this.NumberOfFloors,this.NumberOfProperties,this.CreatedByUser);

            return this.BuildingID != -1;

        }


        // Update Building

        // GetAllBuildings 

        public static DataTable GetAllBuildings()
        {

            return clsBuildingDL.GetAllBuildings();
        }


        // Save 

        public bool Save()

        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBuilding())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
            }
            return false;

                        

        }

     




    }
}
