namespace Base
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Refresh_Listbox = new System.Windows.Forms.Button();
            this.Listbox_Promotion = new System.Windows.Forms.ListBox();
            this.Listbox_Teacher = new System.Windows.Forms.ListBox();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.Classroom_page = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.page_promotion = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.promotion_page1 = new Base.Promotion_page();
            this.teacher_page1 = new Base.Teacher_page();
            this.students_page1 = new Base.Students_page();
            this.classroomPage1 = new Base.ClassroomPage();
            this.header = new Base.Header();
            this.tabPage3.SuspendLayout();
            this.Classroom_page.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.page_promotion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Refresh_Listbox);
            this.tabPage3.Controls.Add(this.Listbox_Promotion);
            this.tabPage3.Controls.Add(this.Listbox_Teacher);
            this.tabPage3.Controls.Add(this.calendar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 420);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Calendar Classroom";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Refresh_Listbox
            // 
            this.Refresh_Listbox.Location = new System.Drawing.Point(349, 25);
            this.Refresh_Listbox.Name = "Refresh_Listbox";
            this.Refresh_Listbox.Size = new System.Drawing.Size(127, 30);
            this.Refresh_Listbox.TabIndex = 4;
            this.Refresh_Listbox.Text = "Refresh";
            this.Refresh_Listbox.UseVisualStyleBackColor = true;
            this.Refresh_Listbox.Click += new System.EventHandler(this.Refresh_Listbox_Click);
            // 
            // Listbox_Promotion
            // 
            this.Listbox_Promotion.AccessibleName = "";
            this.Listbox_Promotion.FormattingEnabled = true;
            this.Listbox_Promotion.Location = new System.Drawing.Point(196, 10);
            this.Listbox_Promotion.Name = "Listbox_Promotion";
            this.Listbox_Promotion.Size = new System.Drawing.Size(127, 56);
            this.Listbox_Promotion.TabIndex = 3;
            this.Listbox_Promotion.SelectedIndexChanged += new System.EventHandler(this.Listbox_Promotion_SelectedIndexChanged);
            this.Listbox_Promotion.DragEnter += new System.Windows.Forms.DragEventHandler(this.Listbox_Promotion_DragEnter);
            this.Listbox_Promotion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Listbox_Promotion_MouseDown);
            // 
            // Listbox_Teacher
            // 
            this.Listbox_Teacher.FormattingEnabled = true;
            this.Listbox_Teacher.Location = new System.Drawing.Point(45, 10);
            this.Listbox_Teacher.Name = "Listbox_Teacher";
            this.Listbox_Teacher.Size = new System.Drawing.Size(127, 56);
            this.Listbox_Teacher.TabIndex = 1;
            this.Listbox_Teacher.SelectedIndexChanged += new System.EventHandler(this.Listbox_Teacher_SelectedIndexChanged);
            this.Listbox_Teacher.DragEnter += new System.Windows.Forms.DragEventHandler(this.Listbox_Teacher_DragEnter);
            this.Listbox_Teacher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Listbox_Teacher_MouseDown);
            // 
            // calendar1
            // 
            this.calendar1.AllowDrop = true;
            this.calendar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.calendar1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.calendar1.Location = new System.Drawing.Point(17, 72);
            this.calendar1.MaximumFullDays = 7;
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(844, 328);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            this.calendar1.ViewEnd = new System.DateTime(2015, 12, 13, 23, 59, 59, 0);
            this.calendar1.ViewStart = new System.DateTime(2015, 12, 9, 0, 0, 0, 0);
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems_1);
            this.calendar1.DragDrop += new System.Windows.Forms.DragEventHandler(this.calendar1_DragDrop);
            this.calendar1.DragOver += new System.Windows.Forms.DragEventHandler(this.calendar1_DragOver);
            // 
            // Classroom_page
            // 
            this.Classroom_page.Controls.Add(this.classroomPage1);
            this.Classroom_page.Location = new System.Drawing.Point(4, 22);
            this.Classroom_page.Name = "Classroom_page";
            this.Classroom_page.Padding = new System.Windows.Forms.Padding(3);
            this.Classroom_page.Size = new System.Drawing.Size(878, 420);
            this.Classroom_page.TabIndex = 3;
            this.Classroom_page.Text = "Classrooms";
            this.Classroom_page.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.students_page1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 420);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teacher_page1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teachers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // page_promotion
            // 
            this.page_promotion.Controls.Add(this.promotion_page1);
            this.page_promotion.Location = new System.Drawing.Point(4, 22);
            this.page_promotion.Name = "page_promotion";
            this.page_promotion.Padding = new System.Windows.Forms.Padding(3);
            this.page_promotion.Size = new System.Drawing.Size(878, 420);
            this.page_promotion.TabIndex = 0;
            this.page_promotion.Text = "Promotion";
            this.page_promotion.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.page_promotion);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Classroom_page);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // promotion_page1
            // 
            this.promotion_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotion_page1.Location = new System.Drawing.Point(3, 3);
            this.promotion_page1.Name = "promotion_page1";
            this.promotion_page1.Size = new System.Drawing.Size(872, 414);
            this.promotion_page1.TabIndex = 0;
            // 
            // teacher_page1
            // 
            this.teacher_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_page1.Location = new System.Drawing.Point(3, 3);
            this.teacher_page1.Name = "teacher_page1";
            this.teacher_page1.Size = new System.Drawing.Size(872, 414);
            this.teacher_page1.TabIndex = 0;
            // 
            // students_page1
            // 
            this.students_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.students_page1.Location = new System.Drawing.Point(3, 3);
            this.students_page1.Name = "students_page1";
            this.students_page1.Size = new System.Drawing.Size(872, 414);
            this.students_page1.TabIndex = 0;
            // 
            // classroomPage1
            // 
            this.classroomPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classroomPage1.Location = new System.Drawing.Point(3, 3);
            this.classroomPage1.Name = "classroomPage1";
            this.classroomPage1.Size = new System.Drawing.Size(872, 414);
            this.classroomPage1.TabIndex = 0;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(911, 112);
            this.header.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.header);
            this.Name = "Main";
            this.Text = "Main";
            this.tabPage3.ResumeLayout(false);
            this.Classroom_page.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.page_promotion.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Header header;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Refresh_Listbox;
        private System.Windows.Forms.ListBox Listbox_Promotion;
        private System.Windows.Forms.ListBox Listbox_Teacher;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.TabPage Classroom_page;
        private ClassroomPage classroomPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private Students_page students_page1;
        private System.Windows.Forms.TabPage tabPage2;
        private Teacher_page teacher_page1;
        private System.Windows.Forms.TabPage page_promotion;
        private Promotion_page promotion_page1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

