namespace Base
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.name_school = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_change_name = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_school
            // 
            this.name_school.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_school.AutoSize = true;
            this.name_school.BackColor = System.Drawing.Color.Transparent;
            this.name_school.Font = new System.Drawing.Font("Brush Script Std", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_school.Location = new System.Drawing.Point(112, -9);
            this.name_school.Name = "name_school";
            this.name_school.Size = new System.Drawing.Size(313, 112);
            this.name_school.TabIndex = 0;
            this.name_school.Text = "School";
            this.name_school.Click += new System.EventHandler(this.name_school_Click);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_load.Location = new System.Drawing.Point(31, 31);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 36);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Load...";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(419, 34);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 32);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_name.Location = new System.Drawing.Point(145, 39);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Visible = false;
            // 
            // button_change_name
            // 
            this.button_change_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_change_name.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_name.Location = new System.Drawing.Point(251, 34);
            this.button_change_name.Name = "button_change_name";
            this.button_change_name.Size = new System.Drawing.Size(47, 27);
            this.button_change_name.TabIndex = 4;
            this.button_change_name.Text = "Ok";
            this.button_change_name.UseVisualStyleBackColor = true;
            this.button_change_name.Visible = false;
            this.button_change_name.Click += new System.EventHandler(this.button_change_name_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(307, 33);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(76, 28);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button_change_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.name_school);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(537, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_school;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_change_name;
        private System.Windows.Forms.Button cancel;
    }
}
