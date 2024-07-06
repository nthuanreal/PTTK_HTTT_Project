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
using UI_winform.NhanVien.controls;

namespace UI_winform.NhanVien
{
    public partial class ChonGiaHanHopDong : Form
    {
        public ChonGiaHanHopDong()
        {
            InitializeComponent();
            fetchHopDongSapHetHan();
        }
        private void fetchHopDongSapHetHan()
        {
            string query = $"select *\r\nfrom qlhsut.qlhsut_hop_dong_dang_tuyen\r\nWHERE ngayhethan BETWEEN TRUNC(SYSDATE) AND TRUNC(SYSDATE) + INTERVAL '3' DAY - INTERVAL '1' SECOND";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int n = data.Rows.Count;

            HopDongSapHetHanListItem[] hopDongListItems = new HopDongSapHetHanListItem[n];

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < n; i++)
            {
                DataRow row = data.Rows[i];
                hopDongListItems[i] = new HopDongSapHetHanListItem();

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

        private void giaHanBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn gia hạn những hợp đồng này?", "Gia hạn hợp đồng", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string sql = "";
            } else
            {
                this.Close();
            }
        }
    }
}
