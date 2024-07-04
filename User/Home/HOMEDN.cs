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
    public partial class HOMEDN : Form
    {
        public HOMEDN()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void HOMEDN_Load(object sender, EventArgs e)
        {

        }

        //Thông tin thành viên
        private void button1_Click(object sender, EventArgs e)
        {
            // Nothing to do here
        }
        //Đăng ký đăng tuyển
        private void button2_Click(object sender, EventArgs e)
        {
            DangKyDangTuyen1 newPage = new DangKyDangTuyen1();
            newPage.Show();
        }


        //Thanh toán
        private void button3_Click(object sender, EventArgs e)
        {
            //ThanhToan newPage = new ThanhToan();
            //newPage.Show();
        }


        //Chiến lược
        private void button4_Click(object sender, EventArgs e)
        {
            //ChienLuoc newPage = new ChienLuoc();
            //newPage.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            DoiMatKhau newPage = new DoiMatKhau();
            newPage.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //CapNhatThongTinDN newPage = new CapNhatThongTinDN();
            //newPage.ShowDialog();
        }
    }
}
