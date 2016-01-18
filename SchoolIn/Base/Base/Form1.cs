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

        //Calendar Classroom

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

        private void Listbox_Promotion_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void calendar1_DragDrop(object sender, DragEventArgs e)
        {
            calendar1.ClearItems();

            string data = e.Data.GetData(DataFormats.Text).ToString();
            char type = data[0];

            StringBuilder builder = new StringBuilder(data);
            builder.Remove(0, 1);

            calendar1.Text = builder.ToString();

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));

            Course c = _currentSchool.AddCourse(Guid.NewGuid().ToString());
            c.X = e.X;
            c.Y = e.Y;

            Classroom myclass = CurrentSchool.FindClassroom(comboBox_Classroom.Text);
            c.AddClassroom(myclass);


            if (type == 't')
            {
                Teacher t = _currentSchool.FindTeacher(calendar1.Text);
                c.AddTeacher(t);
            }

            if (type == 'p')
            {
                Promotion p = _currentSchool.FindPromotion(calendar1.Text);
                c.AddPromotion(p);
            }

            foreach (var mycourse in _currentSchool.Course.Where((Course datCourse) =>
            { return datCourse.AllClassroom.Any((Classroom datClassroom) => { return datClassroom.Name == comboBox_Classroom.Text; }); }))
            {
                Point position = calendar1.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar1.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(1), allpromo + allteacher);
                calendar1.Items.Add(cal);
            }
        }

        private void calendar1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void comboBox_Classroom_SelectedValueChanged(object sender, EventArgs e)
        {
            calendar1.ClearItems();

            foreach (var mycourse in _currentSchool.Course.Where((Course datCourse) =>
            { return datCourse.AllClassroom.Any((Classroom datClassroom) => { return datClassroom.Name == comboBox_Classroom.Text; }); }))
            {
                Point position = calendar1.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar1.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(1), allpromo + allteacher);
                calendar1.Items.Add(cal);
            }
        }

        // Canlendar Promotion
        private void listBox_Teacher2_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("t");
            builder.Append(listBox_Teacher2.Text);

            listBox_Teacher2.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox_Classroom_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("c");
            builder.Append(listBox_Classroom.Text);

            listBox_Classroom.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox_Teacher2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_Classroom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void calendar2_DragDrop(object sender, DragEventArgs e)
        {
            calendar2.ClearItems();

            string data = e.Data.GetData(DataFormats.Text).ToString();
            char type = data[0];

            StringBuilder builder = new StringBuilder(data);
            builder.Remove(0, 1);

            calendar2.Text = builder.ToString();

            Point Point = calendar2.PointToClient(new Point(e.X, e.Y));

            CoursePromotion cpromo = _currentSchool.AddCoursePromotion(Guid.NewGuid().ToString());
            cpromo.X = e.X;
            cpromo.Y = e.Y;

            Promotion mypromo = CurrentSchool.FindPromotion(comboBox_promotion.Text);
            cpromo.AddPromotion(mypromo);


            if (type == 't')
            {
                Teacher t = _currentSchool.FindTeacher(calendar2.Text);
                cpromo.AddTeacher(t);
            }

            if (type == 'c')
            {
                Classroom classroom = _currentSchool.FindClassroom(calendar2.Text);
                cpromo.AddClassroom(classroom);
            }

            foreach (var mycourse in _currentSchool.CoursePromotion.Where((CoursePromotion datCourse) =>
            { return datCourse.AllPromotion.Any((Promotion datClassroom) => { return datClassroom.Name == comboBox_promotion.Text; }); }))
            {
                Point position = calendar2.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar2.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar2, element.Date, element.Date.AddHours(1), allclassroom + allteacher);
                calendar2.Items.Add(cal);
            }
        }

        private void calendar2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void comboBox_promotion_MouseClick(object sender, MouseEventArgs e)
        {

            Listbox_Promotion.Items.Clear();
            comboBox_promotion.Items.Clear();
            listBox_Promotion2.Items.Clear();

            Listbox_Teacher.Items.Clear();
            listBox_Teacher2.Items.Clear();
            comboBox_teacher.Items.Clear();

            listBox_Classroom.Items.Clear();
            comboBox_Classroom.Items.Clear();
            listBox_Classroom2.Items.Clear();

            foreach (var p in CurrentSchool.Promotion)
            {
                Listbox_Promotion.Items.Add(p.Name);
                comboBox_promotion.Items.Add(p.Name);
                listBox_Promotion2.Items.Add(p.Name);
            }
            foreach (var t in CurrentSchool.Teacher)
            {
                Listbox_Teacher.Items.Add(t.Name);
                listBox_Teacher2.Items.Add(t.Name);
                comboBox_teacher.Items.Add(t.Name);
            }
            foreach (var c in CurrentSchool.Classroom)
            {
                comboBox_Classroom.Items.Add(c.Name);
                listBox_Classroom.Items.Add(c.Name);
                listBox_Classroom2.Items.Add(c.Name);
            }
        }

        private void comboBox_promotion_SelectedValueChanged(object sender, EventArgs e)
        {
            calendar2.ClearItems();

            foreach (var mycourse in _currentSchool.CoursePromotion.Where((CoursePromotion datCourse) =>
            { return datCourse.AllPromotion.Any((Promotion datClassroom) => { return datClassroom.Name == comboBox_promotion.Text; }); }))
            {
                Point position = calendar2.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar2.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar2, element.Date, element.Date.AddHours(1), allclassroom + allteacher);
                calendar2.Items.Add(cal);
            }
        }

        //Calendar Teacher

        private void listBox_Classroom2_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("c");
            builder.Append(listBox_Classroom2.Text);

            listBox_Classroom2.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox_Promotion2_MouseDown(object sender, MouseEventArgs e)
        {
            StringBuilder builder = new StringBuilder("p");
            builder.Append(listBox_Promotion2.Text);

            listBox_Promotion2.DoDragDrop(builder.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox_Classroom2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_Promotion2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void calendar3_DragDrop(object sender, DragEventArgs e)
        {
            calendar3.ClearItems();

            string data = e.Data.GetData(DataFormats.Text).ToString();
            char type = data[0];

            StringBuilder builder = new StringBuilder(data);
            builder.Remove(0, 1);

            calendar3.Text = builder.ToString();

            Point Point = calendar3.PointToClient(new Point(e.X, e.Y));

            CourseTeacher cteacher = _currentSchool.AddCourseTeacher(Guid.NewGuid().ToString());
            cteacher.X = e.X;
            cteacher.Y = e.Y;

            Teacher myteacher = CurrentSchool.FindTeacher(comboBox_teacher.Text);
            cteacher.AddTeacher(myteacher);


            if (type == 'c')
            {
                Classroom c = _currentSchool.FindClassroom(calendar3.Text);
                cteacher.AddClassroom(c);
            }

            if (type == 'p')
            {
                Promotion p = _currentSchool.FindPromotion(calendar3.Text);
                cteacher.AddPromotion(p);
            }

            foreach (var mycourse in _currentSchool.CourseTeacher.Where((CourseTeacher datCourse) =>
            { return datCourse.AllTeacher.Any((Teacher datClassroom) => { return datClassroom.Name == comboBox_teacher.Text; }); }))
            {
                Point position = calendar3.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar3.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar3, element.Date, element.Date.AddHours(1), allclassroom + allpromo);
                calendar3.Items.Add(cal);
            }
        }

        private void comboBox_teacher_SelectedValueChanged(object sender, EventArgs e)
        {
            calendar3.ClearItems();

            foreach (var mycourse in _currentSchool.CourseTeacher.Where((CourseTeacher datCourse) =>
            { return datCourse.AllTeacher.Any((Teacher datClassroom) => { return datClassroom.Name == comboBox_teacher.Text; }); }))
            {
                Point position = calendar3.PointToClient(new Point(mycourse.X, mycourse.Y));
                ICalendarSelectableElement element = calendar3.HitTest(position);

                string allpromo = "";
                string allteacher = "";
                string allclassroom = "";

                foreach (var promo in mycourse.AllPromotion)
                {
                    allpromo += promo.Name;
                }

                foreach (var teacher in mycourse.AllTeacher)
                {
                    allteacher += teacher.Name;
                }

                foreach (var classroom in mycourse.AllClassroom)
                {
                    allclassroom += classroom.Name;
                }

                CalendarItem cal = new CalendarItem(calendar3, element.Date, element.Date.AddHours(1), allpromo + allclassroom);
                calendar3.Items.Add(cal);
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
         {
            Listbox_Promotion.Items.Clear();
            comboBox_promotion.Items.Clear();
            listBox_Promotion2.Items.Clear();

            Listbox_Teacher.Items.Clear();
            listBox_Teacher2.Items.Clear();
            comboBox_teacher.Items.Clear();

            listBox_Classroom.Items.Clear();
            comboBox_Classroom.Items.Clear();
            listBox_Classroom2.Items.Clear();

            foreach (var p in CurrentSchool.Promotion)
            {
                Listbox_Promotion.Items.Add(p.Name);
                comboBox_promotion.Items.Add(p.Name);
                listBox_Promotion2.Items.Add(p.Name);
            }
            foreach (var t in CurrentSchool.Teacher)
            {
                Listbox_Teacher.Items.Add(t.Name);
                listBox_Teacher2.Items.Add(t.Name);
                comboBox_teacher.Items.Add(t.Name);
            }
            foreach (var c in CurrentSchool.Classroom)
            {
                comboBox_Classroom.Items.Add(c.Name);
                listBox_Classroom.Items.Add(c.Name);
                listBox_Classroom2.Items.Add(c.Name);
            }
        }
        private void calendar3_DragOver_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            //this.calendar1.ViewEnd = new System.DateTime(2016, 1,21, 23, 59, 59, 0);
            ////int day = this.calendar1.Days.Date.Day;
            int t = this.calendar1.ViewEnd.Day;
            t++;
            this.calendar1.ViewEnd = new System.DateTime(2016, 1, t, 23, 59, 59, 0);


        }

        private void buttonCourt_Click(object sender, EventArgs e)
        {
            int t = this.calendar1.ViewStart.Day;
            t--;
            this.calendar1.ViewStart = new System.DateTime(2016, 1, t, 0, 0, 0, 0);
        }

        private void buttonCourt1_Click(object sender, EventArgs e)
        {
            int t = this.calendar2.ViewStart.Day;
            t--;
            this.calendar2.ViewStart = new System.DateTime(2016, 1, t, 0, 0, 0, 0);
        }

        private void buttonMore1_Click(object sender, EventArgs e)
        {
            int t = this.calendar2.ViewEnd.Day;
            t++;
            this.calendar2.ViewEnd = new System.DateTime(2016, 1, t, 23, 59, 59, 0);
        }

        private void buttonCourt2_Click(object sender, EventArgs e)
        {
            int t = this.calendar3.ViewStart.Day;
            t--;
            this.calendar3.ViewStart = new System.DateTime(2016, 1, t, 0, 0, 0, 0);
        }

        private void buttonMore2_Click(object sender, EventArgs e)
        {
            int t = this.calendar3.ViewEnd.Day;
            t++;
            this.calendar3.ViewEnd = new System.DateTime(2016, 1, t, 23, 59, 59, 0);
        }
    }
}
