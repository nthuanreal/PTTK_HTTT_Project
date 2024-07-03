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
    public partial class ChiTietHoSo : Form
    {
        private decimal maHs;

        public ChiTietHoSo()
        {
            InitializeComponent();
        }
        public ChiTietHoSo(decimal maHs)
        {
            InitializeComponent();
            this.maHs = maHs;
            populateItem();
        }
        private void populateItem()
        {
            string sql = $"select hs.mahs, dn.tendn, ttdt.vitri_ungtuyen, uv.hoten, uv.ngsinh, uv.diachi, uv.sdt, uv.email, uv.trinhdo\r\nfrom qlhsut.qlhsut_ho_so_ung_tuyen hs\r\njoin qlhsut.qlhsut_phieu_quang_cao pqc on hs.mapqc = pqc.mapqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen ttdt on ttdt.madt = hd.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on ttdt.dn_dangtuyen = dn.madn\r\njoin qlhsut.qlhsut_ung_vien uv on hs.mauv = uv.mauv\r\nwhere mahs = {this.maHs}";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            int n = data.Rows.Count;
            if (n != 1)
            {
                return;
            }
            DataRow row = data.Rows[0];
            maHoSoTxt.Text = row["MAHS"].ToString();
            congTyTxt.Text = row["TENDN"].ToString() ;
            hoTenUngVien.Text = row["HOTEN"].ToString();
            ngaySinhTxt.Text = row["NGSINH"].ToString();
            diaChiTxt.Text = row["DIACHI"].ToString();
            emailTxt.Text = row["EMAIL"].ToString();
            sdtTxt.Text = row["SDT"].ToString();
            trinhDoTxt.Text = row["TRINHDO"].ToString();
        }
    }
}
