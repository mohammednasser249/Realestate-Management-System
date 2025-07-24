using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataAcess
{
    public class clsPropertyDL
    {
        public class PropertyDTO
        {
            public int PropertyId { get; set; }
            public string PropertyName { get; set; }
            public int PropertyType { get; set; }
            public int NumberOfFloors { get; set; }
            public int NumberOfRooms { get; set; }
            public int NumberOfBathrooms { get; set; }
            public int Area { get; set; }
            public int RentPrice { get; set; }
            public DateTime AvailableFrom { get; set; }
            public bool IsOccupied { get; set; }
            public string Status { get; set; }
            public int NumberOfKitchens { get; set; }
            public string Notes { get; set; }
            public int BuildingID { get; set; }
        }


        public static DataTable GetAllProperties(int BuildingID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"select *
from Properties
where BuidlingID=@BuildingID ";

            SqlCommand cmd = new SqlCommand(qurey, conn);
            cmd.Parameters.AddWithValue("@BuildingID", BuildingID);

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


            public static async Task<PropertyDTO> FindAsync(int propertyId)
            {
                using (SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection))
                {
                    await conn.OpenAsync();

                    string query = "SELECT * FROM Properties WHERE PropertyId=@propertyId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@propertyId", propertyId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                var property = new PropertyDTO
                                {
                                    PropertyId = propertyId,
                                    PropertyName = reader["PropertyName"].ToString() ?? "",
                                    PropertyType = Convert.ToInt32(reader["PropertyType"]),
                                    NumberOfFloors = Convert.ToInt32(reader["NumberOfFloors"]),
                                    NumberOfRooms = Convert.ToInt32(reader["NumberOfRooms"]),
                                    NumberOfBathrooms = Convert.ToInt32(reader["NumberOfBathrooms"]),
                                    Area = Convert.ToInt32(reader["AreaSqFt"]),
                                    RentPrice = Convert.ToInt32(reader["RentPrice"]),
                                    AvailableFrom = Convert.ToDateTime(reader["AvailableFrom"]),
                                    IsOccupied = Convert.ToBoolean(reader["IsOccupied"]),
                                    Status = reader["Status"].ToString() ?? "",
                                    NumberOfKitchens = Convert.ToInt32(reader["NumberOfKitchens"]),
                                    Notes = reader["Notes"].ToString() ?? "",
                                    BuildingID = Convert.ToInt32(reader["BuidlingID"])
                                };
                                return property;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }



    }
}
