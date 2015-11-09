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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 andrian = new Form2();
            andrian.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Marceline = new Form5();
            Marceline.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 kaboss = new Form6();
            kaboss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 tanania = new Form7();
            tanania.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 nk = new Form8();
            nk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            
            this.Hide();
            Form9 baba = new Form9();
            baba.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La School a été bien créé");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
