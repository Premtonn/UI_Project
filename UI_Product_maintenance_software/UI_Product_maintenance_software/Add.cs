using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Product_maintenance_software
{
    public partial class Add : Form
    {
        public static Add instance;
        string AvailabilityRadio;
        public Add()
        {
            InitializeComponent();
            instance = this;
        }

        private void Add_Load(object sender, EventArgs e)
        {
                         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }    

        private void Addproduct_Save_Click(object sender, EventArgs e)
        {
            string[] row = { Name_box.Text, Price_box.Text, AvailabilityRadio};
            var listItem = new ListViewItem(row);
            Main.instance.Mainlist.Items.Add(listItem);
            this.Close();
        }

        private void Addproduct_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            AvailabilityRadio = "Yes";
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            AvailabilityRadio = "No";
        }
    }
}