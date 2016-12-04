using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.PD
{
    public class Main
    {
        public static string TryLogin(string password, string username)
        {
            string trylogin = DataAccess.TryLogin(password,username);
            return trylogin;
        }
    }
}
