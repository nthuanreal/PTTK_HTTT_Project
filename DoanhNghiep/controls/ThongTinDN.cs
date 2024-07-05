using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.User.Login;
using UI_winform.utils;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class ThongTinDN : UserControl
    {
        DoanhNghiep dn = new DoanhNghiep();
        public ThongTinDN()
        {
            InitializeComponent();
        }

        private void ThongTinDN_Load(object sender, EventArgs e)
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
