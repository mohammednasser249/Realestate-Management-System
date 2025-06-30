using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Data;

namespace DataAcess
{
    public class clsTenantDL
    {
       
        public static bool GetTenantByID(int TenantID ,ref string FirstName,ref string SecondName, ref string ThirdName, ref string LastName,ref string EmiratesID, ref DateTime EmiratesIDIssueDate, ref DateTime EmiratesIDExpDate , ref string PassportNumber, ref DateTime PassPortIssueDate,ref DateTime PassportExpDate, ref string Email, ref
        string Phone , ref int Gender , ref DateTime DateOfBirth, ref string ImagePath,ref int CountryID)
        {
           SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = "SELECT * FROM TENANT WHERE TenantID = @TenantID";

            bool IsFound = false;

            SqlCommand cmd = new SqlCommand(qurey, conn);
            cmd.Parameters.AddWithValue("@TenantID", TenantID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {

                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    EmiratesID = reader["EmiratesId"].ToString();
                    EmiratesIDIssueDate = Convert.ToDateTime(reader["EmiratesIssueDate"]);
                    EmiratesIDExpDate = Convert.ToDateTime(reader["EmiratesExpDate"]);
                    PassportNumber = reader["PassportNo"].ToString();
                    PassPortIssueDate = Convert.ToDateTime(reader["PassportIssueDate"]);
                    PassportExpDate = Convert.ToDateTime(reader["PassportExpDate"]);
                    Email = reader["Email"].ToString();
                    Phone = reader["Phone"].ToString();
                    Gender = Convert.ToInt32(reader["Gender"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";
                    CountryID = reader["CountryId"] != DBNull.Value ? Convert.ToInt32(reader["CountryId"]) : 0;

                    IsFound= true;

                }
            }catch (Exception ex) { 
            
            Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return IsFound;
        }

        public static bool UpdateTenant( int TenantID ,string FirstName, string SecondName, string ThirdName, string LastName, string EmiratesID, DateTime EmiratesIDIssueDate, DateTime EmiratesIDExpDate, string PassportNumber, DateTime PassPortIssueDate, DateTime PassportExpDate, string Email, string Phone, int Gender, DateTime DateOfBirth, string ImagePath, int CountryID)
        {

            bool IsUpdated = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @" UPDATE Tenant
                   SET FirstName =@FirstName  , SecondName =@SecondName ,ThirdName =@ThirdName , LastName =@LastName , EmiratesId =@EmiratesID , 
                   EmiratesIssueDate =@EmiratesIDIssueDate , EmiratesExpDate =@EmiratesIDExpDate , PassportNo =@PassportNumber, PassportIssueDate =@PassPortIssueDate ,
                   PassportExpDate =@PassportExpDate , Email=@Email , Phone=@Phone , Gender=@Gender, DateOfBirth=@DateOfBirth , ImagePath=@ImagePath, CountryId=@CountryID
                   WHERE TenantID=@TenantID";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@EmiratesID", EmiratesID);
            cmd.Parameters.AddWithValue("@EmiratesIDIssueDate", EmiratesIDIssueDate);
            cmd.Parameters.AddWithValue("@EmiratesIDExpDate", EmiratesIDExpDate);
            cmd.Parameters.AddWithValue("@PassportNumber", PassportNumber);
            cmd.Parameters.AddWithValue("@PassPortIssueDate", PassPortIssueDate);
            cmd.Parameters.AddWithValue("@PassportExpDate", PassportExpDate);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            cmd.Parameters.AddWithValue("@TenantID", TenantID);


            try
            {
                conn.Open();
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    IsUpdated = true;
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

            return IsUpdated;



        }

        public static bool Delete(int TenantID)
        {

            bool IsDeleted = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"DELETE FROM Tenant WHERE TenantID =@TenantID";

            SqlCommand cmd = new SqlCommand (qurey, conn);

            cmd.Parameters.AddWithValue("@TenantID", TenantID);

            try
            {
                conn.Open();

                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    IsDeleted = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close ();
            }
            return IsDeleted;
        }


        public static int AddNewTenant(string FirstName, string SecondName, string ThirdName, string LastName, string EmiratesID, DateTime EmiratesIDIssueDate, DateTime EmiratesIDExpDate, string PassportNumber, DateTime PassPortIssueDate, DateTime PassportExpDate, string Email, string Phone, int Gender, DateTime DateOfBirth, string ImagePath, int CountryID)
        {
            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string query = @"
INSERT INTO Tenant (
     FirstName, SecondName, ThirdName, LastName,
    EmiratesId, EmiratesIssueDate, EmiratesExpDate,
    PassportNo, PassportIssueDate, PassportExpDate,
    Email, Phone, Gender, DateOfBirth, ImagePath, CountryId
)
VALUES (
     @FirstName, @SecondName, @ThirdName, @LastName,
    @EmiratesId, @EmiratesIDIssueDate, @EmiratesIDExpDate,
    @PassportNumber, @PassPortIssueDate, @PassportExpDate,
    @Email, @Phone, @Gender, @DateOfBirth, @ImagePath, @CountryId) SELECT SCOPE_IDENTITY() ;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@EmiratesID", EmiratesID);
            cmd.Parameters.AddWithValue("@EmiratesIDIssueDate", EmiratesIDIssueDate);
            cmd.Parameters.AddWithValue("@EmiratesIDExpDate", EmiratesIDExpDate);
            cmd.Parameters.AddWithValue("@PassportNumber", PassportNumber);
            cmd.Parameters.AddWithValue("@PassPortIssueDate", PassPortIssueDate);
            cmd.Parameters.AddWithValue("@PassportExpDate", PassportExpDate);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);


            try
            {
                conn.Open();
                object reulst = cmd.ExecuteScalar();

                if (reulst != null && int.TryParse(reulst.ToString(), out int id))
                {
                    ID = id;
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
            return ID;
        }

        public static DataTable GetAllTenants()
        {
            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);
            DataTable table = new DataTable();

            string qurey = @"select T.TenantID,FullName =T.FirstName+' '+T.LastName+' '+T.ThirdName+' '+T.LastName, T.EmiratesId, T.Phone,T.Email,T.DateOfBirth, C.CountryName,
 Gender =
case 
	When Gender=1 then 'Male'
	Else 'Female'
End 
from Tenant T,Countries C
where T.CountryId=C.CountryID";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
             
                    table.Load(reader);
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            conn.Close(); }
        
        return table;
        
        }

    }
}
