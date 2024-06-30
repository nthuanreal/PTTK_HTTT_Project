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
    public partial class CapNhatThongTin : Form
    {
        public CapNhatThongTin()
        {
            InitializeComponent();
        }
        private void TraCuuThongTinUV_Load(object sender, EventArgs e)
        {
            CenterPanel();
            NavBar();
        }

        private void TraCuuThongTinUV_Resize(object sender, EventArgs e)
        {
            CenterPanel();
            NavBar();
        }
        private void CenterPanel()
        {
            this.panelRegister.Left = (this.ClientSize.Width - this.panelRegister.Width) / 2;
            this.panelRegister.Top = (this.ClientSize.Height - this.panelRegister.Height) / 2;
        }
        private void NavBar()
        {
            panelNavbar.Left = 0;
            panelNavbar.Top = 0;
            panelNavbar.Height = 60;
            panelNavbar.Width = this.ClientSize.Width;
        }
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap loginForm = new DangNhap();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage loginForm = new HomePage();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ADD FUNCTION HERE
            this.Hide();
            HomePage loginForm = new HomePage();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
