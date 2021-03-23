
namespace UI_Product_maintenance_software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Add_product = new System.Windows.Forms.Button();
            this.Change_price_button = new System.Windows.Forms.Button();
            this.Save_productlist = new System.Windows.Forms.Button();
            this.Load_productlist = new System.Windows.Forms.Button();
            this.Productgridlist = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productgridlist)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Productgridlist, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Add_product, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Change_price_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Save_productlist, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Load_productlist, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Add_product
            // 
            this.Add_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_product.Location = new System.Drawing.Point(3, 3);
            this.Add_product.Name = "Add_product";
            this.Add_product.Size = new System.Drawing.Size(192, 49);
            this.Add_product.TabIndex = 0;
            this.Add_product.Text = "Add";
            this.Add_product.UseVisualStyleBackColor = true;
            // 
            // Change_price_button
            // 
            this.Change_price_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Change_price_button.Location = new System.Drawing.Point(201, 3);
            this.Change_price_button.Name = "Change_price_button";
            this.Change_price_button.Size = new System.Drawing.Size(192, 49);
            this.Change_price_button.TabIndex = 1;
            this.Change_price_button.Text = "Change price";
            this.Change_price_button.UseVisualStyleBackColor = true;
            // 
            // Save_productlist
            // 
            this.Save_productlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_productlist.Location = new System.Drawing.Point(597, 3);
            this.Save_productlist.Name = "Save_productlist";
            this.Save_productlist.Size = new System.Drawing.Size(194, 49);
            this.Save_productlist.TabIndex = 3;
            this.Save_productlist.Text = "Save";
            this.Save_productlist.UseVisualStyleBackColor = true;
            // 
            // Load_productlist
            // 
            this.Load_productlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Load_productlist.Location = new System.Drawing.Point(399, 3);
            this.Load_productlist.Name = "Load_productlist";
            this.Load_productlist.Size = new System.Drawing.Size(192, 49);
            this.Load_productlist.TabIndex = 2;
            this.Load_productlist.Text = "Load";
            this.Load_productlist.UseVisualStyleBackColor = true;
            // 
            // Productgridlist
            // 
            this.Productgridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productgridlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Productgridlist.Location = new System.Drawing.Point(3, 3);
            this.Productgridlist.Name = "Productgridlist";
            this.Productgridlist.Size = new System.Drawing.Size(794, 384);
            this.Productgridlist.TabIndex = 2;
            this.Productgridlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productgridlist_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Productgridlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Add_product;
        private System.Windows.Forms.Button Change_price_button;
        private System.Windows.Forms.Button Save_productlist;
        private System.Windows.Forms.Button Load_productlist;
        private System.Windows.Forms.DataGridView Productgridlist;
    }
}

