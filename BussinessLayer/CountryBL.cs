using DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsCountryBL
    {

        public int ID {  get; set; }
        public string CountryName { get; set; }
        public clsCountryBL()
        {
            ID = -1;
            CountryName= string.Empty;
        }
        private clsCountryBL(int id,string name)
        {
            ID = id;
            CountryName = name;
        } // Private so can not create an object 

        public static clsCountryBL Find(int id)
        {

            string Name ="";
            if(clsCountryDL.GetCountryInfoByID(id, ref Name))
            {
                return new clsCountryBL(id,Name);
            }
            return null;


        }
        public static clsCountryBL Find(string Name)
        {

            int id = 0;
            if (clsCountryDL.GetCountryInfoByName(Name,ref id))
            {
                return new clsCountryBL(id, Name);
            }
            return null;


        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDL.GetAllCountries();  
        }

    }
}
