namespace StockControl
{
    partial class EstimateViewer
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
            this.lbl_estimateID = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lbl_estimateID
            // 
            this.lbl_estimateID.AutoSize = true;
            this.lbl_estimateID.Location = new System.Drawing.Point(12, 38);
            this.lbl_estimateID.Name = "lbl_estimateID";
            this.lbl_estimateID.Size = new System.Drawing.Size(0, 16);
            this.lbl_estimateID.TabIndex = 4;
            this.lbl_estimateID.Visible = false;
            this.lbl_estimateID.TextChanged += new System.EventHandler(this.lbl_estimateID_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockControl.Estimate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "D:\\\\Projects\\StockControl\\StockControl\\Estimate.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(821, 730);
            this.reportViewer1.TabIndex = 0;
            // 
            // EstimateViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 730);
            this.Controls.Add(this.lbl_estimateID);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EstimateViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstimateViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstimateViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lbl_estimateID;
    }
}