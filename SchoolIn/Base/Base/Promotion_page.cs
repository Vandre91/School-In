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

        private void button_add_promotion_Click(object sender, EventArgs e)
        {
     
            Add(textBox_name_promotion.Text);

            textBox_name_promotion.Text = "";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            listView_promotion.Items.Clear();
        }
    }
}
