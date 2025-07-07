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
    public class clsPropertyDL
    {

        public static DataTable GetAllProperties()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = "SELECT * FROM Properties";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
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

        public static int AddNewProperty(string propertyName, int propertyType, int numberOfFloors,
         int numberOfRooms, int numberOfBathrooms, int areaSqFt, int rentPrice,
         DateTime availableFrom, bool isOccupied, string status, int numberOfKitchens,
         string notes, int buildingID)
        {
            int newID = -1;

            using (SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection))
            {
                string query = @"INSERT INTO Properties
            (PropertyName, PropertyType, NumberOfFloors, NumberOfRooms, NumberOfBathrooms, AreaSqFt,
             RentPrice, AvailableFrom, IsOccupied, Status, NumberOfKitchens, Notes, BuidlingID)
            VALUES
            (@PropertyName, @PropertyType, @NumberOfFloors, @NumberOfRooms, @NumberOfBathrooms, @AreaSqFt,
             @RentPrice, @AvailableFrom, @IsOccupied, @Status, @NumberOfKitchens, @Notes, @BuidlingID);

            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Assign values to SQL parameters
                cmd.Parameters.AddWithValue("@PropertyName", propertyName);
                cmd.Parameters.AddWithValue("@PropertyType", propertyType);
                cmd.Parameters.AddWithValue("@NumberOfFloors", numberOfFloors);
                cmd.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                cmd.Parameters.AddWithValue("@NumberOfBathrooms", numberOfBathrooms);
                cmd.Parameters.AddWithValue("@AreaSqFt", areaSqFt);
                cmd.Parameters.AddWithValue("@RentPrice", rentPrice);
                cmd.Parameters.AddWithValue("@AvailableFrom", availableFrom);
                cmd.Parameters.AddWithValue("@IsOccupied", isOccupied);
                cmd.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NumberOfKitchens", numberOfKitchens);
                cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@BuidlingID", buildingID);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        newID = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while inserting property: " + ex.Message);
                }
            }

            return newID;
        }

    }
}
