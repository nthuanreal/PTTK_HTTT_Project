using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.DoanhNghiep
{
    public partial class ThanhToanItem : UserControl
    {
        public ThanhToanItem()
        {
            InitializeComponent();
        }

        ThongTinThanhToan thanhtoan = new ThongTinThanhToan();
        public ThanhToanItem(ThongTinThanhToan thanhtoan)
        {
            InitializeComponent();
            this.thanhtoan = thanhtoan;
        }

        private void ThanhToanItem_Load(object sender, EventArgs e)
        {
            MTT_TxtBox.Text = thanhtoan.matt;
            MPQC_TxtBox.Text = thanhtoan.mapqc;
            DTT_TxtBox.Text = thanhtoan.dotthanhtoan;
            Tien_TxtBox.Text = thanhtoan.tongtien;
            TT_TxtBox.Text = thanhtoan.tinhtrang;

            MTT_TxtBox.ReadOnly = true;
            MPQC_TxtBox.ReadOnly = true;
            DTT_TxtBox.ReadOnly = true;
            Tien_TxtBox.ReadOnly = true;
            TT_TxtBox.ReadOnly = true;
        }
    }
}
