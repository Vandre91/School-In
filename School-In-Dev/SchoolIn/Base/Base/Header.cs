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

namespace Base
{
    public partial class Header : UserControl
    {
        string _currentFileName;
        public Header()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.IsInDesignMode())
            {
                Root.CurrentSchoolChanged += Root_CurrentSchoolChanged;
                UpdateFromCurrentSchool();
            }
        }

        private void Root_CurrentSchoolChanged(object sender, EventArgs e)
        {
            UpdateFromCurrentSchool();
        }

        public Main Root
        {
            get { return (Main)Parent; }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (_currentFileName == null)
            {
                using (var d = new SaveFileDialog())
                {
                    d.OverwritePrompt = true;
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        _currentFileName = d.FileName;
                    }
                    else return;
                }
            }
            Root.CurrentSchool.Save(_currentFileName);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            using (var d = new OpenFileDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    Root.CurrentSchool = School.Load(d.FileName);     
                }
            }
        }
        void UpdateFromCurrentSchool()
        {
            name_school.Text = Root.CurrentSchool.Name;
        }
        private void name_school_Click(object sender, EventArgs e)
        {
            textBox_name.Visible = true;
            button_change_name.Visible = true;
            cancel.Visible = true;
            name_school.Visible = false;

        }

        private void button_change_name_Click(object sender, EventArgs e)
        {
            Root.CurrentSchool.Name = textBox_name.Text;
            UpdateFromCurrentSchool();

            textBox_name.Visible = false;
            button_change_name.Visible = false;
            cancel.Visible = false;
            name_school.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            textBox_name.Visible = false;
            button_change_name.Visible = false;
            cancel.Visible = false;
            name_school.Visible = true;
        }
    }
}
