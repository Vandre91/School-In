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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes vous sur de vouloir quitter?", "Fermeture", MessageBoxButtons.YesNo);
            {
                if (DialogResult == DialogResult.Yes)
                {

                    this.Hide();
                    Form3 anderson = new Form3();
                    anderson.Show();
                }



                else if (DialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Form8 kabanga = new Form8();
                    kabanga.Show();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
