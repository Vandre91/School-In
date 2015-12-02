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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NbPupil()
        {
            return _listpupil.Count();
        }
    }
}
