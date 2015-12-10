using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class Classroom
    {
        string _name;
        int _maxpupil;
        School _school;
        public Classroom(string name, School school)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            _name = name;
            _school = school;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Nbpupil
        {
            get{ return _maxpupil;}
            set{ _maxpupil = value; }
        }
    }
}
