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
    public partial class Teacher_page : UserControl
    {
        public Teacher_page()
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
            foreach (var t in Root.CurrentSchool.Teacher)
            {
                string[] row = { t.FirstName, t.Name, t.Birthday, t.City, t.Phone };
                ListViewItem item = new ListViewItem(row);
                Teacher_Listview.Items.Add(item);

            }
        }
        private void Add_ListView(string firstname, string name, string birthday, string city, string phone)
        {
            string[] row = { firstname, name, birthday, city, phone };
            ListViewItem item = new ListViewItem(row);

            Teacher myteacher = Root.CurrentSchool.AddTeacher(name, firstname);
            myteacher.Phone = phone;
            myteacher.City = city;
            myteacher.Birthday = birthday;

            Teacher_Listview.Items.Add(item);
        }
        private void Update()
        {
            Teacher_Listview.SelectedItems[0].SubItems[0].Text = Firstname_Textbox.Text;
            Teacher_Listview.SelectedItems[0].SubItems[1].Text = Name_Textbox.Text;
            Teacher_Listview.SelectedItems[0].SubItems[2].Text = Age_Textbox.Text;
            Teacher_Listview.SelectedItems[0].SubItems[3].Text = City_Textbox.Text;
            Teacher_Listview.SelectedItems[0].SubItems[4].Text = PhoneNumber_Textbox.Text;

            Firstname_Textbox.Text = " ";
            Name_Textbox.Text = " ";
            Age_Textbox.Text = " ";
            City_Textbox.Text = " ";
            PhoneNumber_Textbox.Text = " ";


        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_ListView(Firstname_Textbox.Text, Name_Textbox.Text, Age_Textbox.Text, City_Textbox.Text, PhoneNumber_Textbox.Text);

            Firstname_Textbox.Text = "";
            Name_Textbox.Text = "";
            Age_Textbox.Text = "";
            City_Textbox.Text = "";
            PhoneNumber_Textbox.Text = "";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Teacher_Listview.Items.Clear();
        }

        private void GroupBoxTeache_page_Enter(object sender, EventArgs e)
        {

        }

        private void Teacher_page_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update();
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            ListViewItem item = Teacher_Listview.SelectedItems[i];
            string firstname = item.SubItems[0].Text;
            string name = item.SubItems[1].Text;
            string age = item.SubItems[2].Text;
            string city = item.SubItems[3].Text;
            string phone = item.SubItems[4].Text;

            Firstname_Textbox.Text = firstname.ToString();
            Name_Textbox.Text = name.ToString();
            Age_Textbox.Text = age.ToString();
            City_Textbox.Text = city.ToString();
            PhoneNumber_Textbox.Text = phone.ToString();




        }
    }
}
