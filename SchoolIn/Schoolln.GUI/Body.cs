using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolln.GUI
{
    public partial class Body : UserControl
    {
        public Body()
        {
            InitializeComponent();
        }

        public MainWindow Root
        {
            get { return (MainWindow)Parent; }
        }

        private void Teachers_Page_Click(object sender, EventArgs e)
        {

        }

        private void Body_Load(object sender, EventArgs e)
        {

        }
    }
}
