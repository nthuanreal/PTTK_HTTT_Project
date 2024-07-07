using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;

namespace UI_winform.NhanVien
{
    public partial class HoaDonThanhToan1Lan : Form
    {
        private decimal _maHd;

        public decimal MaHd { get => _maHd; set => _maHd = value; }

        public HoaDonThanhToan1Lan()
        {
            InitializeComponent();
        }

        public HoaDonThanhToan1Lan(decimal maHd)
        {
            InitializeComponent();
            _maHd = maHd;
            populateData();
            getHinhThucDangTuyen();
        }

        private void populateData()
        {
            string query = $"select * \r\nfrom qlhsut.qlhsut_phieu_quang_cao pqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen dt on hd.madt = dt.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on dt.dn_dangtuyen = dn.madn\r\njoin qlhsut.qlhsut_nguoi_dai_dien ndd on dn.ndd = ndd.mandd\r\nwhere hd.mahopdong = {MaHd}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                TenDoanhNghiep_Label.Text = row["TENDN"] != DBNull.Value ? row["TENDN"].ToString() : string.Empty;
                ViTriUngTuyen_Label.Text = row["VITRI_UNGTUYEN"] != DBNull.Value ? row["VITRI_UNGTUYEN"].ToString() : string.Empty;
                soLuongUngTuyen_label.Text = row["SOLUONG"] != DBNull.Value ? ((decimal)row["SOLUONG"]).ToString() : string.Empty;
                moTaCongViec_label.Text = row["MOTA"] != DBNull.Value ? row["MOTA"].ToString() : string.Empty;
                MaSoThue_Label.Text = row["MASOTHUE"] != DBNull.Value ? row["MASOTHUE"].ToString() : string.Empty;
                DiaChi_Label.Text = row["DIACHI"] != DBNull.Value ? row["DIACHI"].ToString() : string.Empty;
                SDT_Label.Text = row["SDT"] != DBNull.Value ? row["SDT"].ToString() : string.Empty;
                EmailLienHe_Label.Text = row["EMAIL"] != DBNull.Value ? row["EMAIL"].ToString() : string.Empty;
                NguoiDaiDien_Label.Text = row["HOTEN"] != DBNull.Value ? row["HOTEN"].ToString() : string.Empty;
                YeuCauUngVien_Label.Text = row["YEUCAU_UNGVIEN"] != DBNull.Value ? row["YEUCAU_UNGVIEN"].ToString() : string.Empty;
                From_Label.Text = row["TG_BATDAU"] != DBNull.Value ? ((DateTime)row["TG_BATDAU"]).ToString("dd-MM-yyyy") : string.Empty;
                To_Label.Text = row["TG_KETTHUC"] != DBNull.Value ? ((DateTime)row["TG_KETTHUC"]).ToString("dd-MM-yyyy") : string.Empty;
                tinhTrangThanhToan_label.Text = row["TRANGTHAI_THANHTOAN"] != DBNull.Value ? (decimal)row["TRANGTHAI_THANHTOAN"] == 1 ? "Đã thanh toán" : "Chưa thanh toán" : string.Empty;
                xacNhanBtn.Visible = row["TRANGTHAI_THANHTOAN"] != DBNull.Value ? (decimal)row["TRANGTHAI_THANHTOAN"] == 0 : false;
            

            }
            else
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau");
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
            hinhThucDangTuyen_label.Text = string.Join(", ", list.ToArray());
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sql = $"update qlhsut.qlhsut_phieu_quang_cao\r\nset TRANGTHAI_THANHTOAN = 1\r\nwhere mahopdong = {MaHd}";
                DataProvider.Instance.ExecuteNonQuery(sql);
                
                MessageBox.Show("Thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
;