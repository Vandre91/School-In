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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolIn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_promotion = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Classroom_page = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Promotionlist_lbl = new System.Windows.Forms.Label();
            this.Listbox_Promotion = new System.Windows.Forms.ListBox();
            this.Teacherlist_lbl = new System.Windows.Forms.Label();
            this.Listbox_Teacher = new System.Windows.Forms.ListBox();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new Base.Header();
            this.promotion_page1 = new Base.Promotion_page();
            this.teacher_page1 = new Base.Teacher_page();
            this.students_page1 = new Base.Students_page();
            this.classroomPage1 = new Base.ClassroomPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 402);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // page_promotion
            // 
            this.page_promotion.Controls.Add(this.promotion_page1);
            this.page_promotion.Location = new System.Drawing.Point(4, 22);
            this.page_promotion.Name = "page_promotion";
            this.page_promotion.Padding = new System.Windows.Forms.Padding(3);
            this.page_promotion.Size = new System.Drawing.Size(747, 376);
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
            this.tabPage2.Size = new System.Drawing.Size(747, 376);
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
            this.tabPage1.Size = new System.Drawing.Size(747, 376);
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
            this.Classroom_page.Size = new System.Drawing.Size(747, 376);
            this.Classroom_page.TabIndex = 3;
            this.Classroom_page.Text = "Classrooms";
            this.Classroom_page.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.Promotionlist_lbl);
            this.tabPage3.Controls.Add(this.Listbox_Promotion);
            this.tabPage3.Controls.Add(this.Teacherlist_lbl);
            this.tabPage3.Controls.Add(this.Listbox_Teacher);
            this.tabPage3.Controls.Add(this.calendar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(747, 376);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Classroom Calendar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Promotionlist_lbl
            // 
            this.Promotionlist_lbl.AutoSize = true;
            this.Promotionlist_lbl.Location = new System.Drawing.Point(222, 16);
            this.Promotionlist_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Promotionlist_lbl.Name = "Promotionlist_lbl";
            this.Promotionlist_lbl.Size = new System.Drawing.Size(54, 13);
            this.Promotionlist_lbl.TabIndex = 8;
            this.Promotionlist_lbl.Text = "Promotion";
            // 
            // Listbox_Promotion
            // 
            this.Listbox_Promotion.FormattingEnabled = true;
            this.Listbox_Promotion.Location = new System.Drawing.Point(186, 31);
            this.Listbox_Promotion.Margin = new System.Windows.Forms.Padding(2);
            this.Listbox_Promotion.Name = "Listbox_Promotion";
            this.Listbox_Promotion.Size = new System.Drawing.Size(128, 95);
            this.Listbox_Promotion.TabIndex = 7;
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
            this.calendar1.Size = new System.Drawing.Size(735, 212);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            this.calendar1.ViewEnd = new System.DateTime(2015, 12, 18, 23, 59, 59, 0);
            this.calendar1.ViewStart = new System.DateTime(2015, 12, 14, 0, 0, 0, 0);
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems_1);
            this.calendar1.DragDrop += new System.Windows.Forms.DragEventHandler(this.calendar1_DragDrop);
            this.calendar1.DragOver += new System.Windows.Forms.DragEventHandler(this.calendar1_DragOver);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Classroom";
            // 
            // header1
            // 
            this.header1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header1.BackgroundImage")));
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(755, 99);
            this.header1.TabIndex = 2;
            // 
            // promotion_page1
            // 
            this.promotion_page1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("promotion_page1.BackgroundImage")));
            this.promotion_page1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.promotion_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotion_page1.Location = new System.Drawing.Point(3, 3);
            this.promotion_page1.Margin = new System.Windows.Forms.Padding(4);
            this.promotion_page1.Name = "promotion_page1";
            this.promotion_page1.Size = new System.Drawing.Size(741, 370);
            this.promotion_page1.TabIndex = 0;
            // 
            // teacher_page1
            // 
            this.teacher_page1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teacher_page1.BackgroundImage")));
            this.teacher_page1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teacher_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_page1.Location = new System.Drawing.Point(3, 3);
            this.teacher_page1.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_page1.Name = "teacher_page1";
            this.teacher_page1.Size = new System.Drawing.Size(741, 370);
            this.teacher_page1.TabIndex = 0;
            // 
            // students_page1
            // 
            this.students_page1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("students_page1.BackgroundImage")));
            this.students_page1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.students_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.students_page1.Location = new System.Drawing.Point(3, 3);
            this.students_page1.Margin = new System.Windows.Forms.Padding(4);
            this.students_page1.Name = "students_page1";
            this.students_page1.Size = new System.Drawing.Size(741, 370);
            this.students_page1.TabIndex = 0;
            // 
            // classroomPage1
            // 
            this.classroomPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("classroomPage1.BackgroundImage")));
            this.classroomPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classroomPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classroomPage1.Location = new System.Drawing.Point(3, 3);
            this.classroomPage1.Margin = new System.Windows.Forms.Padding(4);
            this.classroomPage1.Name = "classroomPage1";
            this.classroomPage1.Size = new System.Drawing.Size(741, 370);
            this.classroomPage1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(747, 376);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Promotion Calendar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(747, 376);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Teacher Calendar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SchoolIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.tabControl1);
            this.Name = "SchoolIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label Promotionlist_lbl;
        private System.Windows.Forms.ListBox Listbox_Promotion;
        private System.Windows.Forms.Label Teacherlist_lbl;
        private Header header1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

