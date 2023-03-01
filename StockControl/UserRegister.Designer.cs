namespace StockControl
{
    partial class UserRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_confirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txt_otp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_otp = new Guna.UI.WinForms.GunaLabel();
            this.lbl_confirm = new System.Windows.Forms.LinkLabel();
            this.lbl_otp2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_resend = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BorderThickness = 0;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.Parent = this.txt_username;
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.Parent = this.txt_username;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.HoverState.Parent = this.txt_username;
            this.txt_username.Location = new System.Drawing.Point(33, 85);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.SelectedText = "";
            this.txt_username.ShadowDecoration.Parent = this.txt_username;
            this.txt_username.Size = new System.Drawing.Size(420, 55);
            this.txt_username.TabIndex = 13;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.BorderThickness = 0;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(33, 152);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "Email";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(420, 55);
            this.txt_email.TabIndex = 14;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.BorderThickness = 0;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.Parent = this.txt_password;
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.Parent = this.txt_password;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.HoverState.Parent = this.txt_password;
            this.txt_password.Location = new System.Drawing.Point(32, 221);
            this.txt_password.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.SelectedText = "";
            this.txt_password.ShadowDecoration.Parent = this.txt_password;
            this.txt_password.Size = new System.Drawing.Size(420, 55);
            this.txt_password.TabIndex = 15;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.BorderThickness = 0;
            this.txt_confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirmPassword.DefaultText = "";
            this.txt_confirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmPassword.DisabledState.Parent = this.txt_confirmPassword;
            this.txt_confirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_confirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmPassword.FocusedState.Parent = this.txt_confirmPassword;
            this.txt_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txt_confirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmPassword.HoverState.Parent = this.txt_confirmPassword;
            this.txt_confirmPassword.Location = new System.Drawing.Point(32, 290);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '\0';
            this.txt_confirmPassword.PlaceholderText = "Confirm password";
            this.txt_confirmPassword.SelectedText = "";
            this.txt_confirmPassword.ShadowDecoration.Parent = this.txt_confirmPassword;
            this.txt_confirmPassword.Size = new System.Drawing.Size(420, 55);
            this.txt_confirmPassword.TabIndex = 18;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.txt_confirmPassword_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.AutoRoundedCorners = true;
            this.btn_register.BorderRadius = 24;
            this.btn_register.CheckedState.Parent = this.btn_register;
            this.btn_register.CustomImages.Parent = this.btn_register;
            this.btn_register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.HoverState.Parent = this.btn_register;
            this.btn_register.Location = new System.Drawing.Point(33, 547);
            this.btn_register.Name = "btn_register";
            this.btn_register.ShadowDecoration.Parent = this.btn_register;
            this.btn_register.Size = new System.Drawing.Size(420, 50);
            this.btn_register.TabIndex = 20;
            this.btn_register.Text = "Sign up";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BorderRadius = 24;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(197)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(33, 625);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(420, 50);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "Allready have an account";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbl_msg.Location = new System.Drawing.Point(29, 31);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 16);
            this.lbl_msg.TabIndex = 21;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // txt_otp
            // 
            this.txt_otp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_otp.BorderThickness = 0;
            this.txt_otp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_otp.DefaultText = "";
            this.txt_otp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_otp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_otp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_otp.DisabledState.Parent = this.txt_otp;
            this.txt_otp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_otp.Enabled = false;
            this.txt_otp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txt_otp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_otp.FocusedState.Parent = this.txt_otp;
            this.txt_otp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_otp.ForeColor = System.Drawing.Color.Black;
            this.txt_otp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_otp.HoverState.Parent = this.txt_otp;
            this.txt_otp.Location = new System.Drawing.Point(34, 440);
            this.txt_otp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.PasswordChar = '\0';
            this.txt_otp.PlaceholderText = "";
            this.txt_otp.SelectedText = "";
            this.txt_otp.ShadowDecoration.Parent = this.txt_otp;
            this.txt_otp.Size = new System.Drawing.Size(218, 33);
            this.txt_otp.TabIndex = 22;
            this.txt_otp.Visible = false;
            this.txt_otp.WordWrap = false;
            // 
            // lbl_otp
            // 
            this.lbl_otp.AutoSize = true;
            this.lbl_otp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.lbl_otp.Location = new System.Drawing.Point(29, 392);
            this.lbl_otp.Name = "lbl_otp";
            this.lbl_otp.Size = new System.Drawing.Size(0, 20);
            this.lbl_otp.TabIndex = 23;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.Location = new System.Drawing.Point(29, 488);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(0, 23);
            this.lbl_confirm.TabIndex = 24;
            this.lbl_confirm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_confirm_LinkClicked);
            // 
            // lbl_otp2
            // 
            this.lbl_otp2.AutoSize = true;
            this.lbl_otp2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.lbl_otp2.Location = new System.Drawing.Point(30, 412);
            this.lbl_otp2.Name = "lbl_otp2";
            this.lbl_otp2.Size = new System.Drawing.Size(0, 20);
            this.lbl_otp2.TabIndex = 25;
            // 
            // lbl_resend
            // 
            this.lbl_resend.AutoSize = true;
            this.lbl_resend.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resend.Location = new System.Drawing.Point(357, 488);
            this.lbl_resend.Name = "lbl_resend";
            this.lbl_resend.Size = new System.Drawing.Size(0, 23);
            this.lbl_resend.TabIndex = 26;
            this.lbl_resend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_resend_LinkClicked);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(482, 703);
            this.Controls.Add(this.lbl_resend);
            this.Controls.Add(this.lbl_otp2);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.lbl_otp);
            this.Controls.Add(this.txt_otp);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_confirmPassword;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label lbl_msg;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaLabel lbl_otp;
        private Guna.UI2.WinForms.Guna2TextBox txt_otp;
        private System.Windows.Forms.LinkLabel lbl_confirm;
        private Guna.UI.WinForms.GunaLabel lbl_otp2;
        private System.Windows.Forms.LinkLabel lbl_resend;
    }
}