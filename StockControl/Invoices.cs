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
    public partial class Invoices : Form
    {
        public static Invoices instance;
        public Invoices()
        {
            InitializeComponent();
            instance = this;
        }
        public void loadInvoiceData() {
            {
                tbl_invoice.DataSource = getProduct();

            }
            DataTable getProduct()
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                DataTable dtCompany = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT DATE as 'ESTIMATED DATE', COMPANY, ESTIMATE_ID as 'ESTIMATE NO',  CUSTOMER , DEVICE, SERIAL_NUMBER as 'SERIAL NUMBER', NET_PRICE as 'ESIMATED VALUE' FROM Estimate_approved", conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtCompany.Load(reader);
                return dtCompany;
            }

        }

        public void Customdatagrid()
        {

            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_invoice.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_invoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_invoice.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_invoice.RowsDefaultCellStyle.BackColor = color1;

           

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
           // col.Name = "Invoice";
            col.Text = "Invoice";

            tbl_invoice.Columns.Add(col);

            tbl_invoice.Columns[0].Width = 43;
            tbl_invoice.Columns[1].Width = 75;
            tbl_invoice.Columns[2].Width = 35;
            tbl_invoice.Columns[3].Width = 100;
            tbl_invoice.Columns[4].Width = 75;
            tbl_invoice.Columns[5].Width = 75;
            tbl_invoice.Columns[6].Width = 50;
            tbl_invoice.Columns[7].Width = 50;


        }
        private void Invoices_Load(object sender, EventArgs e)
        {
            loadInvoiceData();
            Customdatagrid();
        }
        public void CellContentAction() {
            if (tbl_invoice.SelectedCells.Count > 0)
            {
                int selectedrowindex = tbl_invoice.SelectedCells[0].RowIndex;
                int selectedrowindex1 = tbl_invoice.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = tbl_invoice.Rows[selectedrowindex];
                DataGridViewRow selectedRow1 = tbl_invoice.Rows[selectedrowindex1];

                string cellValue = Convert.ToString(selectedRow.Cells["Estimate No"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["COMPANY"].Value);
                //string cellbutton = Convert.ToString(selectedRow1.Cells["STATUS"].Value);


                if (tbl_invoice.CurrentCell.ColumnIndex == 0 && cellValue1 == "Timeco Solutions Pvt.Ltd")
                {
                    InvoiceViewer_Timeco estimateViewer = new InvoiceViewer_Timeco();
                    estimateViewer.Show();
                    InvoiceViewer_Timeco.instance.estimateid.Text = cellValue;
                }
                else if (tbl_invoice.CurrentCell.ColumnIndex == 0 && cellValue1 == "Ekrain Holdings")
                {
                    InvoiceViewerEkrain estimateViewer = new InvoiceViewerEkrain();
                    estimateViewer.Show();
                    InvoiceViewerEkrain.instance.estimateid.Text = cellValue;
                }
              
            }

        }
        private void tbl_invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentAction();
        }
    }
}
