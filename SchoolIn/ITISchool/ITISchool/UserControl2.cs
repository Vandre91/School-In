using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolin
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        // Ajout dans la listview
        private void add(string Firstname, string Name, string Department, string Email, string Phone)
        {
            string[] row = { Firstname, Name, Department, Email, Phone };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }
        // Mettre à jour
        private void  update()
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtFirstname.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtDepartment.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtEmail.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtPhone.Text;

            // Vider listbox
            txtFirstname.Text = "";
            txtName.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
        // Supprimer
        private void delete()
        {
            
            if (MessageBox.Show("Are you Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.None);
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                // Vider listbox
                txtFirstname.Text = "";
                txtName.Text = "";
                txtDepartment.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            add(txtFirstname.Text, txtName.Text, txtDepartment.Text, txtEmail.Text, txtPhone.Text);

            txtFirstname.Text = "";
            txtName.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            update();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirstname.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtDepartment.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtEmail.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;

            // Vider listbox
            txtFirstname.Text = "";
            txtName.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
