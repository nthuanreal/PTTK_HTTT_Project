using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using UI_winform.DAO;
using UI_winform.controls;
using System.Drawing.Text;

namespace UI_winform.NhanVien.controls
{
    public partial class GiaHanHopDong : UserControl
    {
        public GiaHanHopDong()
        {
            InitializeComponent();
            fetchHopDongSapHetHan();
            fetHopDongConHan();
        }

        private void fetHopDongConHan()
        {
            string query = $"select *\r\nfrom qlhsut.qlhsut_hop_dong_dang_tuyen\r\nWHERE ngayhethan NOT BETWEEN TRUNC(SYSDATE) AND TRUNC(SYSDATE) + INTERVAL '3' DAY - INTERVAL '1' SECOND";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int n = data.Rows.Count;

            HopDongListItem[] hopDongListItems = new HopDongListItem[n];

            if (flowLayoutPanel2.Controls.Count > 0)
            {
                flowLayoutPanel2.Controls.Clear();
            }
            for (int i = 0; i < n; i++)
            {
                DataRow row = data.Rows[i];
                hopDongListItems[i] = new HopDongListItem();

                decimal maHopDong = (decimal)row["MAHOPDONG"];
                DateTime ngayLap = (DateTime)row["NGAYKI"];
                DateTime ngayHetHan;

                if (row.IsNull("NGAYHETHAN"))
                {
                    ngayHetHan = DateTime.MinValue;
                }
                else
                {
                    ngayHetHan = (DateTime)row["NGAYHETHAN"];
                }

                string ngayHetHanStr = ngayHetHan == DateTime.MinValue ? "" : ngayHetHan.ToString("yyyy/MM/dd");
                string ngayLapStr = ngayLap.ToString("yyyy/MM/dd");
                string tinhTrang = row.IsNull("TINHTRANG") ? "Chưa duyệt" : (string)row["TINHTRANG"];

                hopDongListItems[i].MaHopDong = maHopDong.ToString();
                hopDongListItems[i].NgayLap = ngayLapStr;
                hopDongListItems[i].NgayHetHan = ngayHetHanStr;
                hopDongListItems[i].TinhTrang = tinhTrang;

                flowLayoutPanel2.Controls.Add(hopDongListItems[i]);
            }
        }

        private void fetchHopDongSapHetHan()
        {
            string query = $"select *\r\nfrom qlhsut.qlhsut_hop_dong_dang_tuyen\r\nWHERE ngayhethan BETWEEN TRUNC(SYSDATE) AND TRUNC(SYSDATE) + INTERVAL '3' DAY - INTERVAL '1' SECOND";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int n = data.Rows.Count;

            HopDongListItem[] hopDongListItems = new HopDongListItem[n];

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < n; i++)
            {
                DataRow row = data.Rows[i];
                hopDongListItems[i] = new HopDongListItem();

                decimal maHopDong = (decimal)row["MAHOPDONG"];
                DateTime ngayLap = (DateTime)row["NGAYKI"];
                DateTime ngayHetHan;

                if (row.IsNull("NGAYHETHAN"))
                {
                    ngayHetHan = DateTime.MinValue;
                }
                else
                {
                    ngayHetHan = (DateTime)row["NGAYHETHAN"];
                }

                string ngayHetHanStr = ngayHetHan == DateTime.MinValue ? "" : ngayHetHan.ToString("yyyy/MM/dd");
                string ngayLapStr = ngayLap.ToString("yyyy/MM/dd");
                string tinhTrang = row.IsNull("TINHTRANG") ? "Chưa duyệt" : (string)row["TINHTRANG"];

                hopDongListItems[i].MaHopDong = maHopDong.ToString();
                hopDongListItems[i].NgayLap = ngayLapStr;
                hopDongListItems[i].NgayHetHan = ngayHetHanStr;
                hopDongListItems[i].TinhTrang = tinhTrang;

                flowLayoutPanel1.Controls.Add(hopDongListItems[i]);
            }


        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GiaHanBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
