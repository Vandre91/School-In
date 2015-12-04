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
            listView_classroom.Items.Clear();
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
        private void Update_Classroom()
        {
            listView_classroom.SelectedItems[0].SubItems[0].Text = Name_Textbox.Text;
            listView_classroom.SelectedItems[0].SubItems[1].Text = NbStudent_Textbox.Text;

            Name_Textbox.Text = "";
            NbStudent_Textbox.Text = "";
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Add_ListView(Name_Textbox.Text, NbStudent_Textbox.Text);
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

            Name_Textbox.Text = "";
            NbStudent_Textbox.Text = "";

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            listView_classroom.Items.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update_Classroom();
        }

        private void listView_classroom_MouseClick(object sender, MouseEventArgs e)
        {
            Name_Textbox.Text = listView_classroom.SelectedItems[0].SubItems[0].Text;
            NbStudent_Textbox.Text = listView_classroom.SelectedItems[0].SubItems[1].Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                listView_classroom.Items.RemoveAt(listView_classroom.SelectedIndices[0]);
            }

            Name_Textbox.Text = "";
            NbStudent_Textbox.Text = "";
        }
    }
}
