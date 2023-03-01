using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace StockControl
{
    public partial class AddProduct : Form
    {
        public static AddProduct instance;
        public AddProduct()
        {
            InitializeComponent();
            instance = this;

            BarcodeScanner barcodeScanner = new BarcodeScanner(txt_serialNo);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            txt_serialNo.Text = e.Barcode;
        }

        public void GetVluesFromCombo()
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product_category where MODEL = '" + cmb_model.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txt_brand.Text = dr["BRAND"].ToString();
                    txt_description.Text = dr["DESCRIPTION"].ToString();
                    txt_purchasePrice.Text = dr["PURCHASE_PRICE"].ToString();
                    txt_salePrice.Text = dr["SALE_PRICE"].ToString();
                }
                conn.Close();
            }
            catch (Exception) {

                throw;
            }
            
        }
        
        void fillCombo()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                string query = "select CATEGORY from Product_category";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Product_category");
                cmb_category.DisplayMember = "CATEGORY";
                cmb_category.DataSource = ds.Tables["Product_category"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
           // fillCombo();
        }

        private void cmb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVluesFromCombo();
        }
        public void addProduct() {

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                SqlDataAdapter da = new SqlDataAdapter("Select SERIAL_NUMBER From product where SERIAL_NUMBER = '" + txt_serialNo.Text + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmb_category.Text == "")
                {
                    MessageBox.Show("Please select the category");
                }
                else
                {
                    if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Serial Number allredy exist");
                }
                
                else
                    {

                        SqlCommand cmd = new SqlCommand("Insert into product(CATEGORY, MODEL,SERIAL_NUMBER, BRAND, DESCRIPTION,PURCHASE_PRICE, SALE_PRICE, DATE)Values(@category,@model,@serial_number, @brand, @description, @purchseprice, @saleprice,@date)", conn);

                        cmd.Parameters.AddWithValue("@category", cmb_category.Text);
                        cmd.Parameters.AddWithValue("@model", cmb_model.Text);
                        cmd.Parameters.AddWithValue("@serial_number", txt_serialNo.Text);
                        cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                        cmd.Parameters.AddWithValue("@description", txt_description.Text);
                        cmd.Parameters.AddWithValue("@purchseprice", txt_purchasePrice.Text);
                        cmd.Parameters.AddWithValue("@saleprice", txt_salePrice.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                } }
            catch (Exception)
            {
                throw;

            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            addProduct();
            Products.instance.dataLoad();

        }
        public void AutoSave() {
            if (tgl_autoSave.Checked) {               
                
                addProduct();

            }
        }
        public void fillDevice() {
            if (
                cmb_category.Text == "Spare Parts")
            {

                cmb_model.Items.Clear();
                cmb_model.DisplayMember = "Text";
                cmb_model.ValueMember = "Value";

                cmb_model.Items.Add(new { Text = "Fingerprint Sensor", Value = "1" });
                cmb_model.Items.Add(new { Text = "Display", Value = "2" });

            }
            if (cmb_category.Text == "Fingerprint Devices")
            {

                cmb_model.Items.Clear();
                cmb_model.DisplayMember = "Text";
                cmb_model.ValueMember = "Value";

                cmb_model.Items.Add(new { Text = "K30", Value = "1" });
                cmb_model.Items.Add(new { Text = "k50", Value = "2" });
                cmb_model.Items.Add(new { Text = "Icloak 880 WIFI/ ID", Value = "2" });
                cmb_model.Items.Add(new { Text = "Icloak 880 ID", Value = "2" });
                cmb_model.Items.Add(new { Text = "G3 Pro", Value = "2" });

            }
        }
        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDevice();
        }
    }
}
