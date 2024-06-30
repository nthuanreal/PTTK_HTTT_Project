using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }



        private void DangNhap_Load(object sender, EventArgs e)
        {
             CenterPanel();
        }

        private void DangNhap_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "ĐĂNG NHẬP THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate a successful login
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            // modify this line for login method. Ẽ: if(login(txtUsername.Text, txtPassword.Text)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                HomePage homepage = new HomePage();
                homepage.FormClosed += (s, args) => this.Close();
                homepage.Show();
            }
            else if (txtUsername.Text == "staff" && txtPassword.Text == "staffpass")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeePage employeePage = new EmployeePage();
                employeePage.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "ĐĂNG NHẬP THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTogglePassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Show the password
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnTogglePassword_MouseUp(object sender, MouseEventArgs e)
        {
            // Hide the password
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkRegisterEmployer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKyTVDN registerForm = new DangKyTVDN();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void linkRegisterApplicant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKyTVUV registerForm = new DangKyTVUV();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau forgotPasswordForm = new QuenMatKhau();
            forgotPasswordForm.FormClosed += (s, args) => this.Close();
            forgotPasswordForm.Show();
        }
    }
}
