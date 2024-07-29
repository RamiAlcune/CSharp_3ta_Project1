using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataList
{
    public class EmployeeData
    {
        public static bool DeleteEmployeeByID(int ID)
        {
            int rowEffected = 0;
            string query = @"DELETE FROM EmployeeData WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(clsDataAccsesConnectionString.ConnectionString);
            SqlCommand cmd = new SqlCommand(query,connection);
            try
            {
                connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
                if (rowEffected > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                    }
            finally
            {
                connection.Close();

            }
            return false;


        }
        public static bool GetEmployeeDataByID(int ID,ref string FullName,ref int Age,ref string Salary,ref string Gender)
        {
            SqlConnection connection = new SqlConnection(clsDataAccsesConnectionString.ConnectionString);
            string query = @"SELECT FirstName+ ' ' + SecondName+ ' ' + ThirdName + ' ' + LastName as 'FullName',Age,Salary,CASE
            WHEN EmployeeData.Gendor = 0 THEN 'MALE'
ELSE 'FEMALE' END AS Gender
 From EmployeeData WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FullName = reader["FullName"].ToString();
                    Age = reader["Age"] != DBNull.Value ? (int)reader["Age"] : 0;
                    Salary = reader["Salary"] != DBNull.Value ? reader["Salary"].ToString() : null;
                    Gender = reader["Gender"] != DBNull.Value ? reader["Gender"].ToString() : null;
                    return true;
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            finally
            {

            connection.Close(); 
            }
            return false;


        }


    }
}
