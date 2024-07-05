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

        public TaiKhoanListItem(string maDn)
        {
            MaDn = maDn;
            InitializeComponent();
        }

        #region Properties
        private string _maDn;
        private string _tenDoanhNghiep;
        private string _maSoThue;

        [Category("Custom Props")]
        public string MaDn { get => _maDn; set => _maDn = value; }
        [Category("Custom Props")]
        public string TenDoanhNghiep { get => _tenDoanhNghiep; set => _tenDoanhNghiep = value; }
        [Category("Custom Props")]
        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }


        private void TaiKhoanListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
