﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    class Teacher
    {
        string _name;
        public Teacher(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            _name = name;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
