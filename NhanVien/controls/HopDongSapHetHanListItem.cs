using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.NhanVien.controls
{
    public partial class HopDongSapHetHanListItem : UserControl
    {
        public HopDongSapHetHanListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _maHopDong;
        private string _ngayLap;
        private string _tinhTrang;
        private string _ngayHetHan;


        private void HopDongSapHetHanListItem_Load(object sender, EventArgs e)
        {

        }

        private void HopDongSapHetHanListItem_Click(object sender, EventArgs e)
        {
            GiaHanForm giaHanForm = new GiaHanForm(_maHopDong);
            giaHanForm.ShowDialog();
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
