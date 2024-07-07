using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.User.Login
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtValidate())
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
                return;
            }
        }
        private bool txtValidate()
        {
            this.lblValidation.Visible = true;
            if(textBoxCurrentPassword.Text.Length == 0 || txtNewPassword.Text.Length==0 ||textBoxConfirmPassword.Text.Length==0)
            {
                this.lblValidation.Text = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }
            if(txtNewPassword.Text != textBoxConfirmPassword.Text)
            {
                this.lblValidation.Text = "Nhập lại mật khẩu phải khớp với mật khẩu mới!";
                return false;
            }
            if (textBoxCurrentPassword.Text == txtNewPassword.Text) {
                this.lblValidation.Text = "mật khẩu mới không được trùng với mật khẩu cũ!";
                return false;
            }
            return true;
        }
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
