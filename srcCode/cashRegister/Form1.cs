using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;

namespace cashRegister
{
    public partial class cashMain : MetroForm
    {
        public cashMain()
        {
            InitializeComponent();
            InitialiseProductGrid();
            InitialiseSalesGrid();
            cancelBtn.Enabled = false;
            deletebtn.Enabled = false;
        }
        
        private void InitialiseProductGrid()
        {
            productGrid1.ColumnCount = 2;
            productGrid1.Columns[0].Name = "Products";
            
            productGrid1.Columns[1].Name = "Price";

        }
        private void InitialiseSalesGrid()
        {
            salesGrid1.ColumnCount = 4;
            salesGrid1.Columns[0].Name = "Items";
            salesGrid1.Columns[1].Name = "units";
            salesGrid1.Columns[2].Name = "unit Price";
            salesGrid1.Columns[3].Name = "total";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadProducts_Click(object sender, EventArgs e)
        {
            if(load_dialog.ShowDialog()== DialogResult.OK)
            {
                //Console.WriteLine(productGrid1.RowCount);
                var reader = new StreamReader(load_dialog.FileName);
                var csv_reader = new CsvReader(reader, CultureInfo.InvariantCulture);
                var GetData = csv_reader.GetRecords<ProductRow>();
                foreach (var row_data in GetData)
                {
                    if(row_data.Availability == true)
                    {
                        //string[] row = { row_data.ProductName, row_data.Price.ToString() };
                        int rowId = productGrid1.Rows.Add();

                        // Grab the new row!
                        DataGridViewRow row = productGrid1.Rows[rowId];

                        // Add the data
                        row.Cells["Products"].Value = row_data.ProductName;
                        row.Cells["Price"].Value = row_data.Price.ToString();

                        //var listItem = new ListViewItem(row);
                        //Mainlist.Items.Add(listItem);
                    }
                    
                }
                reader.Close();
                if(productGrid1.RowCount > 0)
                {
                    addbtn.Enabled = true;
                }


            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addSaleGrid frm = new addSaleGrid();
            frm.ShowDialog();
        }
    }
    // class used to read the data
    public class ProductRow
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public bool Availability { get; set; }
        public ProductRow(string ProductName, float Price, bool Availability)
        {
            
            this.ProductName = ProductName;
            this.Price = Price;
            this.Availability = Availability;

        }
    }
}
