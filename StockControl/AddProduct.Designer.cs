namespace StockControl
{
    partial class AddProduct
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
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.txt_purchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_brand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_serialNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_salePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_saleprice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_model = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tgl_autoSave = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BorderRadius = 19;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(950, 591);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(160, 40);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.txt_purchasePrice.Location = new System.Drawing.Point(218, 331);
            this.txt_purchasePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.PasswordChar = '\0';
            this.txt_purchasePrice.PlaceholderText = "0.00";
            this.txt_purchasePrice.SelectedText = "";
            this.txt_purchasePrice.ShadowDecoration.Parent = this.txt_purchasePrice;
            this.txt_purchasePrice.Size = new System.Drawing.Size(400, 39);
            this.txt_purchasePrice.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Purchase Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Serial Number";
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
            this.txt_description.Location = new System.Drawing.Point(218, 280);
            this.txt_description.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderText = "ZKTeco G3Pro WIFI";
            this.txt_description.SelectedText = "";
            this.txt_description.ShadowDecoration.Parent = this.txt_description;
            this.txt_description.Size = new System.Drawing.Size(400, 39);
            this.txt_description.TabIndex = 27;
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
            this.txt_brand.Location = new System.Drawing.Point(218, 229);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.PlaceholderText = "ZKTeco";
            this.txt_brand.SelectedText = "";
            this.txt_brand.ShadowDecoration.Parent = this.txt_brand;
            this.txt_brand.Size = new System.Drawing.Size(400, 39);
            this.txt_brand.TabIndex = 26;
            // 
            // txt_serialNo
            // 
            this.txt_serialNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_serialNo.DefaultText = "";
            this.txt_serialNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_serialNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_serialNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serialNo.DisabledState.Parent = this.txt_serialNo;
            this.txt_serialNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serialNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serialNo.FocusedState.Parent = this.txt_serialNo;
            this.txt_serialNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serialNo.ForeColor = System.Drawing.Color.Black;
            this.txt_serialNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serialNo.HoverState.Parent = this.txt_serialNo;
            this.txt_serialNo.Location = new System.Drawing.Point(218, 178);
            this.txt_serialNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_serialNo.Name = "txt_serialNo";
            this.txt_serialNo.PasswordChar = '\0';
            this.txt_serialNo.PlaceholderText = "CEPP100000001";
            this.txt_serialNo.SelectedText = "";
            this.txt_serialNo.ShadowDecoration.Parent = this.txt_serialNo;
            this.txt_serialNo.Size = new System.Drawing.Size(400, 39);
            this.txt_serialNo.TabIndex = 25;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(34, 84);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(79, 23);
            this.lbl_category.TabIndex = 24;
            this.lbl_category.Text = "Category";
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteCustomSource.AddRange(new string[] {
            "Access Control",
            "Time Attendance",
            "Fingerprint Device",
            "Multi-Biometric",
            "Spare Part"});
            this.cmb_category.BackColor = System.Drawing.Color.Transparent;
            this.cmb_category.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
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
            this.cmb_category.Location = new System.Drawing.Point(218, 78);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.ShadowDecoration.Parent = this.cmb_category;
            this.cmb_category.Size = new System.Drawing.Size(400, 31);
            this.cmb_category.TabIndex = 23;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
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
            this.txt_salePrice.Location = new System.Drawing.Point(218, 382);
            this.txt_salePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_salePrice.Name = "txt_salePrice";
            this.txt_salePrice.PasswordChar = '\0';
            this.txt_salePrice.PlaceholderText = "0.00";
            this.txt_salePrice.SelectedText = "";
            this.txt_salePrice.ShadowDecoration.Parent = this.txt_salePrice;
            this.txt_salePrice.Size = new System.Drawing.Size(400, 39);
            this.txt_salePrice.TabIndex = 34;
            // 
            // lbl_saleprice
            // 
            this.lbl_saleprice.AutoSize = true;
            this.lbl_saleprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saleprice.Location = new System.Drawing.Point(32, 396);
            this.lbl_saleprice.Name = "lbl_saleprice";
            this.lbl_saleprice.Size = new System.Drawing.Size(83, 23);
            this.lbl_saleprice.TabIndex = 35;
            this.lbl_saleprice.Text = "Sale Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Model";
            // 
            // cmb_model
            // 
            this.cmb_model.AutoCompleteCustomSource.AddRange(new string[] {
            "Access Control",
            "Time Attendance",
            "Fingerprint Device",
            "Multi-Biometric",
            "Spare Part"});
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
            this.cmb_model.Items.AddRange(new object[] {
            "Access Control",
            "Time Attendance",
            "Fingerprint Device",
            "Multi-Biometric",
            "Spare Part"});
            this.cmb_model.ItemsAppearance.Parent = this.cmb_model;
            this.cmb_model.Location = new System.Drawing.Point(218, 129);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.ShadowDecoration.Parent = this.cmb_model;
            this.cmb_model.Size = new System.Drawing.Size(400, 31);
            this.cmb_model.TabIndex = 38;
            this.cmb_model.SelectedIndexChanged += new System.EventHandler(this.cmb_model_SelectedIndexChanged);
            // 
            // tgl_autoSave
            // 
            this.tgl_autoSave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgl_autoSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgl_autoSave.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgl_autoSave.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgl_autoSave.CheckedState.Parent = this.tgl_autoSave;
            this.tgl_autoSave.Location = new System.Drawing.Point(1059, 24);
            this.tgl_autoSave.Name = "tgl_autoSave";
            this.tgl_autoSave.ShadowDecoration.Parent = this.tgl_autoSave;
            this.tgl_autoSave.Size = new System.Drawing.Size(51, 26);
            this.tgl_autoSave.TabIndex = 40;
            this.tgl_autoSave.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgl_autoSave.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgl_autoSave.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgl_autoSave.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgl_autoSave.UncheckedState.Parent = this.tgl_autoSave;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(956, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Auto Save";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1132, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tgl_autoSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.lbl_saleprice);
            this.Controls.Add(this.txt_salePrice);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_serialNo);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cmb_category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2TextBox txt_purchasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_description;
        private Guna.UI2.WinForms.Guna2TextBox txt_brand;
        private Guna.UI2.WinForms.Guna2TextBox txt_serialNo;
        private System.Windows.Forms.Label lbl_category;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_category;
        private Guna.UI2.WinForms.Guna2TextBox txt_salePrice;
        private System.Windows.Forms.Label lbl_saleprice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_model;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgl_autoSave;
        private System.Windows.Forms.Label label5;
    }
}