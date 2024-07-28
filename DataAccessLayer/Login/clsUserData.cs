using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Runtime.Remoting.Messaging;
namespace DataAccessLayer.Login
{
    public class clsUserData
    {
        public static bool UserDataChecker(string UserName,string Password)
        {
            string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
            SqlConnection connection = new SqlConnection(clsDataAccsesConnectionString.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }

                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine($"ERROR {ex}");
                return false;
            }
            finally
            {
                connection.Close();
                
            }
            return false;
        }

        

    }
}
