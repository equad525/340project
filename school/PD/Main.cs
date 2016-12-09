using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using static Data.DataAccess;

namespace CourseProject.PD
{
    public class Main
    {
        public static string TryLogin(string password, string username)
        {
            string trylogin = DataAccess.TryLogin(password,username);
            return trylogin;
        }

        internal static List<Students> Retrieve(string userName)
        {
            List<Students> students = Retrieve<Students>(
                new List<Condition>()
                {
                    new Condition("sid", Condition.Operators.Equal, userName)
                }
            );
            return students;
        }
    }
}
