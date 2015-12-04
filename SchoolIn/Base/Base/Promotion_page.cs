using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolIn;

namespace Base
{
    public partial class Promotion_page : UserControl
    {
        public Promotion_page()
        {
            InitializeComponent();
        }
        public Main Root
        {
            get { return (Main)FindForm(); }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.IsInDesignMode())
            {
                Root.CurrentSchoolChanged += Root_CurrentSchoolChanged;
                UpdateFromCurrentSchool();
            }
        }

        private void Root_CurrentSchoolChanged(object sender, EventArgs e)
        {
            UpdateFromCurrentSchool();
        }
        void UpdateFromCurrentSchool()
        {
            listView_promotion.Items.Clear();
            foreach (var t in Root.CurrentSchool.Promotion)
            {
                string[] row = { t.Name };
                ListViewItem item = new ListViewItem(row);
                listView_promotion.Items.Add(item);
            }  
        }
        private void Add(string name)
        {
            string[] list = { name };
            ListViewItem item = new ListViewItem(list);
            Promotion mypromotion = Root.CurrentSchool.AddPromotion(name);
            listView_promotion.Items.Add(item);
        }
        private void Update_promotion()
        {
            listView_promotion.SelectedItems[0].SubItems[0].Text = textBox_name_promotion.Text;

            textBox_name_promotion.Text = "";
        }

        private void button_add_promotion_Click(object sender, EventArgs e)
        {
            try
            {
                Add(textBox_name_promotion.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    MessageBox.Show("The field you want to add already exists");
                }
                else if(ex is NullReferenceException)
                {
                    MessageBox.Show("Please fill the text");
                }
            }
            textBox_name_promotion.Text = "";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            listView_promotion.Items.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update_promotion();
        }

        private void listView_promotion_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_name_promotion.Text = listView_promotion.SelectedItems[0].Text;
        }

    }
}
