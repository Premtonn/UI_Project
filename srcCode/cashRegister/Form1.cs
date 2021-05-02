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
        public static cashMain instance;
        public static float CalculateTotal()
        {
            float result = 0.0f;
            for(int row_index=0; row_index < cashMain.instance.salesGrid1.RowCount; row_index++)
            {
                
                result += float.Parse(cashMain.instance.salesGrid1.Rows[row_index].Cells["total"].Value.ToString());
            }
            return result;
            
        }
        public static string getSelectedProductName()
        {
            var index_row = cashMain.instance.productGrid1.CurrentCell.RowIndex;
            return cashMain.instance.productGrid1.Rows[index_row].Cells["Products"].Value.ToString();
        }

        //public MetroFramework.Controls.MetroGrid ProductGrid
        //{
        //    get { return productGrid1; }
        //}
        //public MetroFramework.Controls.MetroGrid SaleGrid { get { return salesGrid1; } }
        public cashMain()
        {
            // instance of the current  form
            instance = this;
            InitializeComponent();
            InitialiseProductGrid();
            InitialiseSalesGrid();
            //cancelBtn.Enabled = false;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var base_dir = "transactions";
            string file_name = String.Format("{0}.txt", now.ToString("yyyy-MM-dd.HH.mm.ss"));
            string full_path = Path.Combine("transactions", file_name);
            bool exist = Directory.Exists(base_dir);
            if( !exist)
            {
                Directory.CreateDirectory(base_dir);
            }
            
            var file = new StreamWriter(Path.Combine("transactions", file_name));

            file.WriteLine("grand Total:\t{0}", totalPrice.Text);
            for (int i_row = 0; i_row < cashMain.instance.salesGrid1.RowCount; i_row++)
            {
                var row = cashMain.instance.salesGrid1.Rows[i_row];
                file.WriteLine("Item:\t{0}\tnumber:\t{1}", row.Cells["Items"].Value.ToString(), row.Cells["units"].Value.ToString());


            }
            
            file.Close();
            MessageBox.Show("Transaction is saved ! !", "Success!");
            salesGrid1.Rows.Clear();
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
