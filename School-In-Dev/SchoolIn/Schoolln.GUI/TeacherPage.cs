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
    public partial class TeacherPage : UserControl
    {
        public TeacherPage()
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

        public MainWindow Root
        {
            get { return (MainWindow)Parent.Parent.Parent.Parent; }
        }

        private void Matiere_Label_Click(object sender, EventArgs e)
        {

        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {

        }

        void UpdateFromCurrentSchool()
        {
             foreach ( var t in Root.CurrentSchool.Teachers)
            {
                string[] row = { t.FirstName, t.Name, t.birthday, t.City, t.Phone };
                ListViewItem item = new ListViewItem(row);
                Teacher_Listview.Items.Add(item);

            }

            //  ListViewItem item = new ListViewItem();
        }
        private void Add_ListView(string firstname, string name, string birthday, string city, string phone, string matiere)
        {
            string[] row = { firstname, name, birthday, city, phone, matiere };
            ListViewItem item = new ListViewItem(row);

            Teacher myteacher = Root.CurrentSchool.AddTeacher(name, firstname);
            myteacher.Phone = phone;
            myteacher.City = city;
            myteacher.Teaching = matiere;
            myteacher.birthday = birthday;

            Teacher_Listview.Items.Add(item);
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_ListView(Firstname_Textbox.Text, Name_Textbox.Text, Age_Textbox.Text, City_Textbox.Text, PhoneNumber_Textbox.Text, Matiere_Textbox.Text);
        }
    }
}
