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
            this.Controller_Page = new System.Windows.Forms.TabControl();
            this.Teachers_Page = new System.Windows.Forms.TabPage();
            this.Classrooms_Page = new System.Windows.Forms.TabPage();
            this.teacherPage1 = new Schoolln.GUI.TeacherPage();
            this.Controller_Page.SuspendLayout();
            this.Teachers_Page.SuspendLayout();
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
            // 
            // Body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Controller_Page);
            this.Name = "Body";
            this.Size = new System.Drawing.Size(884, 401);
            this.Load += new System.EventHandler(this.Body_Load);
            this.Controller_Page.ResumeLayout(false);
            this.Teachers_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Controller_Page;
        private System.Windows.Forms.TabPage Teachers_Page;
        private System.Windows.Forms.TabPage Classrooms_Page;
        private TeacherPage teacherPage1;
    }
}
