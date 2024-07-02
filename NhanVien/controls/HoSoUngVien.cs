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

namespace UI_winform.NhanVien.controls
{
    public partial class HoSoUngVien : UserControl
    {
        private static Dictionary<string, string> TRANGTHAI = new Dictionary<string, string>() { { "0", "Chưa duyệt" }, { "1", "Đã duyệt" } };

        public HoSoUngVien()
        {
            InitializeComponent();
            populateItems(null);
        }

        private void populateItems(string? filter)
        {
            string query = "select hs.mahs, dn.tendn, ttdt.vitri_ungtuyen, hs.trangthaiduyet\r\nfrom qlhsut.qlhsut_ho_so_ung_tuyen hs\r\njoin qlhsut.qlhsut_phieu_quang_cao pqc on hs.mapqc = pqc.mapqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen ttdt on ttdt.madt = hd.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on ttdt.dn_dangtuyen = dn.madn";
            if (filter != null)
            {
                if (filter == "Chưa duyệt")
                    query = $"select hs.mahs, dn.tendn, ttdt.vitri_ungtuyen, hs.trangthaiduyet\r\nfrom qlhsut.qlhsut_ho_so_ung_tuyen hs\r\njoin qlhsut.qlhsut_phieu_quang_cao pqc on hs.mapqc = pqc.mapqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen ttdt on ttdt.madt = hd.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on ttdt.dn_dangtuyen = dn.madn where trangthaiduyet = '{filter}' or trangthaiduyet is NULL";
                else
                    query = $"select hs.mahs, dn.tendn, ttdt.vitri_ungtuyen, hs.trangthaiduyet\r\nfrom qlhsut.qlhsut_ho_so_ung_tuyen hs\r\njoin qlhsut.qlhsut_phieu_quang_cao pqc on hs.mapqc = pqc.mapqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen ttdt on ttdt.madt = hd.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on ttdt.dn_dangtuyen = dn.madn where tinhtrang = '{filter}'";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int n = data.Rows.Count;
            HoSoUngVienItem[] hopDongListItems = new HoSoUngVienItem[n];
            
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < n; i++)
            {
                DataRow row = data.Rows[i];
                hopDongListItems[i] = new HoSoUngVienItem();

                decimal maHS = (decimal)row["MAHS"];
                string tenDN = (string)row["TENDN"];
                string viTri = (string)row["VITRI_UNGTUYEN"];
                decimal trangThai = (decimal)row["TRANGTHAIDUYET"];

                
                hopDongListItems[i].MaHs = maHS.ToString();
                hopDongListItems[i].TenDn = tenDN;
                hopDongListItems[i].ViTri = viTri;
                hopDongListItems[i].TrangThaiDuyet = TRANGTHAI[trangThai.ToString()];

                flowLayoutPanel1.Controls.Add(hopDongListItems[i]);
            }
        }
    }
}
