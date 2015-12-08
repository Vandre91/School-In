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

        //Pupil

        // Ajout dans la listview
        private void Add(string Firstname, string Name, string Birthday, string City, string Email, string Phone)
        {
            string[] row = { Firstname, Name, Birthday, City, Email, Phone };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }
        // Mettre à jour
        private void  Updatep()
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtFirstname.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtBirthday.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtDepartment.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtEmail.Text;
            listView1.SelectedItems[0].SubItems[5].Text = txtPhone.Text;

            // Vider listbox
            txtFirstname.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
        // Supprimer
        private void Delete()
        {
            
            if (MessageBox.Show("Are you Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.None);
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                // Vider listbox
                txtFirstname.Text = "";
                txtName.Text = "";
                txtBirthday.Text = "";
                txtDepartment.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Add(txtFirstname.Text, txtName.Text, txtBirthday.Text, txtDepartment.Text, txtEmail.Text, txtPhone.Text);

            txtFirstname.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
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
            panelP.Visible = true;
            panelT.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Updatep();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirstname.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtBirthday.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtDepartment.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtEmail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtPhone.Text = listView1.SelectedItems[0].SubItems[5].Text;

            // Vider listbox
            txtFirstname.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }


        // Teacher

        private void Button2_Click(object sender, EventArgs e)
        {
            panelP.Visible = false;
            panelT.Visible = true;
        }

        private void Addt_Click_teacher(object sender, EventArgs e)
        {
            AddT(textfirstname.Text, textname.Text, textcity.Text, textemail.Text, textphone.Text);

            textfirstname.Text = "";
            textname.Text = "";
            textcity.Text = "";
            textemail.Text = "";
            textphone.Text = "";
        }
        private void AddT(string Firstname, string Name, string City, string Email, string Phone)
        {
            string[] row = { Firstname, Name, City, Email, Phone };

            ListViewItem item = new ListViewItem(row);

            listView2.Items.Add(item);
        }
        private void Updatet()
        {
            listView2.SelectedItems[0].SubItems[0].Text = textfirstname.Text;
            listView2.SelectedItems[0].SubItems[1].Text = textname.Text;
            listView2.SelectedItems[0].SubItems[2].Text = textcity.Text;
            listView2.SelectedItems[0].SubItems[3].Text = textemail.Text;
            listView2.SelectedItems[0].SubItems[4].Text = textphone.Text;

            // Vider listbox
            textfirstname.Text = "";
            textname.Text = "";
            textcity.Text = "";
            textemail.Text = "";
            textphone.Text = "";
        }
        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            textfirstname.Text = listView2.SelectedItems[0].SubItems[0].Text;
            textname.Text = listView2.SelectedItems[0].SubItems[1].Text;
            textcity.Text = listView2.SelectedItems[0].SubItems[2].Text;
            textemail.Text = listView2.SelectedItems[0].SubItems[3].Text;
            textphone.Text = listView2.SelectedItems[0].SubItems[4].Text;

            // Vider listbox
            textfirstname.Text = "";
            textname.Text = "";
            textcity.Text = "";
            textemail.Text = "";
            textphone.Text = "";
        }
        private void Deletet()
        {

            if (MessageBox.Show("Are you Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.None) ;
            {
                listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
                // Vider listbox
                textfirstname.Text = "";
                textname.Text = "";
                textcity.Text = "";
                textemail.Text = "";
                textphone.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Deletet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Updatet();
        }
    }
    }
