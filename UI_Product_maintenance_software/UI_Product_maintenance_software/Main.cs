using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;


namespace UI_Product_maintenance_software
{
    
    public class ProductRow
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public bool Availability { get; set; }
        public ProductRow(string pName, float price, bool available)
        {
            ProductName = pName;
            Price = price;
            Availability = available;
        }
    }
    public partial class Main : Form
    {
       
        public string file_path { get; set; }
        public static Main instance;
        public ListView Mainlist;
        public Main()
        {
            file_path = "product.csv";
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
            
            var writer = new StreamWriter(file_path);
            var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteHeader<ProductRow>();
            csvWriter.NextRecord();
            for (int i_row=0; i_row < Itemlistview.Items.Count; i_row++)
            {
                string name = Itemlistview.Items[i_row].SubItems[0].Text;
                float price = float.Parse(Itemlistview.Items[i_row].SubItems[1].Text);
                Console.WriteLine(Itemlistview.Items[i_row].SubItems[2]);
                bool is_available = Itemlistview.Items[i_row].SubItems[2].Text == "Yes" ? true : false;
                var full_product = new ProductRow(name, price, is_available);
                csvWriter.WriteRecord(full_product);
                csvWriter.NextRecord();



            }
            csvWriter.Flush();
            MessageBox.Show("file created succefully !","Success!");
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