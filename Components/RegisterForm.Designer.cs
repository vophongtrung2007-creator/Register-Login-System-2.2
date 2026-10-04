namespace Register_Login_System
{
    partial class RegisterForm
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            txtConfirmPassword = new TextBox();
            lbConfirmPassword = new Label();
            btnReturn = new Button();
            lbEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(419, 414);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 50);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(419, 272);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(298, 31);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(419, 204);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 31);
            txtUsername.TabIndex = 9;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(216, 276);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(90, 25);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Mật khẩu:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(216, 208);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(133, 25);
            lbUsername.TabIndex = 7;
            lbUsername.Text = "Tên đăng nhập:";
            lbUsername.Click += lbUsername_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(419, 345);
            txtConfirmPassword.Margin = new Padding(4, 4, 4, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(298, 31);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(216, 345);
            lbConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(160, 25);
            lbConfirmPassword.TabIndex = 13;
            lbConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(575, 414);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(142, 50);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Hủy";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnCancel_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(216, 141);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(58, 25);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(419, 138);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 31);
            txtEmail.TabIndex = 17;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(btnReturn);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            FormClosing += RegisterForm_FormClosing;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private TextBox txtConfirmPassword;
        private Label lbConfirmPassword;
        private Button btnReturn;
        private Label lbEmail;
        private TextBox txtEmail;
    }
}