namespace Schoolln.GUI
{
    partial class Body
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.Controller_Page = new System.Windows.Forms.TabControl();
            this.Teachers_Page = new System.Windows.Forms.TabPage();
            this.Classrooms_Page = new System.Windows.Forms.TabPage();
            this.teacherPage1 = new Schoolln.GUI.TeacherPage();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.Controller_Page.SuspendLayout();
            this.Teachers_Page.SuspendLayout();
            this.Classrooms_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controller_Page
            // 
            this.Controller_Page.Controls.Add(this.Teachers_Page);
            this.Controller_Page.Controls.Add(this.Classrooms_Page);
            this.Controller_Page.Location = new System.Drawing.Point(0, 3);
            this.Controller_Page.Name = "Controller_Page";
            this.Controller_Page.SelectedIndex = 0;
            this.Controller_Page.Size = new System.Drawing.Size(862, 384);
            this.Controller_Page.TabIndex = 0;
            // 
            // Teachers_Page
            // 
            this.Teachers_Page.Controls.Add(this.teacherPage1);
            this.Teachers_Page.Location = new System.Drawing.Point(4, 22);
            this.Teachers_Page.Name = "Teachers_Page";
            this.Teachers_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Teachers_Page.Size = new System.Drawing.Size(854, 358);
            this.Teachers_Page.TabIndex = 0;
            this.Teachers_Page.Text = "Teachers";
            this.Teachers_Page.UseVisualStyleBackColor = true;
            this.Teachers_Page.Click += new System.EventHandler(this.Teachers_Page_Click);
            // 
            // Classrooms_Page
            // 
            this.Classrooms_Page.Controls.Add(this.calendar1);
            this.Classrooms_Page.Location = new System.Drawing.Point(4, 22);
            this.Classrooms_Page.Name = "Classrooms_Page";
            this.Classrooms_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Classrooms_Page.Size = new System.Drawing.Size(854, 358);
            this.Classrooms_Page.TabIndex = 1;
            this.Classrooms_Page.Text = "Classrooms";
            this.Classrooms_Page.UseVisualStyleBackColor = true;
            // 
            // teacherPage1
            // 
            this.teacherPage1.Location = new System.Drawing.Point(9, 21);
            this.teacherPage1.Name = "teacherPage1";
            this.teacherPage1.Size = new System.Drawing.Size(827, 209);
            this.teacherPage1.TabIndex = 0;
            this.teacherPage1.Load += new System.EventHandler(this.teacherPage1_Load);
            // 
            // calendar1
            // 
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(55, 29);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(629, 312);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            // 
            // Body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Controller_Page);
            this.Name = "Body";
            this.Size = new System.Drawing.Size(892, 567);
            this.Load += new System.EventHandler(this.Body_Load);
            this.Controller_Page.ResumeLayout(false);
            this.Teachers_Page.ResumeLayout(false);
            this.Classrooms_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Controller_Page;
        private System.Windows.Forms.TabPage Teachers_Page;
        private System.Windows.Forms.TabPage Classrooms_Page;
        private TeacherPage teacherPage1;
        private System.Windows.Forms.Calendar.Calendar calendar1;
    }
}
