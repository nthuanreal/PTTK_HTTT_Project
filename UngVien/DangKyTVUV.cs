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
    public partial class DangKyTVUV : Form
    {
        public DangKyTVUV()
        {
            InitializeComponent();
        }

        private void DangKyTVUV_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void DangKyTVUV_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================
            //if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            //{
            //    MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "ĐĂNG KÝ THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //===========================
            this.Close();
        }
    }
}
