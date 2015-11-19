using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    public class Classroom
    {
        string _name;
        int _nbpupil;

        public Classroom(string name)
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
        public int Nbpupil
        {
            get { return _nbpupil; }
            set { _nbpupil = value; }
        }

    }
}
