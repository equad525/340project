using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.PD
{
    public class Staff
    {
        public string Tid{get;set;}
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string StaffType { get; set; }

        public Staff() { }
        public Staff(string tid,string password, string fname, string lname, string staffType) 
        {
            this.Tid = tid;
            this.Password = password;
            this.Fname = fname;
            this.Lname = lname;
            this.StaffType = staffType;
        }
    }

    
}
