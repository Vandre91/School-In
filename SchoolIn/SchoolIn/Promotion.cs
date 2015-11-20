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

        public Pupil AddPupil(string name, string firstname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException();
            }

            if (_listpupil.ContainsKey(name))
            {
                throw new ArgumentException();
            }
            Pupil pupil = new Pupil(name, firstname, this);
            _listpupil.Add(name, pupil);
            return pupil;
        }

        public bool ContainsPupil(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            if (_listpupil.ContainsKey(name))
            {
                return true;
            }
            return false;
        }

        public void RemovePupil(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            if (_listpupil.ContainsKey(name))
            {
                _listpupil.Remove(name);
            }
        }
        public int NbPupil()
        {
            return _listpupil.Count();
        }
    }
}
