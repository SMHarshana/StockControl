using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockControl
{
    public partial class Products : Form
    {
        public static Products instance;
        public Guna2DataGridView dataGridView;
        
        public Products()
        {
            InitializeComponent();
            instance = this;
            dataGridView = tbl_product;
        }

        private void btn_createProduct_Click(object sender, EventArgs e)
        {
            CreateProduct addProduct = new CreateProduct();
            addProduct.Visible = true;
            dataLoad();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Visible = true;
        }
        public void dataLoad()
        {
            {
                tbl_product.DataSource = getProduct();

            }
            DataTable getProduct()
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                DataTable dtCompany = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT ID as '#', MODEL, SERIAL_NUMBER as 'SERIAL NUMBER', DESCRIPTION, PURCHASE_PRICE as 'PURCHASE PRICE (LKR)', SALE_PRICE as 'SALE PRICE (LKR)' from product", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtCompany.Load(reader);
                return dtCompany;
                
            }

        }
        public void CustomDataDrid() {
            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_product.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_product.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_product.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_product.RowsDefaultCellStyle.BackColor = color1;
            
        }
        private void Products_Load(object sender, EventArgs e)
        {
            CustomDataDrid();
            dataLoad();
            tbl_product.Columns[0].Width = 50;
            tbl_product.Columns[1].Width = 100;
            tbl_product.Columns[2].Width = 90;
            tbl_product.Columns[3].Width = 200;
            tbl_product.Columns[4].Width = 90;
            tbl_product.Columns[5].Width = 90;
        }
    }
}
