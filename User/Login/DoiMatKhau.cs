using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;
using UI_winform.utils;

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
            if (textBoxCurrentPassword.Text == "" || txtNewPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (textBoxCurrentPassword.Text != Session.Instance.Password)
            {
                MessageBox.Show("Thông tin mật khẩu hiện tại không đúng, vui lòng nhập lại!");
                return;
            }
            if (textBoxConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu mới!");
                return;
            }

            try
            {
                string change_pass = $"ALTER USER \"{Session.Instance.Username}\" IDENTIFIED BY \"{txtNewPassword.Text}\"";
                DataProvider.Instance.ExecuteNonQuery(change_pass);
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại!"+ ex.Message);
            }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
