using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class addSaleGrid : Form
    {

        public int index_row { get; set; }
        
        public addSaleGrid()
        {
            InitializeComponent();
            //index_row = cashMain.productGrid1.CurrentCell.RowIndex;
        }
       
       
    }
}
