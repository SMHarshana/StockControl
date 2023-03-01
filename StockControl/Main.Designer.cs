namespace StockControl
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_customer = new System.Windows.Forms.Panel();
            this.panel_stocks = new System.Windows.Forms.Panel();
            this.panel_sales = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_newCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.bnt_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_breakdown = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inventory = new Guna.UI2.WinForms.Guna2Button();
            this.btn_adprducts = new Guna.UI2.WinForms.Guna2Button();
            this.btn_stocks = new Guna.UI2.WinForms.Guna2Button();
            this.btn_invoiceReport = new Guna.UI2.WinForms.Guna2Button();
            this.btn_estimateReport = new Guna.UI2.WinForms.Guna2Button();
            this.btn_estimate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_invoice = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sales = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel_customer.SuspendLayout();
            this.panel_stocks.SuspendLayout();
            this.panel_sales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.panel_customer);
            this.panel1.Controls.Add(this.bnt_customer);
            this.panel1.Controls.Add(this.panel_stocks);
            this.panel1.Controls.Add(this.btn_stocks);
            this.panel1.Controls.Add(this.panel_sales);
            this.panel1.Controls.Add(this.btn_sales);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 608);
            this.panel1.TabIndex = 0;
            // 
            // panel_customer
            // 
            this.panel_customer.Controls.Add(this.guna2Button1);
            this.panel_customer.Controls.Add(this.btn_newCustomer);
            this.panel_customer.Controls.Add(this.guna2Button3);
            this.panel_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_customer.Location = new System.Drawing.Point(0, 644);
            this.panel_customer.Name = "panel_customer";
            this.panel_customer.Size = new System.Drawing.Size(220, 169);
            this.panel_customer.TabIndex = 11;
            // 
            // panel_stocks
            // 
            this.panel_stocks.Controls.Add(this.btn_breakdown);
            this.panel_stocks.Controls.Add(this.btn_inventory);
            this.panel_stocks.Controls.Add(this.btn_adprducts);
            this.panel_stocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stocks.Location = new System.Drawing.Point(0, 430);
            this.panel_stocks.Name = "panel_stocks";
            this.panel_stocks.Size = new System.Drawing.Size(220, 169);
            this.panel_stocks.TabIndex = 9;
            // 
            // panel_sales
            // 
            this.panel_sales.Controls.Add(this.btn_invoiceReport);
            this.panel_sales.Controls.Add(this.btn_estimateReport);
            this.panel_sales.Controls.Add(this.btn_estimate);
            this.panel_sales.Controls.Add(this.btn_invoice);
            this.panel_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sales.Location = new System.Drawing.Point(0, 169);
            this.panel_sales.Name = "panel_sales";
            this.panel_sales.Size = new System.Drawing.Size(220, 216);
            this.panel_sales.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.lbl_role);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 124);
            this.panel2.TabIndex = 7;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(13, 43);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(53, 20);
            this.lbl_role.TabIndex = 9;
            this.lbl_role.Text = "Admin";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(12, 15);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(93, 28);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "Harshana";
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(241, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1024, 608);
            this.PanelContainer.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.lbl_title);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(241, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1024, 55);
            this.titlePanel.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(21, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 41);
            this.lbl_title.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::StockControl.Properties.Resources.technical_support;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(48, 115);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(193, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Breakdown";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_newCustomer
            // 
            this.btn_newCustomer.AutoRoundedCorners = true;
            this.btn_newCustomer.BorderRadius = 21;
            this.btn_newCustomer.CheckedState.Parent = this.btn_newCustomer;
            this.btn_newCustomer.CustomImages.Parent = this.btn_newCustomer;
            this.btn_newCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_newCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_newCustomer.HoverState.Parent = this.btn_newCustomer;
            this.btn_newCustomer.Image = global::StockControl.Properties.Resources.group;
            this.btn_newCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_newCustomer.Location = new System.Drawing.Point(48, 13);
            this.btn_newCustomer.Name = "btn_newCustomer";
            this.btn_newCustomer.ShadowDecoration.Parent = this.btn_newCustomer;
            this.btn_newCustomer.Size = new System.Drawing.Size(193, 45);
            this.btn_newCustomer.TabIndex = 1;
            this.btn_newCustomer.Text = "New Customer";
            this.btn_newCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_newCustomer.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::StockControl.Properties.Resources.packaging;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(48, 64);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(193, 45);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Products";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnt_customer
            // 
            this.bnt_customer.AutoRoundedCorners = true;
            this.bnt_customer.BorderRadius = 21;
            this.bnt_customer.CheckedState.Parent = this.bnt_customer;
            this.bnt_customer.CustomImages.Parent = this.bnt_customer;
            this.bnt_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnt_customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bnt_customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_customer.ForeColor = System.Drawing.Color.Black;
            this.bnt_customer.HoverState.Parent = this.bnt_customer;
            this.bnt_customer.Image = global::StockControl.Properties.Resources.customer_review;
            this.bnt_customer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnt_customer.Location = new System.Drawing.Point(0, 599);
            this.bnt_customer.Name = "bnt_customer";
            this.bnt_customer.ShadowDecoration.Parent = this.bnt_customer;
            this.bnt_customer.Size = new System.Drawing.Size(220, 45);
            this.bnt_customer.TabIndex = 10;
            this.bnt_customer.Text = "Customer";
            this.bnt_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnt_customer.Click += new System.EventHandler(this.bnt_customer_Click);
            // 
            // btn_breakdown
            // 
            this.btn_breakdown.AutoRoundedCorners = true;
            this.btn_breakdown.BorderRadius = 21;
            this.btn_breakdown.CheckedState.Parent = this.btn_breakdown;
            this.btn_breakdown.CustomImages.Parent = this.btn_breakdown;
            this.btn_breakdown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_breakdown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_breakdown.ForeColor = System.Drawing.Color.Black;
            this.btn_breakdown.HoverState.Parent = this.btn_breakdown;
            this.btn_breakdown.Image = global::StockControl.Properties.Resources.technical_support;
            this.btn_breakdown.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_breakdown.Location = new System.Drawing.Point(48, 115);
            this.btn_breakdown.Name = "btn_breakdown";
            this.btn_breakdown.ShadowDecoration.Parent = this.btn_breakdown;
            this.btn_breakdown.Size = new System.Drawing.Size(193, 45);
            this.btn_breakdown.TabIndex = 3;
            this.btn_breakdown.Text = "Breakdown";
            this.btn_breakdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_breakdown.Click += new System.EventHandler(this.btn_breakdown_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.AutoRoundedCorners = true;
            this.btn_inventory.BorderRadius = 21;
            this.btn_inventory.CheckedState.Parent = this.btn_inventory;
            this.btn_inventory.CustomImages.Parent = this.btn_inventory;
            this.btn_inventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.Black;
            this.btn_inventory.HoverState.Parent = this.btn_inventory;
            this.btn_inventory.Image = global::StockControl.Properties.Resources.stock1;
            this.btn_inventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inventory.Location = new System.Drawing.Point(48, 13);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.ShadowDecoration.Parent = this.btn_inventory;
            this.btn_inventory.Size = new System.Drawing.Size(193, 45);
            this.btn_inventory.TabIndex = 1;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inventory.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_adprducts
            // 
            this.btn_adprducts.AutoRoundedCorners = true;
            this.btn_adprducts.BorderRadius = 21;
            this.btn_adprducts.CheckedState.Parent = this.btn_adprducts;
            this.btn_adprducts.CustomImages.Parent = this.btn_adprducts;
            this.btn_adprducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_adprducts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adprducts.ForeColor = System.Drawing.Color.Black;
            this.btn_adprducts.HoverState.Parent = this.btn_adprducts;
            this.btn_adprducts.Image = global::StockControl.Properties.Resources.packaging;
            this.btn_adprducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_adprducts.Location = new System.Drawing.Point(48, 64);
            this.btn_adprducts.Name = "btn_adprducts";
            this.btn_adprducts.ShadowDecoration.Parent = this.btn_adprducts;
            this.btn_adprducts.Size = new System.Drawing.Size(193, 45);
            this.btn_adprducts.TabIndex = 2;
            this.btn_adprducts.Text = "Products";
            this.btn_adprducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_adprducts.Click += new System.EventHandler(this.btn_adprducts_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.AutoRoundedCorners = true;
            this.btn_stocks.BorderRadius = 21;
            this.btn_stocks.CheckedState.Parent = this.btn_stocks;
            this.btn_stocks.CustomImages.Parent = this.btn_stocks;
            this.btn_stocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stocks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_stocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stocks.ForeColor = System.Drawing.Color.Black;
            this.btn_stocks.HoverState.Parent = this.btn_stocks;
            this.btn_stocks.Image = global::StockControl.Properties.Resources.sales;
            this.btn_stocks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_stocks.Location = new System.Drawing.Point(0, 385);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.ShadowDecoration.Parent = this.btn_stocks;
            this.btn_stocks.Size = new System.Drawing.Size(220, 45);
            this.btn_stocks.TabIndex = 8;
            this.btn_stocks.Text = "Stocks";
            this.btn_stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_stocks.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_invoiceReport
            // 
            this.btn_invoiceReport.AutoRoundedCorners = true;
            this.btn_invoiceReport.BorderRadius = 21;
            this.btn_invoiceReport.CheckedState.Parent = this.btn_invoiceReport;
            this.btn_invoiceReport.CustomImages.Parent = this.btn_invoiceReport;
            this.btn_invoiceReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_invoiceReport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoiceReport.ForeColor = System.Drawing.Color.Black;
            this.btn_invoiceReport.HoverState.Parent = this.btn_invoiceReport;
            this.btn_invoiceReport.Image = global::StockControl.Properties.Resources.invoice;
            this.btn_invoiceReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_invoiceReport.Location = new System.Drawing.Point(48, 165);
            this.btn_invoiceReport.Name = "btn_invoiceReport";
            this.btn_invoiceReport.ShadowDecoration.Parent = this.btn_invoiceReport;
            this.btn_invoiceReport.Size = new System.Drawing.Size(193, 45);
            this.btn_invoiceReport.TabIndex = 4;
            this.btn_invoiceReport.Text = "Invoice Report";
            this.btn_invoiceReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_estimateReport
            // 
            this.btn_estimateReport.AutoRoundedCorners = true;
            this.btn_estimateReport.BorderRadius = 21;
            this.btn_estimateReport.CheckedState.Parent = this.btn_estimateReport;
            this.btn_estimateReport.CustomImages.Parent = this.btn_estimateReport;
            this.btn_estimateReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_estimateReport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estimateReport.ForeColor = System.Drawing.Color.Black;
            this.btn_estimateReport.HoverState.Parent = this.btn_estimateReport;
            this.btn_estimateReport.Image = global::StockControl.Properties.Resources.sale_report;
            this.btn_estimateReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_estimateReport.Location = new System.Drawing.Point(48, 115);
            this.btn_estimateReport.Name = "btn_estimateReport";
            this.btn_estimateReport.ShadowDecoration.Parent = this.btn_estimateReport;
            this.btn_estimateReport.Size = new System.Drawing.Size(193, 45);
            this.btn_estimateReport.TabIndex = 3;
            this.btn_estimateReport.Text = "Estimate Report";
            this.btn_estimateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_estimateReport.Click += new System.EventHandler(this.btn_estimateReport_Click);
            // 
            // btn_estimate
            // 
            this.btn_estimate.AutoRoundedCorners = true;
            this.btn_estimate.BorderRadius = 21;
            this.btn_estimate.CheckedState.Parent = this.btn_estimate;
            this.btn_estimate.CustomImages.Parent = this.btn_estimate;
            this.btn_estimate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_estimate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estimate.ForeColor = System.Drawing.Color.Black;
            this.btn_estimate.HoverState.Parent = this.btn_estimate;
            this.btn_estimate.Image = global::StockControl.Properties.Resources.budget;
            this.btn_estimate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_estimate.Location = new System.Drawing.Point(48, 13);
            this.btn_estimate.Name = "btn_estimate";
            this.btn_estimate.ShadowDecoration.Parent = this.btn_estimate;
            this.btn_estimate.Size = new System.Drawing.Size(193, 45);
            this.btn_estimate.TabIndex = 1;
            this.btn_estimate.Text = "Estimates";
            this.btn_estimate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_estimate.Click += new System.EventHandler(this.btn_estimate_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.AutoRoundedCorners = true;
            this.btn_invoice.BorderRadius = 21;
            this.btn_invoice.CheckedState.Parent = this.btn_invoice;
            this.btn_invoice.CustomImages.Parent = this.btn_invoice;
            this.btn_invoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_invoice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.Color.Black;
            this.btn_invoice.HoverState.Parent = this.btn_invoice;
            this.btn_invoice.Image = global::StockControl.Properties.Resources.report;
            this.btn_invoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_invoice.Location = new System.Drawing.Point(48, 64);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.ShadowDecoration.Parent = this.btn_invoice;
            this.btn_invoice.Size = new System.Drawing.Size(193, 45);
            this.btn_invoice.TabIndex = 2;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.AutoRoundedCorners = true;
            this.btn_sales.BorderRadius = 21;
            this.btn_sales.CheckedState.Parent = this.btn_sales;
            this.btn_sales.CustomImages.Parent = this.btn_sales;
            this.btn_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_sales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.Black;
            this.btn_sales.HoverState.Parent = this.btn_sales;
            this.btn_sales.Image = global::StockControl.Properties.Resources.shopping;
            this.btn_sales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sales.Location = new System.Drawing.Point(0, 124);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.ShadowDecoration.Parent = this.btn_sales;
            this.btn_sales.Size = new System.Drawing.Size(220, 45);
            this.btn_sales.TabIndex = 0;
            this.btn_sales.Text = "Sales";
            this.btn_sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sales.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_home
            // 
            this.btn_home.AutoRoundedCorners = true;
            this.btn_home.BorderRadius = 21;
            this.btn_home.CheckedState.Parent = this.btn_home;
            this.btn_home.CustomImages.Parent = this.btn_home;
            this.btn_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.HoverState.Parent = this.btn_home;
            this.btn_home.Image = global::StockControl.Properties.Resources.house1;
            this.btn_home.Location = new System.Drawing.Point(3, 73);
            this.btn_home.Name = "btn_home";
            this.btn_home.ShadowDecoration.Parent = this.btn_home;
            this.btn_home.Size = new System.Drawing.Size(49, 45);
            this.btn_home.TabIndex = 10;
            this.btn_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1265, 608);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Stock Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel_customer.ResumeLayout(false);
            this.panel_stocks.ResumeLayout(false);
            this.panel_sales.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_sales;
        private Guna.UI2.WinForms.Guna2Button btn_invoice;
        private Guna.UI2.WinForms.Guna2Button btn_estimate;
        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_sales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_stocks;
        private Guna.UI2.WinForms.Guna2Button btn_inventory;
        private Guna.UI2.WinForms.Guna2Button btn_adprducts;
        private Guna.UI2.WinForms.Guna2Button btn_stocks;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_username;
        private Guna.UI2.WinForms.Guna2Button btn_breakdown;
        private System.Windows.Forms.Panel panel_customer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_newCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button bnt_customer;
        private Guna.UI2.WinForms.Guna2Button btn_estimateReport;
        private Guna.UI2.WinForms.Guna2Button btn_invoiceReport;
        private Guna.UI2.WinForms.Guna2Button btn_home;
    }
}