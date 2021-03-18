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
            productGrid1.ColumnCount = 3;
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
    }
}
