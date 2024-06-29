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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            NavBar();
            SideBar();
            CenterPanel();
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            NavBar();
            SideBar();
            CenterPanel();
        }

        private void NavBar()
        {
            panelNavbar.Left = 170;
            panelNavbar.Top = 0;
            panelNavbar.Height = 70;
            panelNavbar.Width = this.ClientSize.Width - panelNavbar.Left;
        }

        private void SideBar()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Height = this.ClientSize.Height;
            panel1.Width = 170;
            linkBack.Top = panel1.Height - linkBack.Height - 30;
        }
        private void CenterPanel()
        {
            panelRegister.Left = panel1.Width + (this.ClientSize.Width - panel1.Width - panelRegister.Width) / 2;
            panelRegister.Top = panelNavbar.Height + (this.ClientSize.Height - panelNavbar.Height - panelRegister.Height) / 2;
        }




        private void btnDKyDangTuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyDangTuyen1 dkDangTuyenForm = new DangKyDangTuyen1();
            dkDangTuyenForm.FormClosed += (s, args) => this.Close();
            dkDangTuyenForm.Show();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap loginForm = new DangNhap();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapNhatThongTin loginForm = new CapNhatThongTin();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NopHoSo01 loginForm = new NopHoSo01();
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NopHoSo02 loginForm = new NopHoSo02();
            loginForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraCuuHoSo loginForm = new TraCuuHoSo();
            loginForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TraCuuViTriUngTuyen loginForm = new TraCuuViTriUngTuyen();
            loginForm.Show();
        }
    }
}
