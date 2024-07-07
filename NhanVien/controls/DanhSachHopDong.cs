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
    public partial class DanhSachHopDong : UserControl
    {
        public DanhSachHopDong()
        {
            InitializeComponent();
        }

        private void populateItems(string? filter)
        {
            string query = "select * from qlhsut.qlhsut_hop_dong_dang_tuyen";
            if (filter != null)
            {
                if (filter == "Chưa duyệt")
                    query = $"select * from qlhsut.qlhsut_hop_dong_dang_tuyen where tinhtrang = N'{filter}' or tinhtrang is NULL";
                else
                    query = $"select * from qlhsut.qlhsut_hop_dong_dang_tuyen where tinhtrang = N'{filter}'";
            }

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

                hopDongListItems[i].MaHopDong = row["MAHOPDONG"] != DBNull.Value ? ((decimal)row["MAHOPDONG"]).ToString() : string.Empty;
                hopDongListItems[i].NgayLap = row["NGAYKI"] != DBNull.Value ? ((DateTime)row["NGAYKI"]).ToString("yyyy/MM/dd") : string.Empty;
                hopDongListItems[i].NgayHetHan = row["NGAYHETHAN"] != DBNull.Value ? ((DateTime)row["NGAYHETHAN"]).ToString("yyyy/MM/dd") : string.Empty;
                hopDongListItems[i].TinhTrang = row["TINHTRANG"] != DBNull.Value ? (string)row["TINHTRANG"] : "Chưa duyệt";
                //decimal maHopDong = (decimal)row["MAHOPDONG"];
                //DateTime ngayLap = (DateTime)row["NGAYKI"];
                //DateTime ngayHetHan;

                //if (row.IsNull("NGAYHETHAN"))
                //{
                //    ngayHetHan = DateTime.MinValue;
                //}
                //else
                //{
                //    ngayHetHan = (DateTime)row["NGAYHETHAN"];
                //}

                //string ngayHetHanStr = ngayHetHan == DateTime.MinValue ? "" : ngayHetHan.ToString("yyyy/MM/dd");
                //string ngayLapStr = ngayLap.ToString("yyyy/MM/dd");
                //string tinhTrang = row.IsNull("TINHTRANG") ? "Chưa duyệt" : (string)row["TINHTRANG"];

                //hopDongListItems[i].MaHopDong = maHopDong.ToString();
                //hopDongListItems[i].NgayLap = ngayLapStr;
                //hopDongListItems[i].NgayHetHan = ngayHetHanStr;
                //hopDongListItems[i].TinhTrang = tinhTrang;

                flowLayoutPanel1.Controls.Add(hopDongListItems[i]);
            }
        }

        private void DanhSachHopDong_Load(object sender, EventArgs e)
        {
            populateItems(null);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            populateItems((string?)comboBox1.SelectedItem);

        }
    }
}
