using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolIn;

namespace Schoolln.GUI
{
    public partial class Header : UserControl
    {

        string _currentFileName;
        public Header()
        {
            InitializeComponent();
        }

        public MainWindow Root
        {
            get { return (MainWindow)Parent; }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (_currentFileName == null)
            {
                using (var d = new SaveFileDialog())
                {
                    d.DefaultExt = "school";
                    d.OverwritePrompt = true;
                    d.Filter = "School Management (*.school)|*.school";
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        _currentFileName = d.FileName;
                    }
                    else return;
                }

                Root.CurrentSchool.Save(_currentFileName);
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            using (var d = new OpenFileDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    Root.CurrentSchool = School.Load(d.FileName);
                }
            }
        }

        private void School_Name_Click(object sender, EventArgs e)
        {

        }

        private void Header_Load(object sender, EventArgs e)
        {

        }
    }
}
