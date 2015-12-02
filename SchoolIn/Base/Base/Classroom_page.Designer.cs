namespace Base
{
    partial class ClassroomPage
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Button = new System.Windows.Forms.Button();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.NbStudent_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.NbStudent_Label = new System.Windows.Forms.Label();
            this.listView_classroom = new System.Windows.Forms.ListView();
            this.ClassRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NbStudentMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(60, 241);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 28);
            this.Add_Button.TabIndex = 23;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(177, 32);
            this.Name_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(165, 22);
            this.Name_Textbox.TabIndex = 27;
            // 
            // NbStudent_Textbox
            // 
            this.NbStudent_Textbox.Location = new System.Drawing.Point(177, 94);
            this.NbStudent_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NbStudent_Textbox.Name = "NbStudent_Textbox";
            this.NbStudent_Textbox.Size = new System.Drawing.Size(165, 22);
            this.NbStudent_Textbox.TabIndex = 26;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(24, 36);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 17);
            this.Name_Label.TabIndex = 25;
            this.Name_Label.Text = "Name:";
            // 
            // NbStudent_Label
            // 
            this.NbStudent_Label.AutoSize = true;
            this.NbStudent_Label.Location = new System.Drawing.Point(24, 96);
            this.NbStudent_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NbStudent_Label.Name = "NbStudent_Label";
            this.NbStudent_Label.Size = new System.Drawing.Size(79, 17);
            this.NbStudent_Label.TabIndex = 24;
            this.NbStudent_Label.Text = "NbStudent:";
            // 
            // listView_classroom
            // 
            this.listView_classroom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassRoomName,
            this.NbStudentMax});
            this.listView_classroom.Location = new System.Drawing.Point(400, 32);
            this.listView_classroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_classroom.Name = "listView_classroom";
            this.listView_classroom.Size = new System.Drawing.Size(227, 237);
            this.listView_classroom.TabIndex = 28;
            this.listView_classroom.UseCompatibleStateImageBehavior = false;
            this.listView_classroom.View = System.Windows.Forms.View.Details;
            // 
            // ClassRoomName
            // 
            this.ClassRoomName.Text = "Name";
            this.ClassRoomName.Width = 76;
            // 
            // NbStudentMax
            // 
            this.NbStudentMax.Text = "NbStudentMax";
            this.NbStudentMax.Width = 90;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(196, 241);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(100, 26);
            this.Clear_Button.TabIndex = 29;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // ClassroomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.listView_classroom);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.NbStudent_Textbox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.NbStudent_Label);
            this.Controls.Add(this.Add_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClassroomPage";
            this.Size = new System.Drawing.Size(775, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.TextBox NbStudent_Textbox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label NbStudent_Label;
        private System.Windows.Forms.ListView listView_classroom;
        private System.Windows.Forms.ColumnHeader ClassRoomName;
        private System.Windows.Forms.ColumnHeader NbStudentMax;
        private System.Windows.Forms.Button Clear_Button;
    }
}
