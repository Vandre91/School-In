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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassroomPage));
            this.Add_Button = new System.Windows.Forms.Button();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.NbStudent_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.NbStudent_Label = new System.Windows.Forms.Label();
            this.listView_classroom = new System.Windows.Forms.ListView();
            this.ClassRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NbStudentMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupeBoxClassroom_page = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GroupeBoxClassroom_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(5, 9);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 25);
            this.Add_Button.TabIndex = 23;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(133, 26);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(125, 20);
            this.Name_Textbox.TabIndex = 27;
            // 
            // NbStudent_Textbox
            // 
            this.NbStudent_Textbox.Location = new System.Drawing.Point(133, 76);
            this.NbStudent_Textbox.Name = "NbStudent_Textbox";
            this.NbStudent_Textbox.Size = new System.Drawing.Size(125, 20);
            this.NbStudent_Textbox.TabIndex = 26;
            this.NbStudent_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NbStudent_Textbox_KeyDown);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(18, 29);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Name_Label.TabIndex = 25;
            this.Name_Label.Text = "Name:";
            // 
            // NbStudent_Label
            // 
            this.NbStudent_Label.AutoSize = true;
            this.NbStudent_Label.Location = new System.Drawing.Point(18, 78);
            this.NbStudent_Label.Name = "NbStudent_Label";
            this.NbStudent_Label.Size = new System.Drawing.Size(61, 13);
            this.NbStudent_Label.TabIndex = 24;
            this.NbStudent_Label.Text = "NbStudent:";
            // 
            // listView_classroom
            // 
            this.listView_classroom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView_classroom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassRoomName,
            this.NbStudentMax});
            this.listView_classroom.Location = new System.Drawing.Point(392, 26);
            this.listView_classroom.Name = "listView_classroom";
            this.listView_classroom.Size = new System.Drawing.Size(171, 193);
            this.listView_classroom.TabIndex = 28;
            this.listView_classroom.UseCompatibleStateImageBehavior = false;
            this.listView_classroom.View = System.Windows.Forms.View.Details;
            this.listView_classroom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_classroom_MouseClick);
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
            // GroupeBoxClassroom_page
            // 
            this.GroupeBoxClassroom_page.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupeBoxClassroom_page.BackColor = System.Drawing.Color.Transparent;
            this.GroupeBoxClassroom_page.Controls.Add(this.DeleteButton);
            this.GroupeBoxClassroom_page.Controls.Add(this.UpdateButton);
            this.GroupeBoxClassroom_page.Controls.Add(this.Add_Button);
            this.GroupeBoxClassroom_page.Location = new System.Drawing.Point(21, 179);
            this.GroupeBoxClassroom_page.Margin = new System.Windows.Forms.Padding(2);
            this.GroupeBoxClassroom_page.Name = "GroupeBoxClassroom_page";
            this.GroupeBoxClassroom_page.Padding = new System.Windows.Forms.Padding(2);
            this.GroupeBoxClassroom_page.Size = new System.Drawing.Size(248, 40);
            this.GroupeBoxClassroom_page.TabIndex = 30;
            this.GroupeBoxClassroom_page.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(165, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(85, 10);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 24);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClassroomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.GroupeBoxClassroom_page);
            this.Controls.Add(this.listView_classroom);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.NbStudent_Textbox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.NbStudent_Label);
            this.Name = "ClassroomPage";
            this.Size = new System.Drawing.Size(581, 263);
            this.GroupeBoxClassroom_page.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox GroupeBoxClassroom_page;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
