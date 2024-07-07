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
    public partial class ChiTietTTDT : Form
    {
        public ChiTietTTDT()
        {
            InitializeComponent();
        }

        PhieuDKDT phieuDKDT = new PhieuDKDT();
        public ChiTietTTDT(PhieuDKDT phieuDKDT)
        {
            InitializeComponent();
            this.phieuDKDT = phieuDKDT;
        }

        private void ChiTietTTDT_Load(object sender, EventArgs e)
        {
            VTDT_TxtBox.Text = phieuDKDT.vitri;
            SLDT_TxtBox.Text = phieuDKDT.soluong;
            MTCV_TxtBox.Text = phieuDKDT.mota;
            YCUV_TxtBox.Text = phieuDKDT.yeucau;
            NgayBD_TxtBox.Text = phieuDKDT.ngaybd;
            NgayKT_TxtBox.Text = phieuDKDT.ngaykt;
            TTD_TxtBox.Text = phieuDKDT.tinhtrangduyet;

            VTDT_TxtBox.ReadOnly = true;
            SLDT_TxtBox.ReadOnly = true;
            MTCV_TxtBox.ReadOnly = true;
            YCUV_TxtBox.ReadOnly = true;
            NgayBD_TxtBox.ReadOnly = true;
            NgayKT_TxtBox.ReadOnly = true;
            TTD_TxtBox.ReadOnly = true;
        }
    }
}
