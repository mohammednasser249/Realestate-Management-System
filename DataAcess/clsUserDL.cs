using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess;

namespace DataAcess
{
    public class clsUserDL
    {

        public static bool GetUserByUserNameAndPassword(string userName, string password,ref int userid , ref bool isactive)
        {

            bool IsFound = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"SELECT * FROM Users WHERE UserName =@userName and UserPassword=@password";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userid = (int)reader["UserID"];
                    isactive = Convert.ToBoolean(reader["IsActive"]);

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

        public static bool GetUserByUserID(int userid,ref string userName, ref string password, ref bool isactive)
        {
            bool IsFound = false;

            SqlConnection conn = new SqlConnection(clsDataBaseSettings.StringConnection);

            string qurey = @"SELECT * FROM Users WHERE UserID =@userid ";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@userid", userid);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userName = (string)reader["UserName"];
                    password = (string)reader["UserPassword"];
                    isactive = (Boolean)reader["IsActive"];
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




    }
}
