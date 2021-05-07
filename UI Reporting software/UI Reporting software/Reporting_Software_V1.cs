using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Reporting_software
{
    public partial class Form1 : Form
    {
        public List<Items> Product { get; set; }

        public Form1()
        {
            Product = GetProduct();
            InitializeComponent();

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            var product = this.Product;

            Total_sales_grid.DataSource = product;
            Top_sales_grid.DataSource = product;
        }
        
        private List<Items> GetProduct()
        {

            var list = new List<Items>();
            list.Add(new Items()
            {
                Item_name = "Item 1",
                Unit_amount = 1,
                Unit_price = 100,
                Total = 100,
            });
            
            list.Add(new Items()
            {
                Item_name = "Item 2",
                Unit_amount = 1,
                Unit_price = 75,
                Total = 75,
            });

            return list;
        }

        private void Total_sales_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Most_Items_text_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Total_sales_text_Click(object sender, EventArgs e)
        {
        }

        private void Top_sales_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Reporting Software");
            Console.ReadLine();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chooseTimelineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
