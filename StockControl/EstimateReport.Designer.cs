namespace StockControl
{
    partial class EstimateReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbl_estimates = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_estimateReport = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_estimates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbl_estimates);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 584);
            this.panel1.TabIndex = 0;
            // 
            // tbl_estimates
            // 
            this.tbl_estimates.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbl_estimates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_estimates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_estimates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_estimates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_estimates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_estimates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_estimates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_estimates.ColumnHeadersHeight = 41;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_estimates.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbl_estimates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_estimates.EnableHeadersVisualStyles = false;
            this.tbl_estimates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_estimates.Location = new System.Drawing.Point(0, 0);
            this.tbl_estimates.Name = "tbl_estimates";
            this.tbl_estimates.ReadOnly = true;
            this.tbl_estimates.RowHeadersVisible = false;
            this.tbl_estimates.RowHeadersWidth = 51;
            this.tbl_estimates.RowTemplate.Height = 41;
            this.tbl_estimates.RowTemplate.ReadOnly = true;
            this.tbl_estimates.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_estimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_estimates.Size = new System.Drawing.Size(1143, 584);
            this.tbl_estimates.TabIndex = 24;
            this.tbl_estimates.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tbl_estimates.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_estimates.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbl_estimates.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbl_estimates.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbl_estimates.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbl_estimates.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_estimates.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbl_estimates.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbl_estimates.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_estimates.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tbl_estimates.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbl_estimates.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbl_estimates.ThemeStyle.HeaderStyle.Height = 41;
            this.tbl_estimates.ThemeStyle.ReadOnly = true;
            this.tbl_estimates.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbl_estimates.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_estimates.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tbl_estimates.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tbl_estimates.ThemeStyle.RowsStyle.Height = 41;
            this.tbl_estimates.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbl_estimates.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tbl_estimates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_estimates_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.AutoRoundedCorners = true;
            this.txt_search.BorderRadius = 19;
            this.txt_search.BorderThickness = 0;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.Parent = this.txt_search;
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.FocusedState.Parent = this.txt_search;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.HoverState.Parent = this.txt_search;
            this.txt_search.IconLeft = global::StockControl.Properties.Resources.search;
            this.txt_search.Location = new System.Drawing.Point(12, 71);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.ShadowDecoration.Parent = this.txt_search;
            this.txt_search.Size = new System.Drawing.Size(447, 40);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_estimateReport
            // 
            this.btn_estimateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_estimateReport.AutoRoundedCorners = true;
            this.btn_estimateReport.BorderRadius = 19;
            this.btn_estimateReport.CheckedState.Parent = this.btn_estimateReport;
            this.btn_estimateReport.CustomImages.Parent = this.btn_estimateReport;
            this.btn_estimateReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_estimateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estimateReport.ForeColor = System.Drawing.Color.White;
            this.btn_estimateReport.HoverState.Parent = this.btn_estimateReport;
            this.btn_estimateReport.Location = new System.Drawing.Point(879, 71);
            this.btn_estimateReport.Name = "btn_estimateReport";
            this.btn_estimateReport.ShadowDecoration.Parent = this.btn_estimateReport;
            this.btn_estimateReport.Size = new System.Drawing.Size(246, 40);
            this.btn_estimateReport.TabIndex = 22;
            this.btn_estimateReport.Text = "Estimte Report";
            // 
            // EstimateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1167, 725);
            this.Controls.Add(this.btn_estimateReport);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstimateReport";
            this.Text = "EstimateReport";
            this.Load += new System.EventHandler(this.EstimateReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_estimates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView tbl_estimates;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_estimateReport;
    }
}