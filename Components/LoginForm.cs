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

 
                if (thongTinTaiKhoan == null)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtUsername.Focus();
                    return;
                }


                bool loginSuccess = MatKhau.KiemTra(txtPassword.Text, thongTinTaiKhoan.Value.Salt, thongTinTaiKhoan.Value.MatKhauBam);

                if (loginSuccess)
                {
                    this.Hide();
                    string ngayDangXuatGanNhat = "Chưa có dữ liệu";

                    using (var app = new MainApplication(
                        txtUsername.Text,
                        txtUsername.Text,
                        thongTinTaiKhoan.Value.Email
                    ))
                    {
                        app.ShowDialog();
                    }

                    this.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                {

                    MessageBox.Show("Mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
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

                    if (!string.IsNullOrEmpty(regForm.RegisteredUsername))
                    {
                        txtUsername.Text = regForm.RegisteredUsername;
                        txtPassword.Focus(); 
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}