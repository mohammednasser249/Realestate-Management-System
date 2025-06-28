using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess;
namespace DataAcess
{
    public class clsCountryDL
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName)
        {

            bool IsFound = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"select *
from Countries
where CountryID=@ID";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close(); }

            return IsFound;

        }


        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool IsFound = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"select *
from Countries
where CountryName=@CountryName
";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["CountryID"];
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();
            }

            return IsFound;

        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = "SELECT * FROM  Countries";

            SqlCommand cmd = new SqlCommand(qurey,conn);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
            

             

        }


    }
}
