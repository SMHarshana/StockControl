﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class EstimateViewerTimeco : Form
    {
        public static EstimateViewerTimeco instance;
        public Label estimateid;
        public EstimateViewerTimeco()
        {
            InitializeComponent();
            instance = this;
            estimateid = lbl_estimateID;
        }

        public void ViewEstimateReport()
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = @"D:\Projects\StockControl\StockControl\EstimateTimeco.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);


            SqlDataAdapter da = new SqlDataAdapter("select * from Estimate_view where ESTIMATE_ID = '" + lbl_estimateID.Text + "'", conn);
            Estimate_ds ds = new Estimate_ds();
            da.Fill(ds, "DataTable_Estimate");

            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }

        private void lbl_estimateID_TabIndexChanged(object sender, EventArgs e)
        {
            ViewEstimateReport();
        }

        private void EstimateViewerTimeco_Load(object sender, EventArgs e)
        {

        }

        private void lbl_estimateID_TextChanged(object sender, EventArgs e)
        {
            ViewEstimateReport();
        }
    }
}