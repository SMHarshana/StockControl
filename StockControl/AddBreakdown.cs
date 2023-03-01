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
    public partial class AddBreakdown : Form
    {
        public AddBreakdown()
        {
            InitializeComponent();
        }
        public void AddBreakdowns()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("Insert into breakdown(CUSTOMER, DEVICE, SERIAL_NO, RECEIVE_METHOD, RECEIVED_BY,RECEIVED_DATE, ISSUE )Values(@customer,@device,@serial_no ,@received_method, @received_by, @received_date, @issue)", conn);

                cmd.Parameters.AddWithValue("@customer", cmb_customer.Text);
                cmd.Parameters.AddWithValue("@device", cmb_device.Text);
                cmd.Parameters.AddWithValue("@serial_no", txt_serialNo.Text);
                cmd.Parameters.AddWithValue("@received_method", txt_recivedMethod.Text);
                cmd.Parameters.AddWithValue("@received_by", txt_recivedBy.Text);
                cmd.Parameters.AddWithValue("@received_date", txt_date.Text);
                cmd.Parameters.AddWithValue("@issue", txt_issue.Text);               

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Braekdown Saved");
            }
            catch (Exception) {
                throw;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            AddBreakdowns();
           
        }
        void fillCustomerCombo()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                string query = "select CUSTOMER_NAME from customer";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                cmb_customer.ValueMember = "CUSTOMER_NAME";
                cmb_customer.DataSource = ds.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCustomerID()
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select CUSTOMER_ID from customer where CUSTOMER_NAME = '" + cmb_customer.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {

                    String CustomerId;
                    CustomerId = dr["CUSTOMER_ID"].ToString();                  
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("select distinct DEVICE from customer_device where MASTER_ID = '" + CustomerId + "'", conn);
                        DataTable dt1 = new DataTable();
                        sda.Fill(dt1);
                        cmb_device.Items.Clear();
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            cmb_device.Items.Add(dr1["DEVICE"].ToString());
                        }

                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void fillCombo() {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        
        }
        private void AddBreakdown_Load(object sender, EventArgs e)
        {
           fillCustomerCombo();
          

        }
        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustomerID();
        }

        public void getSerialNumber()
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select SERIAL_NO from customer_device where DEVICE = '" + cmb_device.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txt_serialNo.Text = dr["SERIAL_NO"].ToString();


                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
            private void cmb_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSerialNumber();
        }
    }
}
