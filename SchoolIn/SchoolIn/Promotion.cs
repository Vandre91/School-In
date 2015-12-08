using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class Promotion
    {
        string _name;
        Dictionary<string, Pupil> _listpupil;
        School _school;
        Teacher _currentTeacher;
        Pupil _currentPupil;

        public Promotion(string name, School school)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
            _name = name;
            _school = school;
            _listpupil = new Dictionary<string, Pupil>();
        }
        public School School { get { return _school; } }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NbPupil()
        {
            return _listpupil.Count();
        }
        public Teacher Teacher
        {
            get { return _currentTeacher; }
            internal set { _currentTeacher = value; }
        }
        public Pupil Pupil
        {
            get { return _currentPupil; }
            internal set { _currentPupil = value; }
        }
    }
}
