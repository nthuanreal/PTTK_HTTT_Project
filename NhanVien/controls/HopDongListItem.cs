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
using UI_winform.NhanVien;

namespace UI_winform.controls
{
    public partial class HopDongListItem : UserControl
    {
        public HopDongListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _maHopDong;
        private string _ngayLap;
        private string _tinhTrang;
        private string _ngayHetHan;

        private void HopDongListItem_Click(object sender, EventArgs e)
        {
            string? tinhTrangHopDong = getTinhTrangHopDong();
            string? hinhThucThanhToan = getHinhThucThanhToan();

            if (tinhTrangHopDong == null || tinhTrangHopDong == "" || tinhTrangHopDong == "Chưa duyệt")
            {
                PhieuDangKyQuangCao phieuDangKyQuangCao = new PhieuDangKyQuangCao(decimal.Parse(_maHopDong));
                phieuDangKyQuangCao.ShowDialog();
                return;
            } else
            {
                if (hinhThucThanhToan == null || hinhThucThanhToan == "" || hinhThucThanhToan == "Thanh toán một lần")
                {
                    HoaDonThanhToan1Lan hoaDonThanhToan1Lan = new HoaDonThanhToan1Lan(decimal.Parse(_maHopDong));
                    hoaDonThanhToan1Lan.ShowDialog();
                    return;
                } else
                {
                    MessageBox.Show("Trả góp");
                }
            }
        }

        private string? getTinhTrangHopDong()
        {
            string query = $"select * \r\nfrom qlhsut.qlhsut_phieu_quang_cao pqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen dt on hd.madt = dt.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on dt.dn_dangtuyen = dn.madn\r\njoin qlhsut.qlhsut_nguoi_dai_dien ndd on dn.ndd = ndd.mandd\r\nwhere hd.mahopdong = {_maHopDong}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 1)
            {
                DataRow row = data.Rows[0];
                return row["TINHTRANG"].ToString();
            }
            return null;
        }
        private string? getHinhThucThanhToan()
        {
            string query = $"select * \r\nfrom  qlhsut.qlhsut_phieu_quang_cao pqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen dt on hd.madt = dt.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on dt.dn_dangtuyen = dn.madn\r\njoin qlhsut.qlhsut_nguoi_dai_dien ndd on dn.ndd = ndd.mandd\r\nwhere hd.mahopdong = {_maHopDong}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 1)
            {
                DataRow row = data.Rows[0];
                return row["HINHTHUCTHANHTOAN"].ToString();
            }
            return null;
        }

        [Category("Custom Props")]
        public string MaHopDong
        {
            get { return _maHopDong; }
            set { _maHopDong = value; hopDongTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; ngayLapTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; tinhTrangTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; ngayHetHanTxt.Text = value; }
        }
        #endregion
    }
}
