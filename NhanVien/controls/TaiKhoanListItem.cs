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
    public partial class TaiKhoanListItem : UserControl
    {
        public TaiKhoanListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _maDn;
        private string _tenDoanhNghiep;
        private string _maSoThue;

        [Category("Custom Props")]
        public string MaDn { get => _maDn; set => _maDn = value; }
        [Category("Custom Props")]
        public string TenDoanhNghiep
        {
            get { return _tenDoanhNghiep; }
            set { _tenDoanhNghiep = value; tenDoanhNghiepTxt.Text = value; }
        }
        [Category("Custom Props")]
        public string MaSoThue
        {
            get { return _maSoThue; }
            set { _maSoThue = value; maSoThueTxt.Text = value; }
        }
        #endregion

        private void TaiKhoanListItem_Load(object sender, EventArgs e)
        {

        }

        private void TaiKhoanListItem_Click(object sender, EventArgs e)
        {
            ThongTinDoanhNghep thongTinDoanhNghep = new ThongTinDoanhNghep(_maDn);
            thongTinDoanhNghep.ShowDialog();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
