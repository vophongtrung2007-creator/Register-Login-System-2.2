using Register_Login_System.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Register_Login_System
{
    public partial class PasswordRecovery : Form
    {   

        public PasswordRecovery()
        {
            InitializeComponent();
            btnReturn.Click += btnReturn_Click;
        }

        public bool exitRequest { get; private set; }
        public string otp = "";
        private DateTime otpGeneratedTime; 
        private string filepath = "users.json";
        private bool otpVerified;
        private string verifiedEmail = "";
        private int otpAttempts;
        private DateTime otpSentTime;
        private const int OtpValidityMinutes = 3;
        private const int MaxOtpAttempts = 5;
        private const int OtpResendCooldownSeconds = 60;

        private void PasswordRecovery_Load(object sender, EventArgs e)
        {
            txtPassword.Hide();
            txtConfirmPassword.Hide();
            lbPassword.Hide();
            lbConfirmPassword.Hide();
            btnSave.Hide();
        }


        private void btnOTP_Click(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmail.Text.Trim();

            if (otpSentTime != default && DateTime.Now - otpSentTime < TimeSpan.FromSeconds(OtpResendCooldownSeconds))
            {
                var remainingSeconds = (int)Math.Ceiling((otpSentTime.AddSeconds(OtpResendCooldownSeconds) - DateTime.Now).TotalSeconds);
                MessageBox.Show($"Vui lòng đợi thêm {remainingSeconds} giây trước khi gửi mã mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s,]+@[^@\s,]+\.[^@\s,]+$"))
            {
                MessageBox.Show("Định dạng email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }

            if (!File.Exists(filepath))
            {
                MessageBox.Show("Dữ liệu người dùng chưa tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonContent = File.ReadAllText(filepath);
            List<Users> list = JsonSerializer.Deserialize<List<Users>>(jsonContent);
            bool emailExists = false;

            if (list != null)
            {
                foreach (var u in list)
                {
                    if (u.Email == txtEmail.Text)
                    {
                        emailExists = true;
                        break;
                    }
                }
            }

            if (!emailExists)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }

            // 1. Sinh ngẫu nhiên mã OTP gồm 6 chữ số

            Random rnd = new Random();
            otp = rnd.Next(100000, 999999).ToString();
            otpGeneratedTime = DateTime.Now;
            otpSentTime = DateTime.Now;
            otpAttempts = 0;
            otpVerified = false;
            verifiedEmail = "";

            btnVerifyOTP.Enabled = true;
            txtOTP.ReadOnly = false;
            txtOTP.Clear();
            MessageBox.Show($"[MOCK] Mã OTP của {txtEmail.Text} là: {otp}\nMã có hiệu lực trong vòng {OtpValidityMinutes} phút.", "OTP thử nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtOTP.Focus();
        }

        private void txtOTP_TextChanged(object sender, EventArgs e) {}

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text.Trim();
            txtConfirmPassword.Text = txtConfirmPassword.Text.Trim();

            if (!otpVerified)
            {
                MessageBox.Show("Vui lòng nhập đúng mã OTP.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOTP.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nhập mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (txtPassword.TextLength < 8)
            {
                MessageBox.Show("Mật khẩu phải dài hơn hoặc bằng 8 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (!File.Exists(filepath))
            {
                MessageBox.Show("Không tìm thấy dữ liệu người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonContent = File.ReadAllText(filepath);
            List<Users> list = JsonSerializer.Deserialize<List<Users>>(jsonContent);

            if (list == null)
            {
                MessageBox.Show("Dữ liệu người dùng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Users user = null;
            foreach (var u in list)
            {
                if (u.Email == verifiedEmail)
                {
                    user = u;
                    break;
                }
            }

            if (user == null)
            {
                MessageBox.Show("Email không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Password = txtPassword.Text;
            var option = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(filepath, JsonSerializer.Serialize(list, option));

            MessageBox.Show("Đổi mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            txtOTP.Text = txtOTP.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtOTP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã OTP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOTP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(otp))
            {
                MessageBox.Show("Vui lòng yêu cầu mã OTP mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOTP.Focus();
                return;
            }

            if (DateTime.Now - otpGeneratedTime > TimeSpan.FromMinutes(OtpValidityMinutes))
            {
                otp = "";
                otpVerified = false;
                MessageBox.Show("Mã OTP đã hết hạn. Vui lòng yêu cầu mã mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOTP.Clear();
                txtOTP.Focus();
                return;
            }

            if (txtOTP.Text == otp)
            {
                otpVerified = true;
                verifiedEmail = txtEmail.Text;
                otp = "";
                txtPassword.Show();
                txtConfirmPassword.Show();
                lbPassword.Show();
                lbConfirmPassword.Show();
                btnSave.Show();
                btnVerifyOTP.Enabled = false;
                txtOTP.ReadOnly = true;
                txtEmail.ReadOnly = true;
                MessageBox.Show("Mã OTP chính xác. Mời bạn đặt lại mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else
            {
                otpAttempts++;
                otpVerified = false;

                if (otpAttempts >= MaxOtpAttempts)
                {
                    otp = "";
                    btnVerifyOTP.Enabled = false;
                    MessageBox.Show("Bạn đã nhập sai OTP quá số lần cho phép. Vui lòng yêu cầu mã mới sau thời gian chờ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOTP.Clear();
                    return;
                }

                MessageBox.Show("Mã OTP không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOTP.Clear();
                txtOTP.Focus();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
