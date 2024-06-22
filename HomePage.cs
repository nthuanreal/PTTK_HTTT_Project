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
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            NavBar();
        }

        private void NavBar()
        {
            panelNavbar.Left = 0;
            panelNavbar.Top = 0;
            panelNavbar.Height = 60;
            panelNavbar.Width = this.ClientSize.Width;
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
            TraCuuThongTinUV loginForm = new TraCuuThongTinUV();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
