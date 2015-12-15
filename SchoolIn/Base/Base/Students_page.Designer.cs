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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupBoxStudents_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(5, 18);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 34;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Pupil_Listview
            // 
            this.Pupil_Listview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pupil_Listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Firstname_Columnheader,
            this.Name_Columnheader,
            this.Age_Columnheader,
            this.City_Columnheader,
            this.Phonenumber_Columnheader,
            this.columnHeader1});
            this.Pupil_Listview.Location = new System.Drawing.Point(283, 12);
            this.Pupil_Listview.Name = "Pupil_Listview";
            this.Pupil_Listview.Size = new System.Drawing.Size(334, 129);
            this.Pupil_Listview.TabIndex = 33;
            this.Pupil_Listview.UseCompatibleStateImageBehavior = false;
            this.Pupil_Listview.View = System.Windows.Forms.View.Details;
            this.Pupil_Listview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pupil_Listview_MouseClick);
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
            this.PhoneNumber_Textbox.Location = new System.Drawing.Point(125, 120);
            this.PhoneNumber_Textbox.Name = "PhoneNumber_Textbox";
            this.PhoneNumber_Textbox.Size = new System.Drawing.Size(125, 20);
            this.PhoneNumber_Textbox.TabIndex = 32;
            this.PhoneNumber_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumber_Textbox_KeyDown);
            // 
            // City_Textbox
            // 
            this.City_Textbox.Location = new System.Drawing.Point(125, 93);
            this.City_Textbox.Name = "City_Textbox";
            this.City_Textbox.Size = new System.Drawing.Size(125, 20);
            this.City_Textbox.TabIndex = 31;
            // 
            // Age_Textbox
            // 
            this.Age_Textbox.Location = new System.Drawing.Point(125, 66);
            this.Age_Textbox.Name = "Age_Textbox";
            this.Age_Textbox.Size = new System.Drawing.Size(125, 20);
            this.Age_Textbox.TabIndex = 30;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(125, 39);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(125, 20);
            this.Name_Textbox.TabIndex = 29;
            // 
            // Firstname_Textbox
            // 
            this.Firstname_Textbox.Location = new System.Drawing.Point(125, 12);
            this.Firstname_Textbox.Name = "Firstname_Textbox";
            this.Firstname_Textbox.Size = new System.Drawing.Size(125, 20);
            this.Firstname_Textbox.TabIndex = 28;
            // 
            // PhoneNumber_Label
            // 
            this.PhoneNumber_Label.AutoSize = true;
            this.PhoneNumber_Label.Location = new System.Drawing.Point(10, 127);
            this.PhoneNumber_Label.Name = "PhoneNumber_Label";
            this.PhoneNumber_Label.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber_Label.TabIndex = 27;
            this.PhoneNumber_Label.Text = "PhoneNumber:";
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Location = new System.Drawing.Point(12, 100);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(27, 13);
            this.City_Label.TabIndex = 26;
            this.City_Label.Text = "City:";
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(12, 73);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(29, 13);
            this.Age_Label.TabIndex = 25;
            this.Age_Label.Text = "Age:";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(10, 46);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Name_Label.TabIndex = 24;
            this.Name_Label.Text = "Name:";
            // 
            // Firstname_Label
            // 
            this.Firstname_Label.AutoSize = true;
            this.Firstname_Label.Location = new System.Drawing.Point(10, 19);
            this.Firstname_Label.Name = "Firstname_Label";
            this.Firstname_Label.Size = new System.Drawing.Size(55, 13);
            this.Firstname_Label.TabIndex = 23;
            this.Firstname_Label.Text = "Firstname:";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(169, 18);
            this.Clear_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(77, 23);
            this.Clear_Button.TabIndex = 35;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(85, 18);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(80, 23);
            this.UpdateButton.TabIndex = 36;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GroupBoxStudents_page
            // 
            this.GroupBoxStudents_page.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupBoxStudents_page.Controls.Add(this.DeleteButton);
            this.GroupBoxStudents_page.Controls.Add(this.Add_Button);
            this.GroupBoxStudents_page.Controls.Add(this.UpdateButton);
            this.GroupBoxStudents_page.Controls.Add(this.Clear_Button);
            this.GroupBoxStudents_page.Location = new System.Drawing.Point(14, 160);
            this.GroupBoxStudents_page.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxStudents_page.Name = "GroupBoxStudents_page";
            this.GroupBoxStudents_page.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxStudents_page.Size = new System.Drawing.Size(349, 59);
            this.GroupBoxStudents_page.TabIndex = 37;
            this.GroupBoxStudents_page.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(251, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Promotion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // Students_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
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
            this.Name = "Students_page";
            this.Size = new System.Drawing.Size(650, 247);
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
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
