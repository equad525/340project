using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Students
    {
        private short? _id;
        private int? _password;
        private string _firstname;
        private string _lastname;
        private string _type;
        private string _major;
        private string _isGradAssistant;
        private string _inState;

        public Students() { }

        public Students(short id, int password, string firstname, string lastname,
            string type, string major, string isGradAssistant, string inState)
        {
            Sid = id;
            Password = password;
            Fname = firstname;
            Lname = lastname;
            SType = type;
            Major = major;
            GradAssistant = isGradAssistant;
            InState = inState;
        }

        #region Properties
        public short? Sid
        {
            get { return _id; }
            set { _id = value; }
        }

        public int? Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Fname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string SType
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }

        public string GradAssistant
        {
            get { return _isGradAssistant; }
            set { _isGradAssistant = value; }
        }

        public string InState
        {
            get { return _inState; }
            set { _inState = value; }
        }
        #endregion
    }
}
