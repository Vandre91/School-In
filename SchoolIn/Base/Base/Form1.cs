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
using System.Windows.Forms.Calendar;

namespace Base
{

    public partial class SchoolIn : Form
    {
        School _currentSchool;
        

        public SchoolIn()
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

        private void calendar1_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {

        }

        private void Listbox_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void calendar1_LoadItems_1(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {

        }

        private void Listbox_Teacher_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("t");
            builder.Append(Listbox_Teacher.Text);

            Listbox_Teacher.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Listbox_Promotion_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("p");
            builder.Append(Listbox_Promotion.Text);

            Listbox_Promotion.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Listbox_Teacher_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void calendar1_DragDrop(object sender, DragEventArgs e)
        {
            string data = e.Data.GetData(DataFormats.Text).ToString();
            char type = data[0];

            StringBuilder builder = new StringBuilder(data);
            builder.Remove(0, 1);

            calendar1.Text = builder.ToString();

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));
            Course c = _currentSchool.AddCourse(Guid.NewGuid().ToString());

            if (type == 't')
            {
                Teacher t = _currentSchool.FindTeacher(calendar1.Text);
                c.AddTeacher(t);
            }
            else
            {
                Promotion p = _currentSchool.FindPromotion(calendar1.Text);
                c.AddPromotion(p);
            }

            CalendarItem calItem = calendar1.ItemAt(Point);

            if (calItem == null)
            {
                ICalendarSelectableElement element = calendar1.HitTest(Point);

                c.Start = element.Date;
                c.End = element.Date.AddHours(1);

                CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(1), calendar1.Text);
                calendar1.Items.Add(cal);
            }
            else
            {
                string initial_content = calItem.Text;
                string additionnal_content = calendar1.Text;

                calItem.Text = initial_content + '\n' + additionnal_content;
                calendar1.Items.Add(calItem);
            }
        }

        private void calendar1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Listbox_Promotion_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Listbox_Promotion.Items.Clear();
            Listbox_Teacher.Items.Clear();

            foreach (var p in CurrentSchool.Promotion)
            {
                Listbox_Promotion.Items.Add(p.Name);
            }
            foreach (var t in CurrentSchool.Teacher)
            {
                Listbox_Teacher.Items.Add(t.FirstName + " " + t.Name);
            }
            comboBox1.Items.Clear();

            foreach (var p in CurrentSchool.Classroom)
            {
                comboBox1.Items.Add(p.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
