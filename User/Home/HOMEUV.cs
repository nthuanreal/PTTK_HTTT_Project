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
using UI_winform.NhanVien.controls;
using UI_winform.User.Login;

namespace UI_winform.User.Home
{
    public partial class HOMEUV : Form
    {
        public HOMEUV()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap newWindow = new DangNhap();
            this.FormClosing += (s, args) => newWindow.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraCuuViTriUngTuyen newPage = new TraCuuViTriUngTuyen(1);
            newPage.Show();
        }
        //Nộp hồ sơ
        private void button3_Click(object sender, EventArgs e)
        {
            NopHoSo01 newPage = new NopHoSo01();
            newPage.ShowDialog();
        }
        //Đổi mật khẩu
        private void button4_Click(object sender, EventArgs e)
        {

            DoiMatKhau newPage = new DoiMatKhau();
            newPage.ShowDialog();
        }


        //Cập nhật thông tin
        private void button5_Click(object sender, EventArgs e)
        {
            CapNhatThongTinUV newPage = new CapNhatThongTinUV();
            newPage.ShowDialog();
        }
    }
}
