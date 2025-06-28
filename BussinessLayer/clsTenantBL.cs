using DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsTenantBL
    {

       public enum enMode { AddNew = 0 , UpdateNew = 1 }

        public enMode Mode;
        public int TenantID {  get; set; }
        public string FirstName {  get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string EmiratesID { get; set; }
        public DateTime EmiratesIDIssueDate { get; set; }
        public DateTime EmiratesIDExpDate { get; set; }
        public string PassportNumber {  get; set; }
        public DateTime PassPortIssueDate {  get; set; }
        public DateTime PassportExpDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int Gender {  get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ImagePath {  get; set; }
        public int CountryID {  get; set; }

        // Defalut Constructor 
        public clsTenantBL()
        {
            TenantID = 0;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            EmiratesID = string.Empty;
            EmiratesIDIssueDate = DateTime.MinValue;
            EmiratesIDExpDate = DateTime.MinValue;
            PassportNumber = string.Empty;
            PassPortIssueDate = DateTime.MinValue;
            PassportExpDate = DateTime.MinValue;
            Email = string.Empty;
            Phone = string.Empty;
            Gender = 0; // 0 = Not Specified, 1 = Male, 2 = Female (you can customize)
            DateOfBirth = DateTime.MinValue;
            ImagePath = string.Empty;
            CountryID = 0;
            Mode = enMode.AddNew;
        }

        // Parametrized Constructor 
        public clsTenantBL(
    int tenantID, string firstName, string secondName, string thirdName, string lastName,
    string emiratesID, DateTime emiratesIDIssueDate, DateTime emiratesIDExpDate,
    string passportNumber, DateTime passportIssueDate, DateTime passportExpDate,
    string email, string phone, int gender, DateTime dateOfBirth,
    string imagePath, int countryID)
        {
            TenantID = tenantID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            EmiratesID = emiratesID;
            EmiratesIDIssueDate = emiratesIDIssueDate;
            EmiratesIDExpDate = emiratesIDExpDate;
            PassportNumber = passportNumber;
            PassPortIssueDate = passportIssueDate;
            PassportExpDate = passportExpDate;
            Email = email;
            Phone = phone;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ImagePath = imagePath;
            CountryID = countryID;
            Mode = enMode.UpdateNew;
        }

        // Find By ID
        public static clsTenantBL Find(int TenantID)
        {
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            string EmiratesID = string.Empty;
            DateTime EmiratesIDIssueDate = DateTime.MinValue;
            DateTime EmiratesIDExpDate = DateTime.MinValue;
            string PassportNumber = string.Empty;
            DateTime PassPortIssueDate = DateTime.MinValue;
            DateTime PassportExpDate = DateTime.MinValue;
            string Email = string.Empty;
            string Phone = string.Empty;
            int Gender = 0;
            DateTime DateOfBirth = DateTime.MinValue;
            string ImagePath = string.Empty;
            int CountryID = 0;

            bool found = clsTenantDL.GetTenantByID(
                TenantID,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref EmiratesID,
                ref EmiratesIDIssueDate,
                ref EmiratesIDExpDate,
                ref PassportNumber,
                ref PassPortIssueDate,
                ref PassportExpDate,
                ref Email,
                ref Phone,
                ref Gender,
                ref DateOfBirth,
                ref ImagePath,
                ref CountryID
            );

            if (found)
            {
                return new clsTenantBL
                {
                    TenantID = TenantID,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    ThirdName = ThirdName,
                    LastName = LastName,
                    EmiratesID = EmiratesID,
                    EmiratesIDIssueDate = EmiratesIDIssueDate,
                    EmiratesIDExpDate = EmiratesIDExpDate,
                    PassportNumber = PassportNumber,
                    PassPortIssueDate = PassPortIssueDate,
                    PassportExpDate = PassportExpDate,
                    Email = Email,
                    Phone = Phone,
                    Gender = Gender,
                    DateOfBirth = DateOfBirth,
                    ImagePath = ImagePath,
                    CountryID = CountryID
                };
            }
            else
            {
                return null;
            }
        }

        // Add New Tenant 
        private bool _AddNewTenant()
        {
            this.TenantID = clsTenantDL.AddNewTenant(this.FirstName, this.LastName,this.ThirdName,this.LastName,this.EmiratesID,this.EmiratesIDIssueDate,this.EmiratesIDExpDate,this.PassportNumber,this.PassPortIssueDate,this.PassportExpDate,this.Email,this.Phone,this.Gender,this.DateOfBirth,this.ImagePath,this.CountryID);

            return this.TenantID != -1;
        }

        // Get All Tenants 
        public static DataTable GetAllTenants()
        {
            return clsTenantDL.GetAllTenants();
        }


        // Save 
        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTenant())
                    {
                        Mode = enMode.UpdateNew;
                        return true;
                    }
                    break;
            }
            return false;
        }
            

    }
}
