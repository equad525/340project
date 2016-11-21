using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWorkVer
{
    public class Courses
    {
        private string _cprefix;
        private short _cno;
        private string _ctitle;
        private short _chours;

        public Courses()
        {

        }

        public Courses(string cprefix, short cno, string ctitle, short chours)
        {
            Cprefix = cprefix;
            Cno = cno;
            Ctitle = ctitle;
            Chours = chours;
        }

        #region Properties
        public string Cprefix
        {
            get { return _cprefix; }
            set { _cprefix = value; }
        }
        public short Cno
        {
            get { return _cno; }
            set { _cno = value; }
        }
        public string Ctitle
        {
            get { return _ctitle; }
            set { _ctitle = value; }
        }
        public short Chours
        {
            get { return _chours; }
            set { _chours = value; }
        }
        #endregion
    }
}
