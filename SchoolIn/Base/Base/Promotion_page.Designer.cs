namespace Base
{
    partial class Promotion_page
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
            this.textBox_name_promotion = new System.Windows.Forms.TextBox();
            this.label_promotion = new System.Windows.Forms.Label();
            this.listView_promotion = new System.Windows.Forms.ListView();
            this.Name_promotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_add_promotion = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_Student = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name_promotion
            // 
            this.textBox_name_promotion.Location = new System.Drawing.Point(63, 44);
            this.textBox_name_promotion.Name = "textBox_name_promotion";
            this.textBox_name_promotion.Size = new System.Drawing.Size(100, 20);
            this.textBox_name_promotion.TabIndex = 0;
            this.textBox_name_promotion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_name_promotion_KeyDown);
            // 
            // label_promotion
            // 
            this.label_promotion.AutoSize = true;
            this.label_promotion.Location = new System.Drawing.Point(22, 47);
            this.label_promotion.Name = "label_promotion";
            this.label_promotion.Size = new System.Drawing.Size(35, 13);
            this.label_promotion.TabIndex = 1;
            this.label_promotion.Text = "Name";
            this.label_promotion.UseMnemonic = false;
            // 
            // listView_promotion
            // 
            this.listView_promotion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_promotion});
            this.listView_promotion.Location = new System.Drawing.Point(25, 88);
            this.listView_promotion.Name = "listView_promotion";
            this.listView_promotion.Size = new System.Drawing.Size(138, 119);
            this.listView_promotion.TabIndex = 3;
            this.listView_promotion.UseCompatibleStateImageBehavior = false;
            this.listView_promotion.View = System.Windows.Forms.View.Details;
            this.listView_promotion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_promotion_MouseClick);
            // 
            // Name_promotion
            // 
            this.Name_promotion.Text = "Name";
            // 
            // button_add_promotion
            // 
            this.button_add_promotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add_promotion.Location = new System.Drawing.Point(12, 18);
            this.button_add_promotion.Name = "button_add_promotion";
            this.button_add_promotion.Size = new System.Drawing.Size(75, 23);
            this.button_add_promotion.TabIndex = 2;
            this.button_add_promotion.Text = "Add";
            this.button_add_promotion.UseVisualStyleBackColor = true;
            this.button_add_promotion.Click += new System.EventHandler(this.button_add_promotion_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(108, 18);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(77, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(206, 19);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.button_add_promotion);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // listView_Student
            // 
            this.listView_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Student.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Student.Location = new System.Drawing.Point(384, 44);
            this.listView_Student.Name = "listView_Student";
            this.listView_Student.Size = new System.Drawing.Size(152, 237);
            this.listView_Student.TabIndex = 8;
            this.listView_Student.UseCompatibleStateImageBehavior = false;
            this.listView_Student.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Firstname";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 76;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Promotion";
            // 
            // Promotion_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView_Student);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_promotion);
            this.Controls.Add(this.label_promotion);
            this.Controls.Add(this.textBox_name_promotion);
            this.Name = "Promotion_page";
            this.Size = new System.Drawing.Size(578, 312);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name_promotion;
        private System.Windows.Forms.Label label_promotion;
        private System.Windows.Forms.ListView listView_promotion;
        private System.Windows.Forms.ColumnHeader Name_promotion;
        private System.Windows.Forms.Button button_add_promotion;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_Student;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
