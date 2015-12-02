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
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name_promotion
            // 
            this.textBox_name_promotion.Location = new System.Drawing.Point(84, 54);
            this.textBox_name_promotion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_name_promotion.Name = "textBox_name_promotion";
            this.textBox_name_promotion.Size = new System.Drawing.Size(132, 22);
            this.textBox_name_promotion.TabIndex = 0;
            // 
            // label_promotion
            // 
            this.label_promotion.AutoSize = true;
            this.label_promotion.Location = new System.Drawing.Point(29, 58);
            this.label_promotion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_promotion.Name = "label_promotion";
            this.label_promotion.Size = new System.Drawing.Size(45, 17);
            this.label_promotion.TabIndex = 1;
            this.label_promotion.Text = "Name";
            this.label_promotion.UseMnemonic = false;
            // 
            // button_add_promotion
            // 
            this.button_add_promotion.Location = new System.Drawing.Point(84, 318);
            this.button_add_promotion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_promotion.Name = "button_add_promotion";
            this.button_add_promotion.Size = new System.Drawing.Size(100, 28);
            this.button_add_promotion.TabIndex = 2;
            this.button_add_promotion.Text = "Add";
            this.button_add_promotion.UseVisualStyleBackColor = true;
            this.button_add_promotion.Click += new System.EventHandler(this.button_add_promotion_Click);
            // 
            // listView_promotion
            // 
            this.listView_promotion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_promotion});
            this.listView_promotion.Location = new System.Drawing.Point(313, 54);
            this.listView_promotion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_promotion.Name = "listView_promotion";
            this.listView_promotion.Size = new System.Drawing.Size(87, 238);
            this.listView_promotion.TabIndex = 3;
            this.listView_promotion.UseCompatibleStateImageBehavior = false;
            this.listView_promotion.View = System.Windows.Forms.View.Details;
            // 
            // Name_promotion
            // 
            this.Name_promotion.Text = "Name";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(205, 318);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(103, 28);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Promotion_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.listView_promotion);
            this.Controls.Add(this.button_add_promotion);
            this.Controls.Add(this.label_promotion);
            this.Controls.Add(this.textBox_name_promotion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Promotion_page";
            this.Size = new System.Drawing.Size(771, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name_promotion;
        private System.Windows.Forms.Label label_promotion;
        private System.Windows.Forms.Button button_add_promotion;
        private System.Windows.Forms.ListView listView_promotion;
        private System.Windows.Forms.ColumnHeader Name_promotion;
        private System.Windows.Forms.Button Clear_Button;
    }
}
