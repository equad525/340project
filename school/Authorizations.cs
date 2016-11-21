using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWorkVer
{
    public class Authorizations
    {
        private string _term;
        private short _year;
        private int _crn;
        private short _sid;
        private string _authtype;

        #region Properties
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
        public short Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }
        public string AuthType
        {
            get { return _authtype; }
            set { _authtype = value; }
        }
        #endregion
    }
}
