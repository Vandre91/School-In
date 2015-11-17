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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes vous sur de vouloir quitter?", "Fermeture", MessageBoxButtons.YesNo);
            {
                if (DialogResult == DialogResult.Yes)
                    this.Hide();
                Form3 kabanga = new Form3();
                kabanga.Show();


            }
        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

        }
        private void listBox1_mouseDoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
