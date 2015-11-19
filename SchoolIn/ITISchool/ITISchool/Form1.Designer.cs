namespace ITISchool
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userControl21 = new ITISchool.UserControl2();
            this.userControl11 = new ITISchool.UserControl1();
            this.planning1 = new ITISchool.Planning();
            this.ajouter1 = new ITISchool.Ajouter();
            this.creerControl1 = new ITISchool.CreerControl();
            this.acceuil1 = new ITISchool.Acceuil();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.planning1);
            this.panel1.Controls.Add(this.ajouter1);
            this.panel1.Controls.Add(this.creerControl1);
            this.panel1.Controls.Add(this.acceuil1);
            this.panel1.Location = new System.Drawing.Point(31, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 573);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(317, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 417);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(1126, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 417);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1398, 665);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(317, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(755, 113);
            this.panel5.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userControl21);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1396, 663);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(11, 26);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1355, 523);
            this.userControl21.TabIndex = 0;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl11.Location = new System.Drawing.Point(-1, 443);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(211, 102);
            this.userControl11.TabIndex = 4;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            // 
            // planning1
            // 
            this.planning1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.planning1.Location = new System.Drawing.Point(-1, 337);
            this.planning1.Name = "planning1";
            this.planning1.Size = new System.Drawing.Size(211, 100);
            this.planning1.TabIndex = 3;
            // 
            // ajouter1
            // 
            this.ajouter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ajouter1.Location = new System.Drawing.Point(0, 225);
            this.ajouter1.Name = "ajouter1";
            this.ajouter1.Size = new System.Drawing.Size(211, 106);
            this.ajouter1.TabIndex = 2;
            // 
            // creerControl1
            // 
            this.creerControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creerControl1.Location = new System.Drawing.Point(0, 122);
            this.creerControl1.Name = "creerControl1";
            this.creerControl1.Size = new System.Drawing.Size(211, 97);
            this.creerControl1.TabIndex = 1;
            // 
            // acceuil1
            // 
            this.acceuil1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acceuil1.Location = new System.Drawing.Point(-1, 12);
            this.acceuil1.Name = "acceuil1";
            this.acceuil1.Size = new System.Drawing.Size(211, 104);
            this.acceuil1.TabIndex = 0;
            this.acceuil1.Load += new System.EventHandler(this.acceuil1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 665);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Acceuil acceuil1;
        private CreerControl creerControl1;
        private Ajouter ajouter1;
        private Planning planning1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private UserControl2 userControl21;
    }
}

