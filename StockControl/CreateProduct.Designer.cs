namespace StockControl
{
    partial class CreateProduct
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
            this.cmb_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_brand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_purchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_salePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_create = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_model = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.Transparent;
            this.cmb_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_category.FocusedState.Parent = this.cmb_category;
            this.cmb_category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.ForeColor = System.Drawing.Color.Black;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.HoverState.Parent = this.cmb_category;
            this.cmb_category.ItemHeight = 25;
            this.cmb_category.Items.AddRange(new object[] {
            "Fingerprint Devices",
            "Spare Parts"});
            this.cmb_category.ItemsAppearance.Parent = this.cmb_category;
            this.cmb_category.Location = new System.Drawing.Point(188, 96);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.ShadowDecoration.Parent = this.cmb_category;
            this.cmb_category.Size = new System.Drawing.Size(400, 31);
            this.cmb_category.TabIndex = 0;
            this.cmb_category.SelectionChangeCommitted += new System.EventHandler(this.cmb_category_SelectionChangeCommitted);
            this.cmb_category.SelectedValueChanged += new System.EventHandler(this.cmb_category_SelectedValueChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(43, 102);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(79, 23);
            this.lbl_category.TabIndex = 9;
            this.lbl_category.Text = "Category";
            // 
            // txt_brand
            // 
            this.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_brand.DefaultText = "";
            this.txt_brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_brand.DisabledState.Parent = this.txt_brand;
            this.txt_brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_brand.FocusedState.Parent = this.txt_brand;
            this.txt_brand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brand.ForeColor = System.Drawing.Color.Black;
            this.txt_brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_brand.HoverState.Parent = this.txt_brand;
            this.txt_brand.Location = new System.Drawing.Point(188, 197);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.PlaceholderText = "ZKTeco";
            this.txt_brand.SelectedText = "";
            this.txt_brand.ShadowDecoration.Parent = this.txt_brand;
            this.txt_brand.Size = new System.Drawing.Size(400, 39);
            this.txt_brand.TabIndex = 10;
            // 
            // txt_description
            // 
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.DefaultText = "";
            this.txt_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.DisabledState.Parent = this.txt_description;
            this.txt_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.FocusedState.Parent = this.txt_description;
            this.txt_description.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.HoverState.Parent = this.txt_description;
            this.txt_description.Location = new System.Drawing.Point(188, 248);
            this.txt_description.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderText = "Product name including model";
            this.txt_description.SelectedText = "";
            this.txt_description.ShadowDecoration.Parent = this.txt_description;
            this.txt_description.Size = new System.Drawing.Size(400, 39);
            this.txt_description.TabIndex = 11;
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_purchasePrice.DefaultText = "";
            this.txt_purchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_purchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_purchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchasePrice.DisabledState.Parent = this.txt_purchasePrice;
            this.txt_purchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchasePrice.FocusedState.Parent = this.txt_purchasePrice;
            this.txt_purchasePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchasePrice.ForeColor = System.Drawing.Color.Black;
            this.txt_purchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchasePrice.HoverState.Parent = this.txt_purchasePrice;
            this.txt_purchasePrice.Location = new System.Drawing.Point(188, 299);
            this.txt_purchasePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.PasswordChar = '\0';
            this.txt_purchasePrice.PlaceholderText = "0.00";
            this.txt_purchasePrice.SelectedText = "";
            this.txt_purchasePrice.ShadowDecoration.Parent = this.txt_purchasePrice;
            this.txt_purchasePrice.Size = new System.Drawing.Size(400, 39);
            this.txt_purchasePrice.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sale Price";
            // 
            // txt_salePrice
            // 
            this.txt_salePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_salePrice.DefaultText = "";
            this.txt_salePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_salePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_salePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salePrice.DisabledState.Parent = this.txt_salePrice;
            this.txt_salePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salePrice.FocusedState.Parent = this.txt_salePrice;
            this.txt_salePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salePrice.ForeColor = System.Drawing.Color.Black;
            this.txt_salePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salePrice.HoverState.Parent = this.txt_salePrice;
            this.txt_salePrice.Location = new System.Drawing.Point(188, 350);
            this.txt_salePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_salePrice.Name = "txt_salePrice";
            this.txt_salePrice.PasswordChar = '\0';
            this.txt_salePrice.PlaceholderText = "0.00";
            this.txt_salePrice.SelectedText = "";
            this.txt_salePrice.ShadowDecoration.Parent = this.txt_salePrice;
            this.txt_salePrice.Size = new System.Drawing.Size(400, 39);
            this.txt_salePrice.TabIndex = 17;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.AutoRoundedCorners = true;
            this.btn_create.BorderRadius = 19;
            this.btn_create.CheckedState.Parent = this.btn_create;
            this.btn_create.CustomImages.Parent = this.btn_create;
            this.btn_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.HoverState.Parent = this.btn_create;
            this.btn_create.Location = new System.Drawing.Point(759, 593);
            this.btn_create.Name = "btn_create";
            this.btn_create.ShadowDecoration.Parent = this.btn_create;
            this.btn_create.Size = new System.Drawing.Size(160, 40);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "Create";
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cmb_model
            // 
            this.cmb_model.BackColor = System.Drawing.Color.Transparent;
            this.cmb_model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_model.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_model.FocusedState.Parent = this.cmb_model;
            this.cmb_model.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_model.ForeColor = System.Drawing.Color.Black;
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.HoverState.Parent = this.cmb_model;
            this.cmb_model.ItemHeight = 25;
            this.cmb_model.ItemsAppearance.Parent = this.cmb_model;
            this.cmb_model.Location = new System.Drawing.Point(188, 147);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.ShadowDecoration.Parent = this.cmb_model;
            this.cmb_model.Size = new System.Drawing.Size(400, 31);
            this.cmb_model.TabIndex = 23;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(43, 153);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(58, 23);
            this.lbl_model.TabIndex = 24;
            this.lbl_model.Text = "Model";
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(947, 645);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_salePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cmb_category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Product";
            this.Load += new System.EventHandler(this.CreateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmb_category;
        private System.Windows.Forms.Label lbl_category;
        private Guna.UI2.WinForms.Guna2TextBox txt_brand;
        private Guna.UI2.WinForms.Guna2TextBox txt_description;
        private Guna.UI2.WinForms.Guna2TextBox txt_purchasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_salePrice;
        private Guna.UI2.WinForms.Guna2Button btn_create;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_model;
        private System.Windows.Forms.Label lbl_model;
    }
}