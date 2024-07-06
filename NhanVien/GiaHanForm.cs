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
    public partial class GiaHanForm : Form
    {
        public GiaHanForm()
        {
            InitializeComponent();
        }

        public GiaHanForm(string maHopDong)
        {
            InitializeComponent();
            MaHopDong = maHopDong;
            populateData();
        }

        private void populateData()
        {
            string sql = "select mahopdong, ngayki, ngayhethan\r\nfrom qlhsut.qlhsut_hop_dong_dang_tuyen\r\nwhere mahopdong = :maHopDong";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, [decimal.Parse(maHopDongTxt.Text)]);

            if (data.Rows.Count == 1)
            {
                DataRow row = data.Rows[0];
                MaHopDong = ((decimal)row["MAHOPDONG"]).ToString();
                NgayLap = ((DateTime)row["NGAYKI"]).ToString("dd-MM-yyyy");
                NgayHetHan = ((DateTime)row["NGAYHETHAN"]).ToString("dd-MM-yyyy");
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau1");
            }
            //try
            //{
            //    string sql = "select mahopdong, ngayki, ngayhethan\r\nfrom qlhsut.qlhsut_hop_dong_dang_tuyen\r\nwhere mahopdong = :maHopDong";
            //    DataTable data = DataProvider.Instance.ExecuteQuery(sql, [maHopDongTxt]);

            //    if (data.Rows.Count == 1)
            //    {
            //        DataRow row = data.Rows[0];
            //        MaHopDong = ((decimal)row["MAHOPDONG"]).ToString();
            //        NgayLap = ((DateTime)row["NGAYKI"]).ToString();
            //        NgayHetHan = ((DateTime)row["NGAYHETHAN"]).ToString();
            //    } else
            //    {
            //        MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau1");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau");
            //}



        }

        #region Properties
        private string _maHopDong;
        private string _ngayLap;
        private string _ngayHetHan;
        private DateTime _ngayGiaHan;

        private void HopDongListItem_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "update qlhsut.qlhsut_hop_dong_dang_tuyen set ngayhethan = :SelectedDate where mahopdong = :HopDong";
                DataProvider.Instance.ExecuteNonQuery(sql, [this._ngayGiaHan, this._maHopDong]);
                MessageBox.Show("Gia hạn thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ngayGiaHan_ValueChanged(object sender, EventArgs e)
        {
            _ngayGiaHan = ngayGiaHan.Value;
        }

        [Category("Custom Props")]
        public string MaHopDong
        {
            get { return _maHopDong; }
            set { _maHopDong = value; maHopDongTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; ngayLapTxt.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime NgayGiaHan
        {
            get { return _ngayGiaHan; }
            set { _ngayGiaHan = value; ngayGiaHan.Value = value; }
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
