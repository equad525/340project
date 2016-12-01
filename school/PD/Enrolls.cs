using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWorkVer
{
    public class Enrolls
    {
        private short _sid;
        private string _term;
        private short _year;
        private int _crn;
        private string _grade;

        public Enrolls()
        {

        }

        public Enrolls(short sid, string term, short year, int crn, string grade)
        {
            Sid = sid;
            Term = term;
            Year = year;
            Crn = crn;
            Grade = grade;
        }

        #region Properties
        public short Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }
        public string Term
        {
            get { return _term; }
            set { _term = value; }
        }
        public short Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Crn
        {
            get { return _crn; }
            set { _crn = value; }
        }
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        #endregion
    }

}
