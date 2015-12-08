namespace Schoolln.GUI
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.body1 = new Schoolln.GUI.Body();
            this.header1 = new Schoolln.GUI.Header();
            this.SuspendLayout();
            // 
            // body1
            // 
            this.body1.Location = new System.Drawing.Point(24, 90);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(864, 278);
            this.body1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header1.Location = new System.Drawing.Point(116, 13);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(674, 71);
            this.header1.TabIndex = 0;
            this.header1.Load += new System.EventHandler(this.header1_Load);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.header1);
            this.Name = "MainWindow";
            this.Text = "School Management";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
        private Body body1;
    }
}

