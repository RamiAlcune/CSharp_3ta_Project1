using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.DataList
{
    public class ListData
    {
        public static DataTable GetAllEmployees()
        {
            DataTable DT = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccsesConnectionString.ConnectionString);
            string query = @"SELECT ID,FirstName+ ' ' + SecondName+ ' ' + ThirdName + ' ' + LastName as 'FullName',Age,Salary,CASE
            WHEN EmployeeData.Gendor = 0 THEN 'MALE'
ELSE 'FEMALE' END AS Gender
 From EmployeeData";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return DT;

        }


    }
}
