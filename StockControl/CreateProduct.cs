using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockControl
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }
        public void CreateProducts() {

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into Product_category(CATEGORY, MODEL, BRAND, DESCRIPTION,PURCHASE_PRICE, SALE_PRICE, DATE)Values(@category,@model, @brand, @description, @purchseprice, @saleprice,@date)", conn);

                cmd.Parameters.AddWithValue("@category", cmb_category.Text);
                cmd.Parameters.AddWithValue("@model", cmb_model.Text);
                cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                cmd.Parameters.AddWithValue("@description", txt_description.Text);
                cmd.Parameters.AddWithValue("@purchseprice", txt_purchasePrice.Text);
                cmd.Parameters.AddWithValue("@saleprice", txt_salePrice.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product Category saved");
  
            }
            catch (Exception)
            {
                throw;

            }
        
    }
        public void fillModel() {
            if (
                cmb_category.Text == "Spare Parts") {

                cmb_model.Items.Clear();
                cmb_model.DisplayMember = "Text";
                cmb_model.ValueMember = "Value";

                cmb_model.Items.Add(new { Text = "Fingerprint Sensor", Value = "1" });
                cmb_model.Items.Add(new { Text = "Display", Value = "2" });
                
            }
            if (cmb_category.Text == "Fingerprint Devices") {

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
        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateProducts();
        }

        private void cmb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // fillModel();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void cmb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            fillModel();
        }
    }
}
