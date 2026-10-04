namespace Register_Login_System
{
    partial class PasswordRecovery
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
            label1 = new Label();
            label2 = new Label();
            txtOTP = new TextBox();
            btnOTP = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            lbConfirmPassword = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            btnSave = new Button();
            btnReturn = new Button();
            btnVerifyOTP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 90);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // btnVerifyOTP
            // 
            btnVerifyOTP.Location = new Point(469, 175);
            btnVerifyOTP.Name = "btnVerifyOTP";
            btnVerifyOTP.Size = new Size(114, 29);
            btnVerifyOTP.TabIndex = 21;
            btnVerifyOTP.Text = "Xác nhận OTP";
            btnVerifyOTP.UseVisualStyleBackColor = true;
            btnVerifyOTP.Click += btnVerifyOTP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 139);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "OTP:";
            // 
            // txtOTP
            // 
            txtOTP.Location = new Point(278, 136);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(171, 27);
            txtOTP.TabIndex = 3;
            txtOTP.TextChanged += txtOTP_TextChanged;
            // 
            // btnOTP
            // 
            btnOTP.Location = new Point(469, 136);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(96, 29);
            btnOTP.TabIndex = 4;
            btnOTP.Text = "Gửi mã OTP";
            btnOTP.UseVisualStyleBackColor = true;
            btnOTP.Click += btnOTP_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(278, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 176);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(278, 269);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(287, 27);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(139, 276);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(133, 20);
            lbConfirmPassword.TabIndex = 17;
            lbConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(278, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(199, 214);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 15;
            lbPassword.Text = "Mật khẩu:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 40);
            btnSave.TabIndex = 19;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(451, 321);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(114, 40);
            btnReturn.TabIndex = 20;
            btnReturn.Text = "Hủy";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // PasswordRecovery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(btnOTP);
            Controls.Add(txtOTP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVerifyOTP);
            Name = "PasswordRecovery";
            Text = "PasswordRecovery";
            Load += PasswordRecovery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOTP;
        private Button btnOTP;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label lbConfirmPassword;
        private TextBox txtPassword;
        private Label lbPassword;
        private Button btnSave;
        private Button btnReturn;

        private Button btnVerifyOTP;
    }
}