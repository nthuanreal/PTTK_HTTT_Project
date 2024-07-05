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
        DangNhap CurLogin = new DangNhap();
        bool isLogout = false;
        public HOMEUV(DangNhap curLogin)
        {
            InitializeComponent();
            CurLogin = curLogin;
        }

        private void DangXuat_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult dg;
            if (isLogout)
            {
                dg = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            switch (dg)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    if (isLogout)
                    {
                        CurLogin.con.Close();
                        CurLogin.Show();
                    }
                    break;
            }
        }


        private void HOMEUV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
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
