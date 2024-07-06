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
using UI_winform.DoanhNghiep;
using UI_winform.utils;

namespace UI_winform.DoanhNghiep
{
    public partial class ThanhToan : UserControl
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        List<ThongTinThanhToan> thanhtoanList = getList(Session.Instance.Username);
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            foreach (ThongTinThanhToan thanhtoan in thanhtoanList)
            {
                ThanhToanItem thanhtoanItem = new ThanhToanItem(thanhtoan);
                ThanhToanListView.Controls.Add(thanhtoanItem); // Set properties based on recipe object
                thanhtoanItem.Dock = DockStyle.Top;
                thanhtoanItem.Margin = new Padding(10);
            }
        }

        private static List<ThongTinThanhToan> getList(string ma)
        {
            List<ThongTinThanhToan> list = new List<ThongTinThanhToan>();
            string query_sql = $"SELECT  TO_CHAR(MATT), TO_CHAR(MAPQC), TO_CHAR(DOTTHANHTOAN), TO_CHAR(TONGTIEN_THANHTOAN), TO_CHAR(TRANGTHAI_THANHTOAN) FROM QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN "
                            + $"WHERE MAPQC IN (SELECT MAPQC FROM QLHSUT.QLHSUT_PHIEU_QUANG_CAO WHERE MAHOPDONG IN (SELECT MAHOPDONG FROM QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN WHERE MADT IN ( SELECT MADT FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE TO_CHAR(DN_DANGTUYEN) = '{ma}')))";
            //MessageBox.Show(query_sql);
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongTinThanhToan thanhToan = new ThongTinThanhToan();
                        thanhToan.matt = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MATT)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MATT)"));
                        thanhToan.mapqc = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MAPQC)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MAPQC)"));
                        thanhToan.dotthanhtoan = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(DOTTHANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(DOTTHANHTOAN)"));
                        thanhToan.tongtien = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(TONGTIEN_THANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(TONGTIEN_THANHTOAN)"));
                        thanhToan.tinhtrang = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(TRANGTHAI_THANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(TRANGTHAI_THANHTOAN)")) == "0" ? "Chưa thanh toán" : "Đã thanh toán";
                        list.Add(thanhToan);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu!");
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void TimBtn_Click(object sender, EventArgs e)
        {
            List<ThongTinThanhToan> list = new List<ThongTinThanhToan>();
            string query_sql = "";
            int tinhtrang = 0;
            if (TinhTrang_ComBox.Text == "" || TinhTrang_ComBox.Text == "Tất cả")
            {
                query_sql = $"SELECT  TO_CHAR(MATT), TO_CHAR(MAPQC), TO_CHAR(DOTTHANHTOAN), TO_CHAR(TONGTIEN_THANHTOAN), TO_CHAR(TRANGTHAI_THANHTOAN) FROM QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN "
                + $"WHERE MAPQC IN (SELECT MAPQC FROM QLHSUT.QLHSUT_PHIEU_QUANG_CAO WHERE MAHOPDONG IN (SELECT MAHOPDONG FROM QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN WHERE MADT IN ( SELECT MADT FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE TO_CHAR(DN_DANGTUYEN) = '{Session.Instance.Username}'))) AND (TO_CHAR(MATT) LIKE '%{SearchBox.Text}%' OR TO_CHAR(MAPQC) = '%{SearchBox.Text}%')";
            } else if (TinhTrang_ComBox.Text == "Chưa thanh toán")
            {
                query_sql = $"SELECT  TO_CHAR(MATT), TO_CHAR(MAPQC), TO_CHAR(DOTTHANHTOAN), TO_CHAR(TONGTIEN_THANHTOAN), TO_CHAR(TRANGTHAI_THANHTOAN) FROM QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN "
+                           $"WHERE MAPQC IN (SELECT MAPQC FROM QLHSUT.QLHSUT_PHIEU_QUANG_CAO WHERE MAHOPDONG IN (SELECT MAHOPDONG FROM QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN WHERE MADT IN ( SELECT MADT FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE TO_CHAR(DN_DANGTUYEN) = '{Session.Instance.Username}'))) AND (TO_CHAR(MATT) LIKE '%{SearchBox.Text}%' OR TO_CHAR(MAPQC) = '%{SearchBox.Text}%') AND TRANGTHAI_THANHTOAN = 0";
            } else
            {
                query_sql = $"SELECT  TO_CHAR(MATT), TO_CHAR(MAPQC), TO_CHAR(DOTTHANHTOAN), TO_CHAR(TONGTIEN_THANHTOAN), TO_CHAR(TRANGTHAI_THANHTOAN) FROM QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN "
                            + $"WHERE MAPQC IN (SELECT MAPQC FROM QLHSUT.QLHSUT_PHIEU_QUANG_CAO WHERE MAHOPDONG IN (SELECT MAHOPDONG FROM QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN WHERE MADT IN ( SELECT MADT FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE TO_CHAR(DN_DANGTUYEN) = '{Session.Instance.Username}'))) AND (TO_CHAR(MATT) LIKE '%{SearchBox.Text}%' OR TO_CHAR(MAPQC) = '%{SearchBox.Text}%') AND TRANGTHAI_THANHTOAN = 1";
            }

            //MessageBox.Show(query_sql);
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongTinThanhToan thanhToan = new ThongTinThanhToan();
                        thanhToan.matt = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MATT)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MATT)"));
                        thanhToan.mapqc = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MAPQC)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MAPQC)"));
                        thanhToan.dotthanhtoan = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(DOTTHANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(DOTTHANHTOAN)"));
                        thanhToan.tongtien = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(TONGTIEN_THANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(TONGTIEN_THANHTOAN)"));
                        thanhToan.tinhtrang = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(TRANGTHAI_THANHTOAN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(TRANGTHAI_THANHTOAN)")) == "0" ? "Chưa thanh toán" : "Đã thanh toán";
                        list.Add(thanhToan);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu!");
                MessageBox.Show(ex.Message);
            }

            ThanhToanListView.Controls.Clear();
            foreach (ThongTinThanhToan thanhtoan in list)
            {
                ThanhToanItem thanhtoanItem = new ThanhToanItem(thanhtoan);
                ThanhToanListView.Controls.Add(thanhtoanItem); // Set properties based on recipe object
                thanhtoanItem.Dock = DockStyle.Top;
                thanhtoanItem.Margin = new Padding(10);
            }

        }
    }
}
