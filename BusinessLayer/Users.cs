using DataAccessLayer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Users
    {
        public static bool isLoginSuccessfully(string UserName,string Password)
        {
            if(clsUserData.UserDataChecker(UserName, Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
