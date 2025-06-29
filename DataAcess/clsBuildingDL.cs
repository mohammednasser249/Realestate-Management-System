using System;
using System.Collections.Generic;
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


        

    }
}
