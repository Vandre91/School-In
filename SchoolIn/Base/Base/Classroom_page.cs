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
    public partial class ClassroomPage : UserControl
    {
        public ClassroomPage()
        {
            InitializeComponent();
        }
        public Main Root
        {
            get { return (Main)FindForm(); }
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
        void UpdateFromCurrentSchool()
        {
            foreach (var t in Root.CurrentSchool.Classroom)
            {
                
                string[] row = { t.Name, t.Nbpupil.ToString() };
                ListViewItem item = new ListViewItem(row);
                listView_classroom.Items.Add(item);

            }
        }
        private void Add_ListView( string name, string nbpupil)
        {
            string[] row = { name, nbpupil};
            ListViewItem item = new ListViewItem(row);

            Classroom myclassroom = Root.CurrentSchool.AddClassroom(name);
            int nb = Int32.Parse(nbpupil);
            myclassroom.Nbpupil = nb;


            listView_classroom.Items.Add(item);
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_ListView( Name_Textbox.Text, NbStudent_Textbox.Text);

            
            Name_Textbox.Text = "";
            NbStudent_Textbox.Text = "";

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            listView_classroom.Items.Clear();
        }

        private void ClassroomPage_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
