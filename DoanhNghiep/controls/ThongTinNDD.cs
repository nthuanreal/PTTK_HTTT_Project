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
using UI_winform.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class ThongTinNDD : UserControl
    {
        UI_winform.DoanhNghiep.DoanhNghiep dn = new UI_winform.DoanhNghiep.DoanhNghiep();
        UI_winform.DoanhNghiep.NguoiDaiDien ndd = new UI_winform.DoanhNghiep.NguoiDaiDien();
        public ThongTinNDD()
        {
            InitializeComponent();
        }

        private void ThongTinNDD_Load(object sender, EventArgs e)
        {
            dn.getInfo(Session.Instance.Username);
            ndd.getInfo(dn.ndd);

            TenNDD_TxtBox.Text = ndd.tenndd;
            NgSinh_TxtBox.Text = ndd.ngsinh;
            GioiTinh_TxtBox.Text = ndd.gioitinh;
            SDT_TxtBox.Text = ndd.sdt;
            DiaChi_TxtBox.Text = ndd.diachi;
            Email_TxtBox.Text = ndd.email;

            TenNDD_TxtBox.ReadOnly = true;
            NgSinh_TxtBox.ReadOnly = true;
            GioiTinh_TxtBox.ReadOnly = true;
            DiaChi_TxtBox.ReadOnly = true;
            SDT_TxtBox.ReadOnly = true;
            Email_TxtBox.ReadOnly = true;
        }

        private void ChinhSua_Btn_Click(object sender, EventArgs e)
        {
            TenNDD_TxtBox.ReadOnly = false;
            NgSinh_TxtBox.ReadOnly = false;
            GioiTinh_TxtBox.ReadOnly = false;
            DiaChi_TxtBox.ReadOnly = false;
            SDT_TxtBox.ReadOnly = false;
            Email_TxtBox.ReadOnly = false;

            ChinhSua_Btn.Visible = false;
            CapNhat_Btn.Visible = true;
            Huy_Btn.Visible = true;
        }

        private void CapNhat_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string update_sql = $"UPDATE QLHSUT.QLHSUT_NGUOI_DAI_DIEN SET HOTEN = N'{TenNDD_TxtBox.Text}', NGSINH = TO_DATE('{NgSinh_TxtBox.Text}', 'dd-mm-yyyy'), GIOITINH = '{GioiTinh_TxtBox.Text}', SDT = '{SDT_TxtBox.Text}', DIACHI = N'{DiaChi_TxtBox.Text}', EMAIL = '{Email_TxtBox.Text}' WHERE TO_CHAR(MANDD) = '{ndd.mandd}'";
                //MessageBox.Show(update_sql);
                OracleCommand cmd = new OracleCommand(update_sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                TenNDD_TxtBox.ReadOnly = true;
                NgSinh_TxtBox.ReadOnly = true;
                GioiTinh_TxtBox.ReadOnly = true;
                DiaChi_TxtBox.ReadOnly = true;
                SDT_TxtBox.ReadOnly = true;
                Email_TxtBox.ReadOnly = true;

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
            ChinhSua_Btn.Visible = true;
            CapNhat_Btn.Visible = false;
            Huy_Btn.Visible = false;

            TenNDD_TxtBox.Text = ndd.tenndd;
            NgSinh_TxtBox.Text = ndd.ngsinh;
            GioiTinh_TxtBox.Text = ndd.gioitinh;
            DiaChi_TxtBox.Text = ndd.diachi;
            SDT_TxtBox.Text = ndd.sdt;
            Email_TxtBox.Text = ndd.email;

            TenNDD_TxtBox.ReadOnly = true;
            NgSinh_TxtBox.ReadOnly = true;
            GioiTinh_TxtBox.ReadOnly = true;
            DiaChi_TxtBox.ReadOnly = true;
            SDT_TxtBox.ReadOnly = true;
            Email_TxtBox.ReadOnly = true;
        }
    }
}
