using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolIn;

namespace Base
{

    public partial class Main : Form
    {
        School _currentSchool;
        

        public Main()
        {
            InitializeComponent();
            CurrentSchool = null;
            
        }
        public event EventHandler CurrentSchoolChanged;
        public School CurrentSchool
        {
            get { return _currentSchool; }
            set
            {
                if (value == null) value = new School("School1");
                if (_currentSchool != value)
                {
                    _currentSchool = value;
                    var h = CurrentSchoolChanged;
                    if (h != null) h(this, EventArgs.Empty);
                }
            }
        }
       
    }
}
