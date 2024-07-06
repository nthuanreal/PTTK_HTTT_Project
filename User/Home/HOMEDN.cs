using Oracle.ManagedDataAccess.Client;
using UI_winform.DoanhNghiep;
using UI_winform.DoanhNghiep.controls;
using UI_winform.User.Login;
using UI_winform.utils;

namespace UI_winform.User.Home
{
    public partial class HOMEDN : Form
    {
        DangNhap CurLogin = new DangNhap();
        bool isLogout = false;
        UI_winform.DoanhNghiep.DoanhNghiep dn = new UI_winform.DoanhNghiep.DoanhNghiep();
        public HOMEDN(DangNhap curLogin)
        {
            InitializeComponent();
            CurLogin = curLogin;
        }

        public HOMEDN()
        {
            InitializeComponent();
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


        private void HOMEDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void HOMEDN_Load(object sender, EventArgs e)
        {
            dn.getInfo(Session.Instance.Username);
            TenDN_TxtBox.Text = dn.tendn;
            MaThue_TxtBox.Text = dn.mathue;
            NDD_TxtBox.Text = dn.ndd;
            DiaChi_TxtBox.Text = dn.diachi;
            SDT_TxtBox.Text = dn.sdt;
            Email_TxtBox.Text = dn.email;

            TenDN_TxtBox.ReadOnly = true;
            MaThue_TxtBox.ReadOnly = true;
            NDD_TxtBox.ReadOnly = true;
            DiaChi_TxtBox.ReadOnly = true;
            SDT_TxtBox.ReadOnly = true;
            Email_TxtBox.ReadOnly = true;
        }

        //Thông tin thành viên
        private void TTTV_Btn_Click(object sender, EventArgs e)
        {
            ThongTinDN TTTV = new ThongTinDN();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(TTTV);
            TTTV.Dock = DockStyle.Fill;
            TTTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTTV.Size = splitContainer1.Panel2.ClientSize;
        }

        private void TTNDD_Btn_Click(object sender, EventArgs e)
        {
            ThongTinNDD TTTNDD = new ThongTinNDD();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(TTTNDD);
            TTTNDD.Dock = DockStyle.Fill;
            TTTNDD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTTNDD.Size = splitContainer1.Panel2.ClientSize;
        }

        //Đăng ký đăng tuyển
        DangKyDT1 DKDT1;
        private void DKDT_Btn_Click(object sender, EventArgs e)
        {
            DKDT1 = new DangKyDT1(this);
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(DKDT1);
            DKDT1.Dock = DockStyle.Fill;
            DKDT1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT1.Size = splitContainer1.Panel2.ClientSize;
            //setDKTD1Size();
        }

        public DangKyDT1 getDKDT1()
        {
            return this.DKDT1;
        }


        //Thanh toán
        private void TT_Btn_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(thanhToan);
            thanhToan.Dock = DockStyle.Fill;
            thanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thanhToan.Size = splitContainer1.Panel2.ClientSize;
        }


        //Chiến lược
        private void DRCB_Btn_Click(object sender, EventArgs e)
        {
            UuDai uuDai = new UuDai(this);
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(uuDai);
            uuDai.Dock = DockStyle.Fill;
            uuDai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uuDai.Size = splitContainer1.Panel2.ClientSize;
        }

        private void DoiMK_Btn_Click(object sender, EventArgs e)
        {
            DoiMatKhau DoiMKPage = new DoiMatKhau();
            DoiMKPage.ShowDialog();
        }

        private void ChinhSua_Btn_Click(object sender, EventArgs e)
        {
            TenDN_TxtBox.ReadOnly = false;
            MaThue_TxtBox.ReadOnly = false;
            NDD_TxtBox.ReadOnly = true;
            DiaChi_TxtBox.ReadOnly = false;
            SDT_TxtBox.ReadOnly = false;
            Email_TxtBox.ReadOnly = false;

            DoiMK_Btn.Visible = false;
            ChinhSua_Btn.Visible = false;
            CapNhat_Btn.Visible = true;
            Huy_Btn.Visible = true;
        }

        private void CapNhat_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string update_sql = $"UPDATE QLHSUT.QLHSUT_DOANH_NGHIEP SET TENDN = N'{TenDN_TxtBox.Text}', MASOTHUE = '{MaThue_TxtBox.Text}', SDT = '{SDT_TxtBox.Text}', DIACHI = N'{DiaChi_TxtBox.Text}', EMAIL = '{Email_TxtBox.Text}' WHERE TO_CHAR(MADN) = '{Session.Instance.Username}'";
                //MessageBox.Show(update_sql);
                OracleCommand cmd = new OracleCommand(update_sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                TenDN_TxtBox.ReadOnly = true;
                MaThue_TxtBox.ReadOnly = true;
                NDD_TxtBox.ReadOnly = true;
                DiaChi_TxtBox.ReadOnly = true;
                SDT_TxtBox.ReadOnly = true;
                Email_TxtBox.ReadOnly = true;

                DoiMK_Btn.Visible = true;
                ChinhSua_Btn.Visible = true;
                CapNhat_Btn.Visible = false;
                Huy_Btn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
                MessageBox.Show(ex.Message);
            }
        }

        private void Huy_Btn_Click(object sender, EventArgs e)
        {
            DoiMK_Btn.Visible = true;
            ChinhSua_Btn.Visible = true;
            CapNhat_Btn.Visible = false;
            Huy_Btn.Visible = false;

            TenDN_TxtBox.Text = dn.tendn;
            MaThue_TxtBox.Text = dn.mathue;
            DiaChi_TxtBox.Text = dn.diachi;
            SDT_TxtBox.Text = dn.sdt;
            Email_TxtBox.Text = dn.email;

            TenDN_TxtBox.ReadOnly = true;
            MaThue_TxtBox.ReadOnly = true;
            NDD_TxtBox.ReadOnly = true;
            DiaChi_TxtBox.ReadOnly = true;
            SDT_TxtBox.ReadOnly = true;
            Email_TxtBox.ReadOnly = true;
        }
    }
}
