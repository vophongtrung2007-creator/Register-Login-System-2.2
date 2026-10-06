using System;
using System.Windows.Forms;

namespace Register_Login_System
{
    public partial class MainApplication : Form
    {
        private void MainApplication_Load(object sender, EventArgs e)
        {
        }
        public MainApplication(string hoTen, string username, string email)
        {
            InitializeComponent();

            lblGreeting.Text = $"Xin chào, {hoTen}";
            lblUsername.Text = $"Tên đăng nhập: {username}";
            lblEmail.Text = $"Email: {email}";
            lblLastLoginTime.Text = $"Lần đăng nhập gần nhất: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
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