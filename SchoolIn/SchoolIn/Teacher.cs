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
        string _city;
        string _birthday;
        string _phone;
        string _teaching;
        bool _ismissing;
        School _school;
        Promotion _promotion;

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

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Birthday
        {
            get { return _birthday; ; }
            set {
                if (string.IsNullOrWhiteSpace(_birthday))
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _birthday = value;
                }
                }
        }

        public string Phone
        {
            get { return _phone; }
            set {
                if (string.IsNullOrWhiteSpace(_phone))
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _phone = value;
                }
                }
        }

        public string City
        {
            get { return _city; }
            set {
                if (string.IsNullOrWhiteSpace(_city))
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _city = value;
                }
                }
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
        public Promotion Assignment
        {
            get { return _promotion; }
        }
        public void AssignTo(Promotion p)
        {
            if (_promotion != p)
            {
                if (p != null && p.School != _school) throw new ArgumentException();
                if (_promotion != null) _promotion.Teacher = null;
                _promotion = p;
                if (_promotion != null) _promotion.Teacher = this;
            }
        }
    }
}
