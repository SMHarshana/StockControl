using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StockControl
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }
        public void AddValuesToGrid() {

            if (txt_deviceSerial.Text == "")
            {

            }
            else {
                bool Itemfound = false;
                if (tbl_devices.Rows.Count > 0)
                {
                    foreach (DataGridViewRow NewItem in tbl_devices.Rows)
                    {
                        if (Convert.ToString(NewItem.Cells[1].Value) == txt_deviceSerial.Text)
                        {
                            Itemfound = true;
                            MessageBox.Show("Serial number already exist");
                            break;
                        }
                        if (Convert.ToString(NewItem.Cells[0].Value) == cmb_device.Text + "_" + txt_devNo.Text)
                        {
                            Itemfound = true;
                            MessageBox.Show("Device name already exist");
                            break;
                        }
                    }
                }
                if (Itemfound == false)
                {

                    string firstColum = cmb_device.Text+"_"+txt_devNo.Text;
                    string secondColum = txt_deviceSerial.Text;
                    string[] row = { firstColum, secondColum };
                    tbl_devices.Rows.Add(row);
                }
            }
           
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
             AddValuesToGrid();

        }
        public void CustomizeDataGrid() {
            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_devices.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_devices.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_devices.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_devices.RowsDefaultCellStyle.BackColor = color1;          
        }

        public void CustomDataDrid()
        {
            Color color = ColorTranslator.FromHtml("#CCD5F0");
            Color color1 = ColorTranslator.FromHtml("#F3F3F3");
            tbl_customer.ColumnHeadersDefaultCellStyle.BackColor = color;
            tbl_customer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tbl_customer.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            tbl_customer.RowsDefaultCellStyle.BackColor = color1;
            tbl_customer.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        public void DataLoad() {
            {
                tbl_customer.DataSource = getProduct();

            }
            DataTable getProduct()
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

                DataTable dtCompany = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT CUSTOMER_ID as 'CUSTOMER ID', CUSTOMER_NAME as 'CUSTOMER NAME', SA_START_DATE as 'SERVICE AGREEMENT START', SA_END_DATE as 'SERVICE AGREEMENT END' from customer", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtCompany.Load(reader);
                return dtCompany;

            }

        }
        private void NewCustomer_Load(object sender, EventArgs e)
        {
            CustomizeDataGrid();
            CustomDataDrid();
            DataLoad();
            tbl_customer.Columns[0].Width = 50;
            tbl_customer.Columns[1].Width = 150;
            tbl_customer.Columns[2].Width = 100;
            tbl_customer.Columns[3].Width = 100;
        }
        public void SaveCustomer()
        {
            if (txt_customerName.Text == "")
            {
                MessageBox.Show("Please enter company name");
            }
            else
            {

                if (cmb_category.Text == "")
                {
                    MessageBox.Show("Please select category");
                }
                else
                {
                    if (txt_address1.Text == "")
                    {
                        MessageBox.Show("Please Please enter the address line 1");
                    }
                    else
                    {
                        if (txt_address2.Text == "")
                        {
                            MessageBox.Show("Please Please enter the address line 2");
                        }
                        else
                        {
                            if (txt_address3.Text == "")
                            {
                                MessageBox.Show("Please Please enter the address line 3");
                            }
                            else
                            {
                                if (txt_mobile.Text == "")
                                {
                                    MessageBox.Show("Please Please enter a phone number");
                                }
                                else
                                {

                                    if (txt_email.Text == "")
                                    {
                                        MessageBox.Show("Please Please enter an email address");
                                    }
                                    else
                                    {
                                        string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                                        if (Regex.IsMatch(txt_email.Text, pattern))
                                        {
                                            if (cmb_techOfficer.Text == "")
                                            {
                                                MessageBox.Show("Please select the technical offer");
                                            }
                                            else
                                            {
                                                if (tbl_devices.Rows.Count == 0)
                                                {
                                                    MessageBox.Show("Please add devices");
                                                }
                                                else
                                                {
                                                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                                                    try
                                                    {

                                                        SqlCommand command = conn.CreateCommand();

                                                        conn.Open();
                                                        command.CommandText = "Insert into customer(CUSTOMER_NAME,CATEGORY,ADDRESS1, ADDRESS2,ADDRESS3, MOBILE, EMAIL,SOFTWARE, TECHNICAL_OFFICER, INSTALLED_DATE,SA_START_DATE,SA_END_DATE,DATE)Values(@customer_name,@category,@address1,@address2,@address3, @mobile, @email, @software, @techOfficer,@installedDate, @sa_start_date, @sa_end_date, @date)select scope_identity()";

                                                        command.Parameters.AddWithValue("@customer_name", txt_customerName.Text);
                                                        command.Parameters.AddWithValue("@category", cmb_category.Text);
                                                        command.Parameters.AddWithValue("@address1", txt_address1.Text);
                                                        command.Parameters.AddWithValue("@address2", txt_address2.Text);
                                                        command.Parameters.AddWithValue("@address3", txt_address3.Text);
                                                        command.Parameters.AddWithValue("@mobile", txt_mobile.Text);
                                                        command.Parameters.AddWithValue("@email", txt_email.Text);
                                                        command.Parameters.AddWithValue("@software", txt_software.Text);
                                                        command.Parameters.AddWithValue("@techOfficer", cmb_techOfficer.Text);
                                                        command.Parameters.AddWithValue("@installedDate", txt_installedDate.Text).ToString();
                                                        command.Parameters.AddWithValue("@sa_start_date", Txt_SAStart.Text).ToString();
                                                        command.Parameters.AddWithValue("@sa_end_date", txt_SAEnd.Text).ToString();
                                                        command.Parameters.AddWithValue("@date", DateTime.Now);
                                                        string CUSTOMER_ID = command.ExecuteScalar().ToString();

                                                        for (int i = 0; i < tbl_devices.Rows.Count; i++)
                                                        {
                                                            command.CommandText = @"INSERT INTO customer_device (MASTER_ID, DEVICE, SERIAL_NO)VALUES('" + CUSTOMER_ID + "','" + tbl_devices.Rows[i].Cells[0].Value + "', '" + tbl_devices.Rows[i].Cells[1].Value + "')";
                                                            //conn.Open();
                                                            command.ExecuteNonQuery();
                                                            //conn.Close();
                                                        }

                                                        conn.Close();
                                                        //new Report.EstimateViewer(ESTIMATE_ID).Show();

                                                    }
                                                    catch (Exception)
                                                    {

                                                        throw;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter valid email address");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            DataLoad();
        }

    }
}
