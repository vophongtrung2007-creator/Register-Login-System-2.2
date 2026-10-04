namespace Register_Login_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbRegister = new Label();
            lklbRegister = new LinkLabel();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(229, 122);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(110, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên đăng nhập:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(229, 188);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(337, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(337, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(240, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Location = new Point(337, 296);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(135, 20);
            lbRegister.TabIndex = 4;
            lbRegister.Text = "Chưa có tài khoản?";
            // 
            // lklbRegister
            // 
            lklbRegister.AutoSize = true;
            lklbRegister.Location = new Point(478, 296);
            lklbRegister.Name = "lklbRegister";
            lklbRegister.Size = new Size(99, 20);
            lklbRegister.TabIndex = 5;
            lklbRegister.TabStop = true;
            lklbRegister.Text = "Tạo tài khoản";
            lklbRegister.LinkClicked += lklbRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(337, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(461, 162);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(lklbRegister);
            Controls.Add(lbRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbRegister;
        private LinkLabel lklbRegister;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}
