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
             // = Root.CurrentSchool.Classrooms;
            
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
