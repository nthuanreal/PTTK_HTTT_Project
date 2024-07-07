using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.controls;
using UI_winform.DAO;
using UI_winform.NhanVien.controls;

namespace UI_winform
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        DangNhap curLogin = new DangNhap();
        bool isLogout = false;
        public EmployeePage(DangNhap curLogin)
        {
            InitializeComponent();
            this.curLogin = curLogin;
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {

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
                        curLogin.con.Close();
                        curLogin.Show();
                    }
                    break;
            }
        }

        private void EmployeePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void xuLyHopDong1_Load(object sender, EventArgs e)
        {

        }

        private void hoSoBtn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HoSoUngVien());
        }

        private void giaHanBtn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new GiaHanHopDong());
        }

        private void hopDongBtn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new XuLyHopDong());
        }
    }

}
