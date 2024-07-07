using Microsoft.EntityFrameworkCore.Query.Internal;
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

namespace UI_winform.NhanVien
{
    public partial class PhieuDangKyQuangCao : Form
    {
        private decimal _maHd;

        public decimal MaHd { get => _maHd; set => _maHd = value; }

        public PhieuDangKyQuangCao()
        {
            InitializeComponent();
        }

        public PhieuDangKyQuangCao(decimal mahd)
        {
            InitializeComponent();
            MaHd = mahd;
            populateItem();
            getHinhThucDangTuyen();
        }

        private void populateItem()
        {
            string query = $"select * \r\nfrom qlhsut.qlhsut_phieu_quang_cao pqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen dt on hd.madt = dt.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on dt.dn_dangtuyen = dn.madn\r\nwhere hd.mahopdong = {MaHd}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                TenDoanhNghiep_Textbox.Text = row["TENDN"].ToString();
                ViTriUngTuyen_Textbox.Text = row["VITRI_UNGTUYEN"].ToString();
                SoLuongUngTuyen_Textbox.Text = ((decimal)row["SOLUONG"]).ToString();
                MoTaCongViec_Textbox.Text = row["MOTA"].ToString();
                Date_From.Text = ((DateTime)row["TG_BATDAU"]).ToString("dd-MM-yyyy");
                Date_To.Text = ((DateTime)row["TG_KETTHUC"]).ToString("dd-MM-yyyy");
                YeuCauUngVien_Textbox.Text = row["YEUCAU_UNGVIEN"].ToString();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau!");
            }
        }

        private void getHinhThucDangTuyen()
        {
            string query = $"select *\r\nfrom qlhsut.qlhsut_hinh_thuc_lua_chon htlc\r\njoin qlhsut.qlhsut_hinh_thuc_dang_tuyen htdt on htlc.maht = htdt.maht\r\nwhere htlc.mahopdong = {MaHd}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<String?> list = new List<String?>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = (DataRow)data.Rows[i];
                string? hinhThuc = row["TENHINHTHUC"].ToString();
                list.Add(hinhThuc);

            }
            HinhThucDangTuyenDung_Textbox.Text = string.Join(", ", list.ToArray());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HinhThucDangTuyenDung_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoTaCongViec_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViTriUngTuyen_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TuChoi_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được hoàn thiện");
            this.Close();
        }

        private void Tao_button_Click(object sender, EventArgs e)
        {
            TaoHoaDonThanhToan taoHoaDonThanhToan = new TaoHoaDonThanhToan(MaHd);
            this.Close();
            taoHoaDonThanhToan.ShowDialog();
        }
    }
}
