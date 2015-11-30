using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class Teacher
    {
        string _name;
        string _firstname;
        string _birthday;
        string _city;
        string _phone;
        string _teaching;
        bool _ismissing;
        School _school;

        public Teacher(string name, string firstname, School school)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException();
            }

            _name = name;
            _firstname = firstname;
            _school = school;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Teaching
        {
            get { return _teaching; }
            set { _teaching = value; }
        }

        public bool IsMissing
        {
            get { return _ismissing; }
            set { _ismissing = value; }
        }
    }
}
