using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.PD
{
    public class Sections
    {
        public string Term { get; set; }
        public short Year { get; set; }
        public int Crn { get; set; }
        public string Cprefix { get; set; }
        public short Cno { get; set; }
        public short Section { get; set; }
        public string Days { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Room { get; set; }
        public short Cap { get; set; }
        public string Instructor { get; set; }
        public string Auth { get; set; }

        public Sections() { }
        public Sections(string term, short year, int crn, string cprefix, short cno, short section,
            string days, string startTime, string endTime, string room, short cap, string instructor, string auth) 
        {
            this.Term = term;
            this.Year = year;
            this.Crn = crn;
            this.Cprefix = cprefix;
            this.Cno = cno;
            this.Section = section;
            this.Days = days;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Room = room;
            this.Cap = cap;
            this.Instructor = instructor;
            this.Auth = auth;
        }

    }
}
