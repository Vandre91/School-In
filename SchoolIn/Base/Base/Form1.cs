﻿using System;
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

    public partial class Main : Form
    {
        School _currentSchool;
        

        public Main()
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

        private void Refresh_Listbox_Teacher_Click(object sender, EventArgs e)
        {

            Listbox_Teacher.Items.Clear();
            foreach (var t in CurrentSchool.Teacher)
            {
                Listbox_Teacher.Items.Add(t.FirstName + " " + t.Name);
            }
        }

        private void calendar1_LoadItems_1(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {

        }

        private void Listbox_Teacher_MouseDown(object sender, MouseEventArgs e)
        {
            Listbox_Teacher.DoDragDrop(Listbox_Teacher.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
           calendar1.Text = e.Data.GetData(DataFormats.Text).ToString();

            // CalendarItem test1 = calendar1.ItemAt(calendar1.Bounds.Location);
            // CalendarItem test3 = calendar1.ItemAt(calendar1.PointToClient(Cursor.Position));

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));


           ICalendarSelectableElement element = calendar1.HitTest(Point);
           CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(2), calendar1.Text);
           calendar1.Items.Add(cal);
        }

        private void calendar1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Refresh_Listbox_Promotion_Click(object sender, EventArgs e)
        {
            Listbox_Promotion.Items.Clear();
            foreach (var p in CurrentSchool.Promotion)
            {
                Listbox_Promotion.Items.Add(p.Name);
                foreach (var y  in CurrentSchool.Pupil)
                {
                    Listbox_Student.Items.Add(y.FirstName + " " + y.Name);
                    foreach (var t in CurrentSchool.Teacher)
                    {
                        Listbox_Teacher.Items.Add(t.FirstName + " " + t.Name);
                        foreach (var z in CurrentSchool.Classroom)
                        {
                            Listbox_Classrooms.Items.Add(z.Name + " " + z.Nbpupil);
                        }
                    }
                }
            }
        }

        private void Listbox_Student_MouseDown(object sender, MouseEventArgs e)
        {
            Listbox_Student.DoDragDrop(Listbox_Student.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Listbox_Student_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Listbox_Student_DragDrop(object sender, DragEventArgs e)
        {
            calendar1.Text = e.Data.GetData(DataFormats.Text).ToString();

            // CalendarItem test1 = calendar1.ItemAt(calendar1.Bounds.Location);
            // CalendarItem test3 = calendar1.ItemAt(calendar1.PointToClient(Cursor.Position));

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));


            ICalendarSelectableElement element = calendar1.HitTest(Point);
            CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(2), calendar1.Text);
            calendar1.Items.Add(cal);
        }

        private void Listbox_Promotion_MouseDown(object sender, MouseEventArgs e)
        {
            Listbox_Promotion.DoDragDrop(Listbox_Promotion.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void Listbox_Promotion_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Listbox_Promotion_DragDrop(object sender, DragEventArgs e)
        {
            calendar1.Text = e.Data.GetData(DataFormats.Text).ToString();

            // CalendarItem test1 = calendar1.ItemAt(calendar1.Bounds.Location);
            // CalendarItem test3 = calendar1.ItemAt(calendar1.PointToClient(Cursor.Position));

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));


            ICalendarSelectableElement element = calendar1.HitTest(Point);
            CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(2), calendar1.Text);
            calendar1.Items.Add(cal);
        }

        private void Listbox_Classrooms_MouseDown(object sender, MouseEventArgs e)
        {
            Listbox_Classrooms.DoDragDrop(Listbox_Classrooms.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Listbox_Classrooms_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Listbox_Classrooms_DragDrop(object sender, DragEventArgs e)
        {
            calendar1.Text = e.Data.GetData(DataFormats.Text).ToString();

            // CalendarItem test1 = calendar1.ItemAt(calendar1.Bounds.Location);
            // CalendarItem test3 = calendar1.ItemAt(calendar1.PointToClient(Cursor.Position));

            Point Point = calendar1.PointToClient(new Point(e.X, e.Y));


            ICalendarSelectableElement element = calendar1.HitTest(Point);
            CalendarItem cal = new CalendarItem(calendar1, element.Date, element.Date.AddHours(2), calendar1.Text);
            calendar1.Items.Add(cal);
        }
    }
}
