using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void acceuil1_Load(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
