using DataAccessLayer.DataList;
using DataAccessLayer.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class clsListData
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Salary { get; set; }
        public string Gender{ get; set;}

        public clsListData()
        {
            this.ID = -1;
            this.FullName = "";
            this.Salary = "";
            this.Gender = "";
            this.Age = -1;
            this.Gender = "";
        }
        private clsListData(int ID, string FullName, int Age, string Salary, string Gender)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.Salary = Salary;
            this.Age = Age;
            this.Gender = Gender;
        }
        public static DataTable GetAllEmployees()
        {
            DataTable DT = ListData.GetAllEmployees();
            return DT;
        }

        public static clsListData Find(int ID)
        {
            string FullName = "", Salary = "", Gender = "";
            int Age = -1;
            bool isFound = EmployeeData.GetEmployeeDataByID(ID, ref FullName, ref Age, ref Salary, ref Gender);
            if (isFound != false)
            {
                return new clsListData(ID, FullName, Age, Salary, Gender);
            }
            else
            {
                return null;
            }

        }

    }

    }
