using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.controls
{
    public partial class HoSoUngVienItem : UserControl
    {
        public HoSoUngVienItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _maHs;
        private string _tenDn;
        private string _viTri;
        private string _trangThaiDuyet;

        private void HopDongListItem_Click(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string MaHs
        {
            get { return _maHs; }
            set { _maHs = value; hopDongTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string TenDn
        {
            get { return _tenDn; }
            set { _tenDn = value; ngayLapTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string ViTri
        {
            get { return _viTri; }
            set { _viTri = value; tinhTrangTxt.Text = value; }
        }

        [Category("Custom Props")]
        public string TrangThaiDuyet
        {
            get { return _trangThaiDuyet; }
            set { _trangThaiDuyet = value; ngayHetHanTxt.Text = value; }
        }
        #endregion
    }
}
