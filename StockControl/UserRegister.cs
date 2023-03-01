using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StockControl
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Hide();
        }
        private string code;
        public void GenerateVerificationCode()
        {

            try
            {
                Random generator = new Random();
                code = generator.Next(0, 1000000).ToString("D6");

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("furypie.com@gmail.com", "smuh93103"),
                    EnableSsl = true
                };
                client.Send(txt_email.Text, txt_email.Text, "Verification Code", "Your verification code is: " + code.ToString());

                lbl_msg.ForeColor = Color.LimeGreen;
            }
            catch (Exception ) {
                throw;                
            }
           
        }
        public void Verification() {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select USERNAME From tb_user  where USERNAME = '" + txt_username.Text + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                SqlDataAdapter da1 = new SqlDataAdapter("Select USERNAME From tb_user  where EMAIL = '" + txt_email.Text + "' ", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                if (dt.Rows.Count >= 1)
                {
                    lbl_msg.Text = "Username already exist";
                    lbl_msg.ForeColor = Color.Red;
                    lbl_msg.Font = new Font("Microsoft Sans Serif", 10);
                }

                else if (dt1.Rows.Count >= 1)
                {
                    lbl_msg.Text = "Email address already exist";
                    lbl_msg.ForeColor = Color.Red;
                    lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                }
                else
                {
                    {
                        
                        if (txt_username.Text != "" || txt_password.Text != "" || txt_confirmPassword.Text != "" || txt_email.Text != "")
                        {
                            if (txt_password.Text.Length >= 6)
                            {
                                if (txt_password.Text == txt_confirmPassword.Text)

                                {
                                    if (txt_username.Text != "")

                                    {
                                        if (txt_email.Text != "")

                                        {
                                            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                                            if (Regex.IsMatch(txt_email.Text, pattern))
                                            {
                                                string pattern1 = @"^([^\s]{3,16})$";
                                                if (Regex.IsMatch(txt_username.Text, pattern1))
                                                {
                                                    GenerateVerificationCode();
                                                    lbl_confirm.Visible = true;
                                                    lbl_otp.Visible = true;
                                                    lbl_otp2.Visible = true;
                                                    lbl_resend.Visible = true;
                                                    txt_otp.Visible = true;
                                                    txt_otp.Text = "";

                                                    lbl_confirm.Enabled = true;
                                                    lbl_resend.Enabled = true;
                                                    lbl_otp.ForeColor = Color.Green;
                                                    lbl_otp.Text = "Verificaiton code has been sent to your email address please";
                                                    lbl_otp2.Text = "check your email.";
                                                    txt_otp.Enabled = true;
                                                   
                                                    txt_otp.PlaceholderText = "Verificatoin code";
                                                    lbl_confirm.Text = "Verify";
                                                    lbl_resend.Text = "Resend";
                                                    lbl_msg.Text = "";
                                                 
                                                    btn_register.Enabled = false;
                                                }
                                                else
                                                {
                                                    lbl_msg.Text = "Username sholud not have space";
                                                    lbl_msg.ForeColor = Color.Red;
                                                    lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                                                }
                                            }
                                            else
                                            {
                                                lbl_msg.Text = "Please enter valid email address";
                                                lbl_msg.ForeColor = Color.Red;
                                                lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                                            }
                                        }

                                        else
                                        {
                                            lbl_msg.Text = "Please enter your email address";
                                            lbl_msg.ForeColor = Color.Red;
                                            lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                                        }

                                    }
                                    else
                                    {
                                        lbl_msg.Text = "Please enter your username";
                                        lbl_msg.ForeColor = Color.Red;
                                        lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                                    }
                                }
                                else
                                {

                                    lbl_msg.Text = "Confirm password does not match";
                                    lbl_msg.ForeColor = Color.Red;
                                    lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                                }

                            }
                            else
                            {
                                lbl_msg.Text = "Password should have atleat 6 charanters";
                                lbl_msg.ForeColor = Color.Red;
                                lbl_msg.Font = new Font("Microsoft Sans Serif", 9);
                            }
                        }

                        else
                        {
                            lbl_msg.Text = "Please enter requred infromation to create an account";
                            lbl_msg.ForeColor = Color.Red;
                            lbl_msg.Font = new Font("Microsoft Sans Serif", 9);

                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;

            }

        }
        public void Register()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                String role = "User";
                SqlCommand cmd = new SqlCommand("Insert into tb_user(USERNAME, PASSWORD, EMAIL,USER_ROLE)Values(@username, @password, @email, @role)", conn);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@role", role);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            
                txt_username.Text = "";
                txt_password.Text = "";
                txt_confirmPassword.Text = "";
                txt_email.Text = "";
                lbl_msg.Text = "You have successfully created your account";
                lbl_msg.ForeColor = Color.Green;
                
            }
            catch (Exception) {
                throw;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_email.Text == "" && txt_password.Text == "" && txt_confirmPassword.Text == "")
            {

            }
            else {
                Verification();
            }
                              
        }
        
        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            lbl_msg.Text = "";
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            lbl_msg.Text = "";
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            lbl_msg.Text = "";
        }

        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            lbl_msg.Text = "";
        }

        private void lbl_confirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (code == txt_otp.Text)
            {
                Register();
                lbl_confirm.Enabled = false;
                lbl_resend.Enabled = false;             
                lbl_confirm.Visible = false;
                lbl_otp.Visible = false;
                lbl_otp2.Visible = false;
                lbl_resend.Visible = false;
                txt_otp.Visible=false;
                btn_register.Enabled = true;
            }
            else
            {
                lbl_otp.Text = "Invalid verification code";
                lbl_otp2.Text = "";
                lbl_otp.ForeColor = Color.Red;
            }

        }
        private void lbl_resend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateVerificationCode();
            lbl_confirm.Enabled = true;
            lbl_otp.Text = "Verificaiton code has been resent to your email address please";
            lbl_otp2.Text = "check your email.";
            lbl_otp.ForeColor = Color.Green;
            lbl_msg.Text = "";
        }
    }
}
