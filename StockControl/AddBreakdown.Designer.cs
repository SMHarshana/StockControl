namespace StockControl
{
    partial class AddBreakdown
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
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_device = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_saleprice = new System.Windows.Forms.Label();
            this.txt_issue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_recivedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_recivedMethod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_serialNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_customer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(243, 318);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(400, 30);
            this.txt_date.TabIndex = 73;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BorderRadius = 20;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(763, 530);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(160, 42);
            this.btn_save.TabIndex = 72;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Device";
            // 
            // cmb_device
            // 
            this.cmb_device.AutoCompleteCustomSource.AddRange(new string[] {
            "Access Control",
            "Time Attendance",
            "Fingerprint Device",
            "Multi-Biometric",
            "Spare Part"});
            this.cmb_device.BackColor = System.Drawing.Color.Transparent;
            this.cmb_device.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_device.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_device.FocusedState.Parent = this.cmb_device;
            this.cmb_device.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_device.ForeColor = System.Drawing.Color.Black;
            this.cmb_device.FormattingEnabled = true;
            this.cmb_device.HoverState.Parent = this.cmb_device;
            this.cmb_device.ItemHeight = 25;
            this.cmb_device.Items.AddRange(new object[] {
            "K30",
            "k50",
            "Icloak 880 ID/WIFI",
            "Icloak ID",
            "G3 Pro"});
            this.cmb_device.ItemsAppearance.Parent = this.cmb_device;
            this.cmb_device.Location = new System.Drawing.Point(243, 105);
            this.cmb_device.Name = "cmb_device";
            this.cmb_device.ShadowDecoration.Parent = this.cmb_device;
            this.cmb_device.Size = new System.Drawing.Size(400, 31);
            this.cmb_device.TabIndex = 70;
            this.cmb_device.SelectedIndexChanged += new System.EventHandler(this.cmb_device_SelectedIndexChanged);
            // 
            // lbl_saleprice
            // 
            this.lbl_saleprice.AutoSize = true;
            this.lbl_saleprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saleprice.Location = new System.Drawing.Point(59, 383);
            this.lbl_saleprice.Name = "lbl_saleprice";
            this.lbl_saleprice.Size = new System.Drawing.Size(48, 23);
            this.lbl_saleprice.TabIndex = 69;
            this.lbl_saleprice.Text = "Issue";
            // 
            // txt_issue
            // 
            this.txt_issue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_issue.DefaultText = "";
            this.txt_issue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_issue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_issue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_issue.DisabledState.Parent = this.txt_issue;
            this.txt_issue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_issue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_issue.FocusedState.Parent = this.txt_issue;
            this.txt_issue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_issue.ForeColor = System.Drawing.Color.Black;
            this.txt_issue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_issue.HoverState.Parent = this.txt_issue;
            this.txt_issue.Location = new System.Drawing.Point(243, 369);
            this.txt_issue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_issue.Multiline = true;
            this.txt_issue.Name = "txt_issue";
            this.txt_issue.PasswordChar = '\0';
            this.txt_issue.PlaceholderText = "";
            this.txt_issue.SelectedText = "";
            this.txt_issue.ShadowDecoration.Parent = this.txt_issue;
            this.txt_issue.Size = new System.Drawing.Size(400, 108);
            this.txt_issue.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Recived Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Recived By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Recived Meothd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Serial Number";
            // 
            // txt_recivedBy
            // 
            this.txt_recivedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recivedBy.DefaultText = "";
            this.txt_recivedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recivedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recivedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recivedBy.DisabledState.Parent = this.txt_recivedBy;
            this.txt_recivedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recivedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recivedBy.FocusedState.Parent = this.txt_recivedBy;
            this.txt_recivedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recivedBy.ForeColor = System.Drawing.Color.Black;
            this.txt_recivedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recivedBy.HoverState.Parent = this.txt_recivedBy;
            this.txt_recivedBy.Location = new System.Drawing.Point(243, 256);
            this.txt_recivedBy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_recivedBy.Name = "txt_recivedBy";
            this.txt_recivedBy.PasswordChar = '\0';
            this.txt_recivedBy.PlaceholderText = "";
            this.txt_recivedBy.SelectedText = "";
            this.txt_recivedBy.ShadowDecoration.Parent = this.txt_recivedBy;
            this.txt_recivedBy.Size = new System.Drawing.Size(400, 39);
            this.txt_recivedBy.TabIndex = 63;
            // 
            // txt_recivedMethod
            // 
            this.txt_recivedMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recivedMethod.DefaultText = "";
            this.txt_recivedMethod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recivedMethod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recivedMethod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recivedMethod.DisabledState.Parent = this.txt_recivedMethod;
            this.txt_recivedMethod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recivedMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recivedMethod.FocusedState.Parent = this.txt_recivedMethod;
            this.txt_recivedMethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recivedMethod.ForeColor = System.Drawing.Color.Black;
            this.txt_recivedMethod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recivedMethod.HoverState.Parent = this.txt_recivedMethod;
            this.txt_recivedMethod.Location = new System.Drawing.Point(243, 205);
            this.txt_recivedMethod.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_recivedMethod.Name = "txt_recivedMethod";
            this.txt_recivedMethod.PasswordChar = '\0';
            this.txt_recivedMethod.PlaceholderText = "";
            this.txt_recivedMethod.SelectedText = "";
            this.txt_recivedMethod.ShadowDecoration.Parent = this.txt_recivedMethod;
            this.txt_recivedMethod.Size = new System.Drawing.Size(400, 39);
            this.txt_recivedMethod.TabIndex = 62;
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
            this.txt_serialNo.Location = new System.Drawing.Point(243, 154);
            this.txt_serialNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_serialNo.Name = "txt_serialNo";
            this.txt_serialNo.PasswordChar = '\0';
            this.txt_serialNo.PlaceholderText = "";
            this.txt_serialNo.SelectedText = "";
            this.txt_serialNo.ShadowDecoration.Parent = this.txt_serialNo;
            this.txt_serialNo.Size = new System.Drawing.Size(400, 39);
            this.txt_serialNo.TabIndex = 61;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(59, 60);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(84, 23);
            this.lbl_category.TabIndex = 60;
            this.lbl_category.Text = "Customer";
            // 
            // cmb_customer
            // 
            this.cmb_customer.AutoCompleteCustomSource.AddRange(new string[] {
            "Access Control",
            "Time Attendance",
            "Fingerprint Device",
            "Multi-Biometric",
            "Spare Part"});
            this.cmb_customer.BackColor = System.Drawing.Color.Transparent;
            this.cmb_customer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmb_customer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_customer.FocusedState.Parent = this.cmb_customer;
            this.cmb_customer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer.ForeColor = System.Drawing.Color.Black;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.HoverState.Parent = this.cmb_customer;
            this.cmb_customer.ItemHeight = 25;
            this.cmb_customer.ItemsAppearance.Parent = this.cmb_customer;
            this.cmb_customer.Location = new System.Drawing.Point(243, 54);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.ShadowDecoration.Parent = this.cmb_customer;
            this.cmb_customer.Size = new System.Drawing.Size(400, 31);
            this.cmb_customer.TabIndex = 59;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // AddBreakdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(935, 584);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_device);
            this.Controls.Add(this.lbl_saleprice);
            this.Controls.Add(this.txt_issue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_recivedBy);
            this.Controls.Add(this.txt_recivedMethod);
            this.Controls.Add(this.txt_serialNo);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cmb_customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBreakdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBreakdown";
            this.Load += new System.EventHandler(this.AddBreakdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_date;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_device;
        private System.Windows.Forms.Label lbl_saleprice;
        private Guna.UI2.WinForms.Guna2TextBox txt_issue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_recivedBy;
        private Guna.UI2.WinForms.Guna2TextBox txt_recivedMethod;
        private Guna.UI2.WinForms.Guna2TextBox txt_serialNo;
        private System.Windows.Forms.Label lbl_category;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_customer;
    }
}