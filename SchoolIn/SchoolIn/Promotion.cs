using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    public class Promotion
    {
        string _name;
        int _nbstudent;
        Dictionary<string, Pupil> _listpupil;

        public Promotion(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
            _name = name;
            _listpupil = new Dictionary<string, Pupil>();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NbStudent
        {
            get { return _nbstudent; }
            set { _nbstudent = value; }
        }

        public void AddPupil(string name, Pupil pupil)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            if (_listpupil.ContainsKey(name))
            {
                throw new ArgumentException();
            }
            _listpupil.Add(name,pupil);
        }
    }
}
