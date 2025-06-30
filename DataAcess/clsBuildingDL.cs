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
    public class clsBuildingDL
    {

        public static int AddNewBuilding(string buildingname,string address,string city ,int numberoffloors,int numberofproperties , int createdbyuser)
        {
            int BuildingId = -1;
            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string query = @"
            INSERT INTO Buildings (BuildingName,Address,City,NumberOfFloors,NumberOfProperties,CreatedByUser)
            Values(@buildingname,@address,@city,@numberoffloors,@numberofproperties,@createdbyuser) SELECT scope_identity()";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@buildingname", buildingname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@numberoffloors", numberoffloors);
            cmd.Parameters.AddWithValue("@numberofproperties", numberofproperties);
            cmd.Parameters.AddWithValue("@createdbyuser", createdbyuser);



            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    BuildingId = id;
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            conn.Close(); }
        
            return BuildingId;
        }


        public static bool GetBuildingInfoByID(int buildingid , ref string buildingname, ref string address, ref string city, ref int numberoffloors, ref int numberofproperties, ref int createdbyuser)
        {

            bool IsFound = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"select *
                        from Buildings
                        where BuildingID=@buildingid";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@buildingid", buildingid);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    buildingname = (string)reader["BuildingName"];
                    address = (string)reader["Address"];
                    city = (string)reader["City"];
                    numberoffloors = (int)reader["NumberOfFloors"];
                    numberofproperties = (int)reader["NumberOfProperties"];
                    createdbyuser = (int)reader["CreatedByUser"];
                    IsFound= true;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            conn.Close(); 
            }
            return IsFound;
        
        }




        public static DataTable GetAllBuildings()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string query = "SELECT * FROM Buildings";

            SqlCommand cmd = new SqlCommand(@query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
               
                    dt.Load(reader);
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            conn.Close(); }
        
        return dt;
        }

        

    }
}
