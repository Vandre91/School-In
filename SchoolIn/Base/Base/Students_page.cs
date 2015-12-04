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
    public partial class Students_page : UserControl
    {
        public Students_page()
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
            Pupil_Listview.Items.Clear();
            foreach (var t in Root.CurrentSchool.Pupil)
            {
                string[] row = { t.FirstName, t.Name,t.Age, t.City, t.Phone };
                ListViewItem item = new ListViewItem(row);
                Pupil_Listview.Items.Add(item);

            }
        }
        private void Add_ListView(string firstname, string name, string age, string city, string phone)
        {
            string[] row = { firstname, name, age, city, phone };
            ListViewItem item = new ListViewItem(row);

            Pupil mypupil = Root.CurrentSchool.AddPupil(name, firstname);
            mypupil.Phone = phone;
            mypupil.City = city;
            mypupil.Age = age;

            Pupil_Listview.Items.Add(item);
        }
        private void Update_Student()
        {
            Pupil_Listview.SelectedItems[0].SubItems[0].Text = Firstname_Textbox.Text;
            Pupil_Listview.SelectedItems[0].SubItems[1].Text = Name_Textbox.Text;
            Pupil_Listview.SelectedItems[0].SubItems[2].Text = Age_Textbox.Text;
            Pupil_Listview.SelectedItems[0].SubItems[3].Text = City_Textbox.Text;
            Pupil_Listview.SelectedItems[0].SubItems[4].Text = PhoneNumber_Textbox.Text;

            Firstname_Textbox.Text = " ";
            Name_Textbox.Text = " ";
            Age_Textbox.Text = " ";
            City_Textbox.Text = " ";
            PhoneNumber_Textbox.Text = " ";

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Add_ListView(Firstname_Textbox.Text, Name_Textbox.Text, Age_Textbox.Text, City_Textbox.Text, PhoneNumber_Textbox.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    MessageBox.Show("The field you want to add already exists");
                }
                else if (ex is NullReferenceException)
                {
                    MessageBox.Show("Please fill the text");
                }
            }
            Firstname_Textbox.Text = "";
            Name_Textbox.Text = "";
            Age_Textbox.Text = "";
            City_Textbox.Text = "";
            PhoneNumber_Textbox.Text = "";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Pupil_Listview.Items.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update_Student();
        }

        private void Pupil_Listview_MouseClick(object sender, MouseEventArgs e)
        {
            Firstname_Textbox.Text = Pupil_Listview.SelectedItems[0].SubItems[0].Text;
            Name_Textbox.Text = Pupil_Listview.SelectedItems[0].SubItems[1].Text;
            Age_Textbox.Text = Pupil_Listview.SelectedItems[0].SubItems[2].Text;
            City_Textbox.Text = Pupil_Listview.SelectedItems[0].SubItems[3].Text;
            PhoneNumber_Textbox.Text = Pupil_Listview.SelectedItems[0].SubItems[4].Text;
        }
    }
}
