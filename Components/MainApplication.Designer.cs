namespace Register_Login_System
{
    partial class MainApplication
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
            lblGreeting = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblLastLoginTime = new Label();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(12, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(776, 115);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "label1";
            lblGreeting.TextAlign = ContentAlignment.BottomLeft;
            lblGreeting.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 161);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "label2";
            lblUsername.Click += label2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // lblLastLoginTime
            // 
            lblLastLoginTime.AutoSize = true;
            lblLastLoginTime.ImageAlign = ContentAlignment.TopLeft;
            lblLastLoginTime.Location = new Point(12, 282);
            lblLastLoginTime.Name = "lblLastLoginTime";
            lblLastLoginTime.Size = new Size(50, 20);
            lblLastLoginTime.TabIndex = 3;
            lblLastLoginTime.Text = "label4";
            // 
            // MainApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLastLoginTime);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblGreeting);
            Name = "MainApplication";
            Text = "MainApplication";
            Load += MainApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreeting;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblLastLoginTime;
    }
}