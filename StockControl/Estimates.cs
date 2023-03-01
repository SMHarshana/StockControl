using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockControl
{
    public partial class Estimates : Form
    {
        public static Estimates instance;
        public Estimates()
        {
            InitializeComponent();
            instance = this;
            
        }
        public void dataLoad() {
            cmb_company.Text = "---Select Company---";

            if (check_discount.Checked)
            {
                txt_discount.Enabled = true;
                txt_discount.Visible = true;
            }
            else
            {
                txt_discount.Enabled = false;
                txt_discount.Visible = false;
            }
            if (check_tax.Checked)
            {
                txt_tax.Enabled = true;
                txt_tax.Visible = true;
            }
            else
            {
                txt_tax.Enabled = false;
                txt_tax.Visible = false;
            }

            {
                tbl_product.DataSource = getProduct();

            }
            DataTable getProduct()
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                DataTable dtCompany = new DataTable();          
                SqlCommand cmd = new SqlCommand("SELECT ID as '#',  SERIAL_NUMBER as 'SERIAL NUMBER', DESCRIPTION, SALE_PRICE as 'PRICE (LKR)' FROM product WHERE CATEGORY IN( SELECT CATEGORY FROM product GROUP BY CATEGORY HAVING COUNT(*) > 1) ", conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtCompany.Load(reader);
                return dtCompany;
            }
        }
        public void CustomDataDrid()
        {
            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_product.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_product.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_product.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_product.RowsDefaultCellStyle.BackColor = color1;

            Color color2 = ColorTranslator.FromHtml("#FFFFFF");
            Color color3 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_checkout.ColumnHeadersDefaultCellStyle.BackColor = color2;
            tbl_checkout.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_checkout.ColumnHeadersDefaultCellStyle.SelectionBackColor = color2;
            tbl_checkout.RowsDefaultCellStyle.BackColor = color3;


            tbl_product.Columns[0].Width = 50;
            tbl_product.Columns[1].Width = 120;
            tbl_product.Columns[2].Width = 200;
            tbl_product.Columns[3].Width = 90;

            tbl_checkout.Columns[0].Width = 25;
            tbl_checkout.Columns[1].Width = 120;
            tbl_checkout.Columns[2].Width = 100;
            tbl_checkout.Columns[3].Width = 50;
            tbl_checkout.Columns[4].Width = 30;
            tbl_checkout.Columns[5].Width = 50;
            tbl_checkout.Columns[6].Width = 35;
    
        }
        void fillCombo()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                string query = "select CUSTOMER from breakdown";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "breakdown");
                
                cmb_customer.ValueMember = "CUSTOMER";
                cmb_customer.DataSource = ds.Tables["breakdown"];

                cmb_customer.SelectedItem = null;
                cmb_customer.SelectedText = "--select--";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Estimates_Load(object sender, EventArgs e)
        {
            dataLoad();
            CustomDataDrid();
            fillCombo();
            this.tbl_checkout.Columns["Column2"].Visible = false;

        }
        private void Totalcal()
        {
            decimal s = 0, s1 = 0, s13 = 0;
            for (int j = 0; j < tbl_checkout.Rows.Count; ++j)
            {

                s = Convert.ToDecimal(tbl_checkout.Rows[j].Cells[3].Value);
                s1 = Convert.ToDecimal(tbl_checkout.Rows[j].Cells[4].Value);
                s13 = s * s1;
                tbl_checkout.Rows[j].Cells["Total"].Value = s13.ToString();

            }

        }
        public void Subtotal() {

            decimal sum = 0;
            for (int i = 0; i < tbl_checkout.Rows.Count; i++)

            {
                sum += decimal.Parse(tbl_checkout.Rows[i].Cells[5].Value.ToString());

            }
            lbl_subtotal.Text = sum.ToString();

        }
        private void tbl_product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in tbl_product.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.tbl_checkout.Rows.Add(rowData);
            }
            Totalcal();
            Subtotal();

            discount();
            tax();

        }

        private void tbl_checkout_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Totalcal();
            Subtotal();

            discount();
            tax();
        }

        private void tbl_checkout_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            tbl_checkout.Rows[e.RowIndex].Cells["Qty"].Value = 1;

        }

        private void tbl_checkout_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Totalcal();
            Subtotal();

        }
        public void discount() {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }

            decimal val1;
            val1 = Convert.ToDecimal(lbl_subtotal.Text);
            decimal percentage;
            percentage = Convert.ToDecimal(txt_discount.Text);
            decimal discount;
            discount = Convert.ToDecimal(val1 / 100) * percentage;
            lbl_discount.Text = "-" + discount.ToString();

            decimal priceAfterDicount;
            decimal discountval;
            decimal taxVal;

            discountval = Convert.ToDecimal(lbl_discount.Text);
            taxVal = Convert.ToDecimal(lbl_tax.Text);

            priceAfterDicount = val1 + discountval + taxVal;
            lbl_total.Text = priceAfterDicount.ToString();

        }
        public void tax() {

            if (txt_tax.Text == "")
            {
                txt_tax.Text = "0";
            }

            decimal val1;
            val1 = Convert.ToDecimal(lbl_subtotal.Text);
            decimal percentage;
            percentage = Convert.ToDecimal(txt_tax.Text);
            decimal tax;
            tax = Convert.ToDecimal(val1 / 100) * percentage;
            lbl_tax.Text = tax.ToString();

            decimal priceAfterDicount;
            decimal discountval;
            decimal taxVal;

            discountval = Convert.ToDecimal(lbl_discount.Text);
            taxVal = Convert.ToDecimal(lbl_tax.Text);

            priceAfterDicount = val1 + discountval + taxVal;
            lbl_total.Text = priceAfterDicount.ToString();

        }
        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            discount();
            tax();
        }

        private void txt_tax_TextChanged(object sender, EventArgs e)
        {
            tax();
            discount();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public void saveEstimateData()
        {
            //Getting Customer mobile number from customer tabale
            String mobileNo;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MOBILE FROM customer where CUSTOMER_NAME = '" + cmb_customer.Text.ToString() + "'";

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                mobileNo = sdr["MOBILE"].ToString();
                
            }
            conn.Close();

            if (tbl_checkout.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to proceed checkout");

            }
            else
            {
                if (cmb_customer.Text == "")
                {
                    MessageBox.Show("Please select customer before checking out");
                }
                else
                {
                    if (cmb_device.Text == "")
                    {
                        MessageBox.Show("Please select device before checking out");
                    }
                    else

                    {
                        if (txt_serialNo.Text == "")
                        {
                            MessageBox.Show("Please add Serial number before checking out");
                        }
                        else
                        {
                            try
                            {

                                SqlCommand command = conn.CreateCommand();

                                conn.Open();
                                command.CommandText = "Insert into Estimate(CUSTOMER,DELIVER_ADDRESS,BILLING_ADDRESS, DEVICE,SERIAL_NUMBER, DATE, SUBTOTAL,DISCOUNT, TAX, NET_PRICE,COMPANY,PHONE_NO)Values(@customer,@deliverAddress,@billingAddress,@device,@serial_number, @date, @subtotal, @discount, @tax,@net_price,@company,@phoneNo)select scope_identity()";

                                command.Parameters.AddWithValue("@customer", cmb_customer.Text);
                                command.Parameters.AddWithValue("@deliverAddress", lbl_deliver.Text + lbl_deliver1.Text + lbl_deliver2.Text);
                                command.Parameters.AddWithValue("@billingAddress", lbl_billing.Text + lbl_billing1.Text + lbl_billing2.Text);
                                command.Parameters.AddWithValue("@device", cmb_device.Text);
                                command.Parameters.AddWithValue("@serial_number", txt_serialNo.Text);
                                command.Parameters.AddWithValue("@date", DateTime.Now);
                                command.Parameters.AddWithValue("@subtotal", lbl_subtotal.Text);
                                command.Parameters.AddWithValue("@discount", lbl_discount.Text);
                                command.Parameters.AddWithValue("@tax", lbl_tax.Text);
                                command.Parameters.AddWithValue("@net_price",lbl_total.Text);
                                command.Parameters.AddWithValue("@company", cmb_company.Text);
                                command.Parameters.AddWithValue("@phoneNo", mobileNo);
                                string ESTIMATE_ID = command.ExecuteScalar().ToString();

                                //MessageBox.Show(mobileNo);

                                for (int i = 0; i < tbl_checkout.Rows.Count; i++)
                                {
                                    command.CommandText = @"INSERT INTO estimate_products (MASTER_ID, DESCRIPTION, PRICE, QTY, NT_PRICE)VALUES('" + ESTIMATE_ID + "','" + tbl_checkout.Rows[i].Cells[2].Value + "', '" + tbl_checkout.Rows[i].Cells[3].Value + "','" + tbl_checkout.Rows[i].Cells[4].Value + "', '" + tbl_checkout.Rows[i].Cells[5].Value + "')";
                                    command.ExecuteNonQuery();
                                }
                                if (cmb_company.Text == "Ekrain Holdings")
                                {
                                    EstimateViewer estimateViewer = new EstimateViewer();
                                    estimateViewer.Show();
                                    EstimateViewer.instance.estimateid.Text = ESTIMATE_ID;
                                }
                                else if (cmb_company.Text == "Timeco Solutions Pvt.Ltd")
                                {
                                    EstimateViewerTimeco estimateViewer = new EstimateViewerTimeco();
                                    estimateViewer.Show();
                                    EstimateViewerTimeco.instance.estimateid.Text = ESTIMATE_ID;
                                }
                                else {
                                    MessageBox.Show("Please slect company");
                                    

                                }

                                conn.Close();
                                                          
                               
                            }
                            catch (Exception)
                            {

                                throw;
                            }

                        }
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
           saveEstimateData();
            
        }
        public void getValuesFromCombo() {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ADDRESS1, ADDRESS2, ADDRESS3 from customer where CUSTOMER_NAME = '" + cmb_customer.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    lbl_deliver.Text = dr["ADDRESS1" ].ToString() + " ,";
                    lbl_deliver1.Text = dr["ADDRESS2"].ToString() + " ,";
                    lbl_deliver2.Text = dr["ADDRESS3" ].ToString();

                    lbl_billing.Text = dr["ADDRESS1"].ToString() + " ,";
                    lbl_billing1.Text = dr["ADDRESS2"].ToString() + " ,";
                    lbl_billing2.Text = dr["ADDRESS3"].ToString();

                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void getSerialNumber() {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select SERIAL_NO from breakdown where DEVICE = '" + cmb_device.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txt_serialNo.Text = dr["SERIAL_NO"].ToString() ;
                   

                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void filterDevice() {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct DEVICE from breakdown where CUSTOMER = '"+cmb_customer.Text+"'",conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmb_device.Items.Clear();
                foreach (DataRow dr in dt.Rows) {
                    cmb_device.Items.Add(dr["DEVICE"].ToString());
                }

            }
            catch (Exception) {
                throw;
            }
        }
        
        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            getValuesFromCombo();
            filterDevice();
        }

        private void cmb_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSerialNumber();

        }
        
        private void tbl_checkout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbl_checkout.CurrentCell.ColumnIndex == 6)

            {

                this.tbl_checkout.Rows.RemoveAt(e.RowIndex);

            }
            Totalcal();
            Subtotal();

            discount();
            tax();
        }

        private void check_discount_CheckedChanged(object sender, EventArgs e)
        {
            if (check_discount.Checked)
            {
                txt_discount.Enabled = true;
                txt_discount.Visible = true;
                discount();
                tax();
            }
            else
            {
                txt_discount.Enabled = false;
                txt_discount.Visible=false;
                txt_discount.Text = "";
                discount();
                tax();
            }
            if (check_tax.Checked)
            {
                txt_tax.Enabled = true;
                txt_tax.Visible = true;
                discount();
                tax();
            }
            else
            {
                txt_tax.Enabled = false;
                txt_tax.Visible=false;
                txt_tax.Text = "";
                discount();
                tax();
            }
        }

        private void check_tax_CheckedChanged(object sender, EventArgs e)
        {
            if (check_discount.Checked)
            {
                txt_discount.Enabled = true;
                txt_discount.Visible = true;
            }
            else
            {
                txt_discount.Enabled = false;
                txt_discount.Visible = false;
            }
            if (check_tax.Checked)
            {
                txt_tax.Enabled = true;
                txt_tax.Visible = true;
            }
            else
            {
                txt_tax.Enabled = false;
                txt_tax.Visible = false;
            }
        }
        public void SearchProduct()
        {

          
            SqlDataAdapter adapt;
            DataTable dt;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
         
            conn.Open();
            adapt = new SqlDataAdapter("SELECT ID as '#',  SERIAL_NUMBER as 'SERIAL NUMBER', DESCRIPTION, SALE_PRICE as 'PRICE (LKR)' FROM product where DESCRIPTION like '" + txt_serach.Text + "%' ", conn);

            //SqlCommand cmd = new SqlCommand("SELECT ID as '#',  SERIAL_NUMBER as 'SERIAL NUMBER', DESCRIPTION, SALE_PRICE as 'PRICE (LKR)' FROM product WHERE CATEGORY IN( SELECT CATEGORY FROM product GROUP BY CATEGORY HAVING COUNT(*) > 1) ", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            tbl_product.DataSource = dt;
            conn.Close();


        }

        private void txt_serach_TextChanged(object sender, EventArgs e)
        {
            SearchProduct();
        }
    }
}
