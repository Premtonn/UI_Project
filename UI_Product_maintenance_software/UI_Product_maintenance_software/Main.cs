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
    public partial class Main : Form
    {
        public static Main instance;
        public ListView Mainlist;
        public Main()
        {
            InitializeComponent();
            instance = this;
            Mainlist = Itemlistview;
        }               

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Itemlist_view_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void Save_productlist_Click(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Add f2 = new Add();
            f2.ShowDialog();
        }

        private void Changeprice_button_Click(object sender, EventArgs e)
        {
            Price f3 = new Price();
            f3.ShowDialog();
        }

        private void Available_button_Click(object sender, EventArgs e)
        {
            if (Itemlistview.SelectedItems[0].SubItems[2].Text == "Yes")
            {
                Itemlistview.SelectedItems[0].SubItems[2].Text = "No";
            }
            else
                Itemlistview.SelectedItems[0].SubItems[2].Text = "Yes";                
        }
    }
}