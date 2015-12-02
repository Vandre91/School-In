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
            this.button_add_promotion = new System.Windows.Forms.Button();
            this.listView_promotion = new System.Windows.Forms.ListView();
            this.Name_promotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox_name_promotion
            // 
            this.textBox_name_promotion.Location = new System.Drawing.Point(63, 44);
            this.textBox_name_promotion.Name = "textBox_name_promotion";
            this.textBox_name_promotion.Size = new System.Drawing.Size(100, 20);
            this.textBox_name_promotion.TabIndex = 0;
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
            // button_add_promotion
            // 
            this.button_add_promotion.Location = new System.Drawing.Point(63, 264);
            this.button_add_promotion.Name = "button_add_promotion";
            this.button_add_promotion.Size = new System.Drawing.Size(75, 23);
            this.button_add_promotion.TabIndex = 2;
            this.button_add_promotion.Text = "Add";
            this.button_add_promotion.UseVisualStyleBackColor = true;
            this.button_add_promotion.Click += new System.EventHandler(this.button_add_promotion_Click);
            // 
            // listView_promotion
            // 
            this.listView_promotion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_promotion});
            this.listView_promotion.Location = new System.Drawing.Point(235, 44);
            this.listView_promotion.Name = "listView_promotion";
            this.listView_promotion.Size = new System.Drawing.Size(66, 194);
            this.listView_promotion.TabIndex = 3;
            this.listView_promotion.UseCompatibleStateImageBehavior = false;
            this.listView_promotion.View = System.Windows.Forms.View.Details;
            // 
            // Name_promotion
            // 
            this.Name_promotion.Text = "Name";
            // 
            // Promotion_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_promotion);
            this.Controls.Add(this.button_add_promotion);
            this.Controls.Add(this.label_promotion);
            this.Controls.Add(this.textBox_name_promotion);
            this.Name = "Promotion_page";
            this.Size = new System.Drawing.Size(578, 312);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name_promotion;
        private System.Windows.Forms.Label label_promotion;
        private System.Windows.Forms.Button button_add_promotion;
        private System.Windows.Forms.ListView listView_promotion;
        private System.Windows.Forms.ColumnHeader Name_promotion;
    }
}
