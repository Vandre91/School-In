using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEcole
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir quitter?","Fermeture", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.No)
            {

                this.Hide();
                Form9 marcel = new Form9();
                marcel.Show();
            }
           
            else if (DialogResult ==  DialogResult.Yes)
                 {
                this.Hide();
                Form3 kabanga = new Form3();
                kabanga.Show();
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
