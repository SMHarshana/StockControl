namespace StockControl
{
    partial class EstimateViewerTimeco
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
            this.components = new System.ComponentModel.Container();
            this.lbl_estimateID = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estimatedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estimate_ds = new StockControl.Estimate_ds();
            this.DataTable_EstimateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.estimatedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimate_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_EstimateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_estimateID
            // 
            this.lbl_estimateID.AutoSize = true;
            this.lbl_estimateID.Location = new System.Drawing.Point(12, 38);
            this.lbl_estimateID.Name = "lbl_estimateID";
            this.lbl_estimateID.Size = new System.Drawing.Size(0, 16);
            this.lbl_estimateID.TabIndex = 6;
            this.lbl_estimateID.Visible = false;
            this.lbl_estimateID.TabIndexChanged += new System.EventHandler(this.lbl_estimateID_TabIndexChanged);
            this.lbl_estimateID.TextChanged += new System.EventHandler(this.lbl_estimateID_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockControl.EstimateTimeco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "D:\\\\Projects\\StockControl\\StockControl\\Estimate.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(795, 683);
            this.reportViewer1.TabIndex = 5;
            // 
            // estimatedsBindingSource
            // 
            this.estimatedsBindingSource.DataSource = this.estimate_ds;
            this.estimatedsBindingSource.Position = 0;
            // 
            // estimate_ds
            // 
            this.estimate_ds.DataSetName = "Estimate_ds";
            this.estimate_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_EstimateBindingSource
            // 
            this.DataTable_EstimateBindingSource.DataMember = "DataTable_Estimate";
            this.DataTable_EstimateBindingSource.DataSource = this.estimate_ds;
            // 
            // EstimateViewerTimeco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 683);
            this.Controls.Add(this.lbl_estimateID);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EstimateViewerTimeco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstimateViewerTimeco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstimateViewerTimeco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estimatedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimate_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_EstimateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estimateID;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estimatedsBindingSource;
        private Estimate_ds estimate_ds;
        private System.Windows.Forms.BindingSource DataTable_EstimateBindingSource;
    }
}