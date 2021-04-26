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

        
        
        
        public addSaleGrid()
        {
            InitializeComponent();
            
            this.Text = cashMain.getSelectedProductName();
        }

        private void add_to_grid_btn_Click(object sender, EventArgs e)
        {


            
        }

        // only allow numbers
        private void unitsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
