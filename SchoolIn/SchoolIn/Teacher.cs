using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    public class Teacher
    {
        string _name;
        string _firstname;
        string _city;
        int _phone;
        string _teaching;
        bool _ismissing;
    
        public Teacher(string name, string firstname)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            _name = name;
            _firstname = firstname;
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

        public int Phone
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
