using DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAcess.clsPropertyDL;

namespace BussinessLayer
{
    public class clsPropertyBL
    {

       public enum enMode { AddNew , Update};

       public enMode Mode;
       public enum enType { Annually , Monthly };

        int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public enType PropertyType { get; set; }

        public int NumberOfFloors { get; set; }
        public int NumberOfRooms { get; set; }

        public int NumberOfBathRooms {  get; set; }
        public int Area {  get; set; }

        public string Notes { get; set; }
        public int RentPrice {  get; set; }
        public DateTime AvailableFrom { get; set; }

        public bool IsOccupied {  get; set; }
        public string Status {  get; set; }
        public int NumberOfKitchens {  get; set; }

        public int BuildingID {  get; set; }

        // Here We have a composition 
        public clsBuildingBL Building { get; set; }

        public clsPropertyBL()
        {
            PropertyId = 0;
            PropertyName = "Unnamed Property";
            PropertyType = enType.Monthly;
            NumberOfFloors = 1;
            NumberOfRooms = 2;
            Area = 100;
            RentPrice = 1000;
            AvailableFrom = DateTime.Now;
            IsOccupied = false;
            Status = "Available";
            NumberOfKitchens = 1;
            BuildingID = 0;
            Building = null;
            Mode = enMode.AddNew;
            
        }

        public clsPropertyBL(int propertyId, string propertyName, enType propertyType,
            int numberOfFloors, int numberOfRooms, int area, int rentPrice, DateTime availableFrom,
            bool isOccupied, string status, int numberOfKitchens, int buildingID)
        {
            PropertyId = propertyId;
            PropertyName = propertyName;
            PropertyType = propertyType;
            NumberOfFloors = numberOfFloors;
            NumberOfRooms = numberOfRooms;
            Area = area;
            RentPrice = rentPrice;
            AvailableFrom = availableFrom;
            IsOccupied = isOccupied;
            Status = status;
            NumberOfKitchens = numberOfKitchens;
            BuildingID = buildingID;
            Building = clsBuildingBL.Find(buildingID);
            Mode = enMode.Update;

        }


        // Get All properties 
        public static DataTable GetAllProperties(int buildingId)
        {
            return clsPropertyDL.GetAllProperties(buildingId);
        }

        // Add new property 
        private bool _AddNewProperty ()
        {
            this.PropertyId = clsPropertyDL.AddNewProperty(this.PropertyName,(int)this.PropertyType,this.NumberOfFloors,this.NumberOfRooms,this.NumberOfBathRooms,this.Area,this.RentPrice,this.AvailableFrom,this.IsOccupied,this.Status,this.NumberOfKitchens,this.Notes,this.BuildingID);

            return this.PropertyId != -1;
        }


        // Find 


        public static async Task<clsPropertyBL> FindAsync(int propertyId)
        {
            var dto = await clsPropertyDL.FindAsync(propertyId);
            if (dto == null) return null;

            return new clsPropertyBL
            {
                PropertyId = dto.PropertyId,
                PropertyName = dto.PropertyName,
                PropertyType = (clsPropertyBL.enType)dto.PropertyType,
                NumberOfFloors = dto.NumberOfFloors,
                NumberOfRooms = dto.NumberOfRooms,
                NumberOfBathRooms = dto.NumberOfBathrooms,
                Area = dto.Area,
                RentPrice = dto.RentPrice,
                AvailableFrom = dto.AvailableFrom,
                IsOccupied = dto.IsOccupied,
                Status = dto.Status,
                NumberOfKitchens = dto.NumberOfKitchens,
                Notes = dto.Notes,
                BuildingID = dto.BuildingID
            };
        }



        // Save function 
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewProperty())
                    {
                        Mode = enMode.Update;
                        return true;
                    }break;

                case enMode.Update:
                    return false;
            }
            return false;


        }



    }
}
