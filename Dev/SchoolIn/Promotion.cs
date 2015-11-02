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

        public Promotion(string name)
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

        public int NbStudent
        {
            get { return _nbstudent; }
            set { _nbstudent = value; }
        }
    }
}
