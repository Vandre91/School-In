using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITISchool
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pupil pp = new Pupil();
            pp.Firstname = txtFirstname.Text;
            pp.Name = txtName.Text;
            pp.Department = txtDepartment.Text;
            pp.Email = txtEmail.Text;
            pp.Phone = txtPhone.Text;

            ListViewItem newlist = new ListViewItem(pp.Firstname);
            newlist.SubItems.Add(pp.Name);
            newlist.SubItems.Add(pp.Department);
            newlist.SubItems.Add(pp.Email);
            newlist.SubItems.Add(pp.Phone);
            listViewinfo.Items.Add(newlist);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = TextBox(sender);
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.Text = "Firstname";
            }
            TextBox cc = TextBox(sender);

            else if (cc.Text == "Firstname")
            {
                cc.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox ss = TextBox(sender);
            if (string.IsNullOrEmpty(ss.Text))
            {
                ss.Text = "Name";
            }
            TextBox gg = TextBox(sender);
            else if (gg.Text == "Name")
            {
                ss.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tt = TextBox(sender);
            if (string.IsNullOrEmpty(tt.Text))
            {
                tt.Text = "Department";
            }
            TextBox yy = TextBox(sender);
            else if (tt.Text == "Department")
            {
                yy.Text = "Department";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox xx = TextBox(sender);
            if (string.IsNullOrEmpty(xx.Text))
            {
                xx.Text = "Email";
            }
            TextBox xx = TextBox(sender);
            else if (xx.Text == "Email")
            {
                xx.Text = "Email";
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox jj = TextBox(sender);
            if(string.IsNullOrEmpty(jj.text))
            {
                jj.Text = "Phone";
            }
            TextBox jj = TextBox(sender);
            else if(jj.Text == "Phone")
            {
                jj.Text = "Phone";
            }
        }
    }
}