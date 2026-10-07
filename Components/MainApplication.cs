using System;
using System.Windows.Forms;

namespace Register_Login_System
{
    public partial class MainApplication : Form
    {
        private void MainApplication_Load(object sender, EventArgs e)
        {
        }
        public MainApplication(string hoTen, string username, string email, DateTime? lanDangNhapCuoi)
        {
            InitializeComponent();

            lblGreeting.Text = $"Xin chào, {hoTen}";
            lblUsername.Text = $"Tên đăng nhập: {username}";
            lblEmail.Text = $"Email: {email}";
            if (lanDangNhapCuoi.HasValue)
            {
                lblLastLoginTime.Text = $"Lần đăng nhập cuối: {lanDangNhapCuoi.Value.ToString("dd/MM/yyyy HH:mm")}";
            }
            else
            {
                lblLastLoginTime.Text = "Lần đăng nhập cuối: Đây là lần đầu tiên bạn đăng nhập";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}