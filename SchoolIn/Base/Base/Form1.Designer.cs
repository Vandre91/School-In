namespace Base
{
    partial class SchoolIn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_promotion = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Classroom_page = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Classrooms_lbl = new System.Windows.Forms.Label();
            this.Listbox_Classrooms = new System.Windows.Forms.ListBox();
            this.Refresh_Listbox_Promotion = new System.Windows.Forms.Button();
            this.Promotionlist_lbl = new System.Windows.Forms.Label();
            this.Listbox_Promotion = new System.Windows.Forms.ListBox();
            this.Teacherlist_lbl = new System.Windows.Forms.Label();
            this.Listbox_Teacher = new System.Windows.Forms.ListBox();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.header1 = new Base.Header();
            this.promotion_page1 = new Base.Promotion_page();
            this.teacher_page1 = new Base.Teacher_page();
            this.students_page1 = new Base.Students_page();
            this.classroomPage1 = new Base.ClassroomPage();
            this.tabControl1.SuspendLayout();
            this.page_promotion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Classroom_page.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // page_promotion
            // 
            this.page_promotion.Controls.Add(this.promotion_page1);
            this.page_promotion.Location = new System.Drawing.Point(4, 22);
            this.page_promotion.Name = "page_promotion";
            this.page_promotion.Padding = new System.Windows.Forms.Padding(3);
            this.page_promotion.Size = new System.Drawing.Size(723, 392);
            this.page_promotion.TabIndex = 0;
            this.page_promotion.Text = "Promotion";
            this.page_promotion.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teacher_page1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teachers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.students_page1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 392);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Classroom_page
            // 
            this.Classroom_page.Controls.Add(this.classroomPage1);
            this.Classroom_page.Location = new System.Drawing.Point(4, 22);
            this.Classroom_page.Name = "Classroom_page";
            this.Classroom_page.Padding = new System.Windows.Forms.Padding(3);
            this.Classroom_page.Size = new System.Drawing.Size(723, 392);
            this.Classroom_page.TabIndex = 3;
            this.Classroom_page.Text = "Classrooms";
            this.Classroom_page.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Classrooms_lbl);
            this.tabPage3.Controls.Add(this.Listbox_Classrooms);
            this.tabPage3.Controls.Add(this.Refresh_Listbox_Promotion);
            this.tabPage3.Controls.Add(this.Promotionlist_lbl);
            this.tabPage3.Controls.Add(this.Listbox_Promotion);
            this.tabPage3.Controls.Add(this.Teacherlist_lbl);
            this.tabPage3.Controls.Add(this.Listbox_Teacher);
            this.tabPage3.Controls.Add(this.calendar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 392);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Calendar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Classrooms_lbl
            // 
            this.Classrooms_lbl.AutoSize = true;
            this.Classrooms_lbl.Location = new System.Drawing.Point(247, 16);
            this.Classrooms_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Classrooms_lbl.Name = "Classrooms_lbl";
            this.Classrooms_lbl.Size = new System.Drawing.Size(63, 13);
            this.Classrooms_lbl.TabIndex = 11;
            this.Classrooms_lbl.Text = "Classrooms ";
            // 
            // Listbox_Classrooms
            // 
            this.Listbox_Classrooms.FormattingEnabled = true;
            this.Listbox_Classrooms.Location = new System.Drawing.Point(226, 31);
            this.Listbox_Classrooms.Margin = new System.Windows.Forms.Padding(2);
            this.Listbox_Classrooms.Name = "Listbox_Classrooms";
            this.Listbox_Classrooms.Size = new System.Drawing.Size(128, 95);
            this.Listbox_Classrooms.TabIndex = 10;
            this.Listbox_Classrooms.DragDrop += new System.Windows.Forms.DragEventHandler(this.Listbox_Classrooms_DragDrop);
            this.Listbox_Classrooms.DragEnter += new System.Windows.Forms.DragEventHandler(this.Listbox_Classrooms_DragEnter);
            this.Listbox_Classrooms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Listbox_Classrooms_MouseDown);
            // 
            // Refresh_Listbox_Promotion
            // 
            this.Refresh_Listbox_Promotion.Location = new System.Drawing.Point(617, 104);
            this.Refresh_Listbox_Promotion.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_Listbox_Promotion.Name = "Refresh_Listbox_Promotion";
            this.Refresh_Listbox_Promotion.Size = new System.Drawing.Size(89, 22);
            this.Refresh_Listbox_Promotion.TabIndex = 9;
            this.Refresh_Listbox_Promotion.Text = "Refresh";
            this.Refresh_Listbox_Promotion.UseVisualStyleBackColor = true;
            this.Refresh_Listbox_Promotion.Click += new System.EventHandler(this.Refresh_Listbox_Promotion_Click);
            // 
            // Promotionlist_lbl
            // 
            this.Promotionlist_lbl.AutoSize = true;
            this.Promotionlist_lbl.Location = new System.Drawing.Point(458, 16);
            this.Promotionlist_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Promotionlist_lbl.Name = "Promotionlist_lbl";
            this.Promotionlist_lbl.Size = new System.Drawing.Size(54, 13);
            this.Promotionlist_lbl.TabIndex = 8;
            this.Promotionlist_lbl.Text = "Promotion";
            // 
            // Listbox_Promotion
            // 
            this.Listbox_Promotion.FormattingEnabled = true;
            this.Listbox_Promotion.Location = new System.Drawing.Point(425, 31);
            this.Listbox_Promotion.Margin = new System.Windows.Forms.Padding(2);
            this.Listbox_Promotion.Name = "Listbox_Promotion";
            this.Listbox_Promotion.Size = new System.Drawing.Size(128, 95);
            this.Listbox_Promotion.TabIndex = 7;
            this.Listbox_Promotion.DragDrop += new System.Windows.Forms.DragEventHandler(this.Listbox_Promotion_DragDrop);
            this.Listbox_Promotion.DragEnter += new System.Windows.Forms.DragEventHandler(this.Listbox_Promotion_DragEnter);
            this.Listbox_Promotion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Listbox_Promotion_MouseDown);
            // 
            // Teacherlist_lbl
            // 
            this.Teacherlist_lbl.AutoSize = true;
            this.Teacherlist_lbl.Location = new System.Drawing.Point(73, 16);
            this.Teacherlist_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Teacherlist_lbl.Name = "Teacherlist_lbl";
            this.Teacherlist_lbl.Size = new System.Drawing.Size(47, 13);
            this.Teacherlist_lbl.TabIndex = 5;
            this.Teacherlist_lbl.Text = "Teacher";
            // 
            // Listbox_Teacher
            // 
            this.Listbox_Teacher.FormattingEnabled = true;
            this.Listbox_Teacher.Location = new System.Drawing.Point(39, 31);
            this.Listbox_Teacher.Name = "Listbox_Teacher";
            this.Listbox_Teacher.Size = new System.Drawing.Size(127, 95);
            this.Listbox_Teacher.TabIndex = 1;
            this.Listbox_Teacher.SelectedIndexChanged += new System.EventHandler(this.Listbox_Teacher_SelectedIndexChanged);
            this.Listbox_Teacher.DragEnter += new System.Windows.Forms.DragEventHandler(this.Listbox_Teacher_DragEnter);
            this.Listbox_Teacher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Listbox_Teacher_MouseDown);
            // 
            // calendar1
            // 
            this.calendar1.AllowDrop = true;
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.calendar1.Location = new System.Drawing.Point(6, 158);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(711, 228);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            this.calendar1.ViewEnd = new System.DateTime(2015, 16, 11, 23, 59, 59, 0);
            this.calendar1.ViewStart = new System.DateTime(2015, 12, 4, 0, 0, 0, 0);
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems_1);
            this.calendar1.DragDrop += new System.Windows.Forms.DragEventHandler(this.calendar1_DragDrop);
            this.calendar1.DragOver += new System.Windows.Forms.DragEventHandler(this.calendar1_DragOver);
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(755, 83);
            this.header1.TabIndex = 2;
            // 
            // promotion_page1
            // 
            this.promotion_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotion_page1.Location = new System.Drawing.Point(3, 3);
            this.promotion_page1.Margin = new System.Windows.Forms.Padding(4);
            this.promotion_page1.Name = "promotion_page1";
            this.promotion_page1.Size = new System.Drawing.Size(717, 386);
            this.promotion_page1.TabIndex = 0;
            // 
            // teacher_page1
            // 
            this.teacher_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_page1.Location = new System.Drawing.Point(3, 3);
            this.teacher_page1.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_page1.Name = "teacher_page1";
            this.teacher_page1.Size = new System.Drawing.Size(717, 386);
            this.teacher_page1.TabIndex = 0;
            // 
            // students_page1
            // 
            this.students_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.students_page1.Location = new System.Drawing.Point(3, 3);
            this.students_page1.Margin = new System.Windows.Forms.Padding(4);
            this.students_page1.Name = "students_page1";
            this.students_page1.Size = new System.Drawing.Size(717, 386);
            this.students_page1.TabIndex = 0;
            // 
            // classroomPage1
            // 
            this.classroomPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classroomPage1.Location = new System.Drawing.Point(3, 3);
            this.classroomPage1.Margin = new System.Windows.Forms.Padding(4);
            this.classroomPage1.Name = "classroomPage1";
            this.classroomPage1.Size = new System.Drawing.Size(717, 386);
            this.classroomPage1.TabIndex = 0;
            // 
            // SchoolIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.tabControl1);
            this.Name = "SchoolIn";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.page_promotion.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Classroom_page.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_promotion;
        private System.Windows.Forms.TabPage tabPage2;
        private Promotion_page promotion_page1;
        private Teacher_page teacher_page1;
        private System.Windows.Forms.TabPage tabPage1;
        private Students_page students_page1;
        private System.Windows.Forms.TabPage Classroom_page;
        private ClassroomPage classroomPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.ListBox Listbox_Teacher;
        private System.Windows.Forms.Button Refresh_Listbox_Promotion;
        private System.Windows.Forms.Label Promotionlist_lbl;
        private System.Windows.Forms.ListBox Listbox_Promotion;
        private System.Windows.Forms.Label Teacherlist_lbl;
        private System.Windows.Forms.Label Classrooms_lbl;
        private System.Windows.Forms.ListBox Listbox_Classrooms;
        private Header header1;
    }
}

