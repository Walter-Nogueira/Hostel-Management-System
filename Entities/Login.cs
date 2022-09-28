using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Entities
{
    internal static class Login
    {
        private static string _id = "ADMIN";
        private static string _password = "ADMIN";

        public static bool UserCheck(string id, string password)
        {
            if (id != _id && password != _password)
            {
                return false;
            }
            else if (id != _id && password == _password)
            {
                return false;
            }
            else if (id == _id && password != _password)
            {
                return false;
            }
            else
                return true;
        }



    }
}
