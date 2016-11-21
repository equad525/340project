using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private short _id;
        private short _password;
        private string _firstname;
        private string _lastname;
        private string _type;
        private string _major;
        private bool _isGradAssistant;
        private bool _inState;

        public Student() { }

        public Student(short id, short password, string firstname, string lastname,
            string type, string major, bool isGradAssistant, bool inState)
        {
            ID = id;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Type = type;
            Major = major;
            IsGradAssistant = isGradAssistant;
            InState = inState;
        }

        #region Properties
        public short ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public short Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }

        public bool IsGradAssistant
        {
            get { return _isGradAssistant; }
            set { _isGradAssistant = value; }
        }

        public bool InState
        {
            get { return _inState; }
            set { _inState = value; }
        }
        #endregion
    }
}
