using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockControl
{
    public partial class EstimateReport : Form
    {
        public static EstimateReport instance;
        public EstimateReport()
        {
            InitializeComponent();
            instance = this;
        }
        public void DataLoad() {
            {
                tbl_estimates.DataSource = getProduct();

            }
            DataTable getProduct()
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                DataTable dtCompany = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT DATE as 'ESTIMATED DATE', COMPANY, ESTIMATE_ID as 'ESTIMATE NO',  CUSTOMER , DEVICE, SERIAL_NUMBER as 'SERIAL NUMBER', NET_PRICE as 'ESIMATED VALUE' FROM Estimate", conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtCompany.Load(reader);
                return dtCompany;
            }

        }
        public void Customdatagrid() {

            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            Color color2 = ColorTranslator.FromHtml("#008000");
            Color color3 = ColorTranslator.FromHtml("#ff0000");
            tbl_estimates.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_estimates.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_estimates.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_estimates.RowsDefaultCellStyle.BackColor = color1;

            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "View";
            tbl_estimates.Columns.Add(col2);

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.HeaderText = "STATUS";
            col.Name = "STATUS";
            col.Text = "Approve";
            
            tbl_estimates.Columns.Add(col);

            tbl_estimates.Columns[0].Width = 43;
            tbl_estimates.Columns[1].Width = 75;
            tbl_estimates.Columns[2].Width = 35;
            tbl_estimates.Columns[3].Width = 100;
            tbl_estimates.Columns[4].Width = 75;
            tbl_estimates.Columns[5].Width = 75;
            tbl_estimates.Columns[6].Width = 50;
            tbl_estimates.Columns[7].Width = 25;
            tbl_estimates.Columns[8].Width = 50; 

        }
        private void EstimateReport_Load(object sender, EventArgs e)
        {          
            DataLoad();
            Customdatagrid();
        }
        public void CellContentAction() {

            if (tbl_estimates.SelectedCells.Count > 0)
            {
                int selectedrowindex = tbl_estimates.SelectedCells[0].RowIndex;
                int selectedrowindex1 = tbl_estimates.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = tbl_estimates.Rows[selectedrowindex];
                DataGridViewRow selectedRow1 = tbl_estimates.Rows[selectedrowindex1];

                string cellValue = Convert.ToString(selectedRow.Cells["Estimate No"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["COMPANY"].Value);
                string cellbutton = Convert.ToString(selectedRow1.Cells["STATUS"].Value);


                if (tbl_estimates.CurrentCell.ColumnIndex == 0 && cellValue1 == "Timeco Solutions Pvt.Ltd")
                {
                    EstimateViewerTimeco estimateViewer = new EstimateViewerTimeco();
                    estimateViewer.Show();
                    EstimateViewerTimeco.instance.estimateid.Text = cellValue;
                }
                else if (tbl_estimates.CurrentCell.ColumnIndex == 0 && cellValue1 == "Ekrain Holdings")
                {
                    EstimateViewer estimateViewer = new EstimateViewer();
                    estimateViewer.Show();
                    EstimateViewer.instance.estimateid.Text = cellValue;
                }
                if (tbl_estimates.CurrentCell.ColumnIndex == 1 && cellbutton == "Approve")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                    SqlDataAdapter da = new SqlDataAdapter("Select ESTIMATE_ID From Estimate_approved  where ESTIMATE_ID = '" + cellValue + "' ", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Already approved");
                    }
                    else
                    {

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve the estimate?", "Estimate", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Estimate_approved SELECT * FROM Estimate WHERE ESTIMATE_ID = '" + cellValue + "'", conn);
                            //SqlCommand cmd = new SqlCommand("INSERT INTO Estimate_approved SELECT ESTIMATE_ID, CUSTOMER,DELIVER_ADDRESS,BILLING_ADDRESS,DEVICE,SERIAL_NUMBER,DATE,SUBTOTAL,DISCOUNT,TAX,NET_PRICE,COMPANY FROM Estimate WHERE ESTIMATE_ID = '" + cellValue + "'", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Estimate has been approved");
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }

                }
            }
        }
        private void tbl_estimates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentAction();
        }
        public void SearchEstimate()
        {
           

        }
        public void SearchByCustoemrName() {          
            SqlDataAdapter adapt;
            DataTable dt;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

            conn.Open();
            adapt = new SqlDataAdapter("SELECT DATE, COMPANY, ESTIMATE_ID as 'ESTIMATE NO',  CUSTOMER , DEVICE, SERIAL_NUMBER as 'SERIAL NUMBER', NET_PRICE as 'ESIMATED VALUE' FROM Estimate product where CUSTOMER like '" + txt_search.Text + "%'  ", conn);

            dt = new DataTable();
            adapt.Fill(dt);
            tbl_estimates.DataSource = dt;
            conn.Close();



        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            SearchEstimate();


        }
    }
}
