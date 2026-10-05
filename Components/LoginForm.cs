using Register_Login_System.Components;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace Register_Login_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Nhập tên tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                var thongTinTaiKhoan = await DatabaseAccess.LayThongTinDangNhapAsync(txtUsername.Text);
                bool loginSuccess = false;

                if (thongTinTaiKhoan != null)
                {
                    loginSuccess = MatKhau.KiemTra(txtPassword.Text, thongTinTaiKhoan.Value.Salt, thongTinTaiKhoan.Value.MatKhauBam);
                }

                if (loginSuccess)
                {
                    this.Hide();

                    // Truyền đủ 3 tham số: Họ tên, Tên đăng nhập, Email vào MainApplication
                    using (var app = new MainApplication(
                        thongTinTaiKhoan.Value.HoTen,
                        txtUsername.Text,
                        thongTinTaiKhoan.Value.Email))
                    {
                        app.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (RegisterForm regForm = new RegisterForm())
            {
                regForm.ShowDialog();

                if (regForm.exitRequest)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (PasswordRecovery passRec = new PasswordRecovery())
            {
                passRec.ShowDialog();

                if (passRec.exitRequest)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}