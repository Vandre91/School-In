using SchoolIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolln.GUI
{
    public partial class MainWindow : Form
    {

        School _currentSchool;
        public MainWindow()
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
                if (value == null) value = new School("<new school>");
                if (_currentSchool != value)
                {
                    _currentSchool = value;
                    var h = CurrentSchoolChanged;
                    if (h != null) h(this, EventArgs.Empty);
                }
            }
        }

        private void header1_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
