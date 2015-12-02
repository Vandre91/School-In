namespace Base
{
    partial class Students_page
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
            this.Pupil_Listview = new System.Windows.Forms.ListView();
            this.Firstname_Columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age_Columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City_Columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phonenumber_Columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber_Textbox = new System.Windows.Forms.TextBox();
            this.City_Textbox = new System.Windows.Forms.TextBox();
            this.Age_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Firstname_Textbox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Firstname_Label = new System.Windows.Forms.Label();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GroupBoxStudents_page = new System.Windows.Forms.GroupBox();
            this.SelectLineButton = new System.Windows.Forms.Button();
            this.GroupBoxStudents_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(7, 22);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 28);
            this.Add_Button.TabIndex = 34;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Pupil_Listview
            // 
            this.Pupil_Listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Firstname_Columnheader,
            this.Name_Columnheader,
            this.Age_Columnheader,
            this.City_Columnheader,
            this.Phonenumber_Columnheader});
            this.Pupil_Listview.Location = new System.Drawing.Point(377, 15);
            this.Pupil_Listview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pupil_Listview.Name = "Pupil_Listview";
            this.Pupil_Listview.Size = new System.Drawing.Size(441, 158);
            this.Pupil_Listview.TabIndex = 33;
            this.Pupil_Listview.UseCompatibleStateImageBehavior = false;
            this.Pupil_Listview.View = System.Windows.Forms.View.Details;
            // 
            // Firstname_Columnheader
            // 
            this.Firstname_Columnheader.Text = "Firstname";
            // 
            // Name_Columnheader
            // 
            this.Name_Columnheader.Text = "Name";
            // 
            // Age_Columnheader
            // 
            this.Age_Columnheader.Text = "Age";
            // 
            // City_Columnheader
            // 
            this.City_Columnheader.Text = "City";
            // 
            // Phonenumber_Columnheader
            // 
            this.Phonenumber_Columnheader.Text = "PhoneNumber";
            this.Phonenumber_Columnheader.Width = 88;
            // 
            // PhoneNumber_Textbox
            // 
            this.PhoneNumber_Textbox.Location = new System.Drawing.Point(167, 148);
            this.PhoneNumber_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumber_Textbox.Name = "PhoneNumber_Textbox";
            this.PhoneNumber_Textbox.Size = new System.Drawing.Size(165, 22);
            this.PhoneNumber_Textbox.TabIndex = 32;
            // 
            // City_Textbox
            // 
            this.City_Textbox.Location = new System.Drawing.Point(167, 114);
            this.City_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.City_Textbox.Name = "City_Textbox";
            this.City_Textbox.Size = new System.Drawing.Size(165, 22);
            this.City_Textbox.TabIndex = 31;
            // 
            // Age_Textbox
            // 
            this.Age_Textbox.Location = new System.Drawing.Point(167, 81);
            this.Age_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Age_Textbox.Name = "Age_Textbox";
            this.Age_Textbox.Size = new System.Drawing.Size(165, 22);
            this.Age_Textbox.TabIndex = 30;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(167, 48);
            this.Name_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(165, 22);
            this.Name_Textbox.TabIndex = 29;
            // 
            // Firstname_Textbox
            // 
            this.Firstname_Textbox.Location = new System.Drawing.Point(167, 15);
            this.Firstname_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Firstname_Textbox.Name = "Firstname_Textbox";
            this.Firstname_Textbox.Size = new System.Drawing.Size(165, 22);
            this.Firstname_Textbox.TabIndex = 28;
            // 
            // PhoneNumber_Label
            // 
            this.PhoneNumber_Label.AutoSize = true;
            this.PhoneNumber_Label.Location = new System.Drawing.Point(13, 156);
            this.PhoneNumber_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumber_Label.Name = "PhoneNumber_Label";
            this.PhoneNumber_Label.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumber_Label.TabIndex = 27;
            this.PhoneNumber_Label.Text = "PhoneNumber:";
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Location = new System.Drawing.Point(16, 123);
            this.City_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(35, 17);
            this.City_Label.TabIndex = 26;
            this.City_Label.Text = "City:";
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(16, 90);
            this.Age_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(37, 17);
            this.Age_Label.TabIndex = 25;
            this.Age_Label.Text = "Age:";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(13, 57);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 17);
            this.Name_Label.TabIndex = 24;
            this.Name_Label.Text = "Name:";
            // 
            // Firstname_Label
            // 
            this.Firstname_Label.AutoSize = true;
            this.Firstname_Label.Location = new System.Drawing.Point(13, 23);
            this.Firstname_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Firstname_Label.Name = "Firstname_Label";
            this.Firstname_Label.Size = new System.Drawing.Size(74, 17);
            this.Firstname_Label.TabIndex = 23;
            this.Firstname_Label.Text = "Firstname:";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(382, 22);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(103, 28);
            this.Clear_Button.TabIndex = 35;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(255, 22);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 28);
            this.UpdateButton.TabIndex = 36;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GroupBoxStudents_page
            // 
            this.GroupBoxStudents_page.Controls.Add(this.SelectLineButton);
            this.GroupBoxStudents_page.Controls.Add(this.Add_Button);
            this.GroupBoxStudents_page.Controls.Add(this.UpdateButton);
            this.GroupBoxStudents_page.Controls.Add(this.Clear_Button);
            this.GroupBoxStudents_page.Location = new System.Drawing.Point(19, 197);
            this.GroupBoxStudents_page.Name = "GroupBoxStudents_page";
            this.GroupBoxStudents_page.Size = new System.Drawing.Size(512, 73);
            this.GroupBoxStudents_page.TabIndex = 37;
            this.GroupBoxStudents_page.TabStop = false;
            // 
            // SelectLineButton
            // 
            this.SelectLineButton.Location = new System.Drawing.Point(132, 22);
            this.SelectLineButton.Name = "SelectLineButton";
            this.SelectLineButton.Size = new System.Drawing.Size(100, 28);
            this.SelectLineButton.TabIndex = 37;
            this.SelectLineButton.Text = "SelectLine";
            this.SelectLineButton.UseVisualStyleBackColor = true;
            this.SelectLineButton.Click += new System.EventHandler(this.SelectLineButton_Click);
            // 
            // Students_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxStudents_page);
            this.Controls.Add(this.Pupil_Listview);
            this.Controls.Add(this.PhoneNumber_Textbox);
            this.Controls.Add(this.City_Textbox);
            this.Controls.Add(this.Age_Textbox);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.Firstname_Textbox);
            this.Controls.Add(this.PhoneNumber_Label);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Firstname_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Students_page";
            this.Size = new System.Drawing.Size(867, 304);
            this.GroupBoxStudents_page.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ListView Pupil_Listview;
        private System.Windows.Forms.ColumnHeader Firstname_Columnheader;
        private System.Windows.Forms.ColumnHeader Name_Columnheader;
        private System.Windows.Forms.ColumnHeader Age_Columnheader;
        private System.Windows.Forms.ColumnHeader City_Columnheader;
        private System.Windows.Forms.ColumnHeader Phonenumber_Columnheader;
        private System.Windows.Forms.TextBox PhoneNumber_Textbox;
        private System.Windows.Forms.TextBox City_Textbox;
        private System.Windows.Forms.TextBox Age_Textbox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.TextBox Firstname_Textbox;
        private System.Windows.Forms.Label PhoneNumber_Label;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Firstname_Label;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox GroupBoxStudents_page;
        private System.Windows.Forms.Button SelectLineButton;
    }
}
