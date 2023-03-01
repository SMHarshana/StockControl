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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void login() {

            try
            {
                String username = string.Empty;
                String password = string.Empty;

                username = txt_username.Text.Replace("'", "''");
                password = txt_password.Text.Replace("'", "''");

                string connection = string.Empty;


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = "select ID, USERNAME, PASSWORD, EMAIL, USER_ROLE from tb_user where USERNAME ='" + username + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][2].ToString() == password)
                        {
                            if (dt.Rows[0][4].ToString() == "Admin")
                            {
                                Main main = new Main();
                                main.Show();
                                this.Hide();    
                            }
                            if (dt.Rows[0][4].ToString() == "User")
                            {
                                Main main = new Main();
                                main.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            //lbl_msg.Text = "Invalid Password";
                            MessageBox.Show("Invalid Password");
                        }

                    }
                    else
                    {
                        //lbl_msg.Text = "Invalid user information";
                        MessageBox.Show("Invalid user information");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
      
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (txt_password.Text == "" && txt_username.Text == "")
            {
            }
            else {
                login();
            }
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            UserRegister reg = new UserRegister();
            reg.Visible = true; 
            this.Hide();

        }
    }
}
