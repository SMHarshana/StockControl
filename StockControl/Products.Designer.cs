namespace StockControl
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_createProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addProduct = new Guna.UI2.WinForms.Guna2Button();
            this.tbl_product = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createProduct
            // 
            this.btn_createProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createProduct.AutoRoundedCorners = true;
            this.btn_createProduct.BorderRadius = 20;
            this.btn_createProduct.CheckedState.Parent = this.btn_createProduct;
            this.btn_createProduct.CustomImages.Parent = this.btn_createProduct;
            this.btn_createProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_createProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createProduct.ForeColor = System.Drawing.Color.White;
            this.btn_createProduct.HoverState.Parent = this.btn_createProduct;
            this.btn_createProduct.Location = new System.Drawing.Point(769, 58);
            this.btn_createProduct.Name = "btn_createProduct";
            this.btn_createProduct.ShadowDecoration.Parent = this.btn_createProduct;
            this.btn_createProduct.Size = new System.Drawing.Size(246, 42);
            this.btn_createProduct.TabIndex = 21;
            this.btn_createProduct.Text = "Create Product";
            this.btn_createProduct.Click += new System.EventHandler(this.btn_createProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addProduct.AutoRoundedCorners = true;
            this.btn_addProduct.BorderRadius = 20;
            this.btn_addProduct.CheckedState.Parent = this.btn_addProduct;
            this.btn_addProduct.CustomImages.Parent = this.btn_addProduct;
            this.btn_addProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(197)))));
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.HoverState.Parent = this.btn_addProduct;
            this.btn_addProduct.Location = new System.Drawing.Point(493, 58);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.ShadowDecoration.Parent = this.btn_addProduct;
            this.btn_addProduct.Size = new System.Drawing.Size(246, 42);
            this.btn_addProduct.TabIndex = 22;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // tbl_product
            // 
            this.tbl_product.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbl_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_product.ColumnHeadersHeight = 41;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbl_product.EnableHeadersVisualStyles = false;
            this.tbl_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_product.Location = new System.Drawing.Point(3, 106);
            this.tbl_product.Name = "tbl_product";
            this.tbl_product.ReadOnly = true;
            this.tbl_product.RowHeadersVisible = false;
            this.tbl_product.RowHeadersWidth = 51;
            this.tbl_product.RowTemplate.Height = 41;
            this.tbl_product.RowTemplate.ReadOnly = true;
            this.tbl_product.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_product.Size = new System.Drawing.Size(1045, 492);
            this.tbl_product.TabIndex = 23;
            this.tbl_product.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tbl_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbl_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbl_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbl_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbl_product.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbl_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tbl_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbl_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbl_product.ThemeStyle.HeaderStyle.Height = 41;
            this.tbl_product.ThemeStyle.ReadOnly = true;
            this.tbl_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tbl_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tbl_product.ThemeStyle.RowsStyle.Height = 41;
            this.tbl_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbl_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.tbl_product);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_createProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_createProduct;
        private Guna.UI2.WinForms.Guna2Button btn_addProduct;
        private Guna.UI2.WinForms.Guna2DataGridView tbl_product;
    }
}