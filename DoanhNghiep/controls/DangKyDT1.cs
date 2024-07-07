using System.Windows.Forms;
using UI_winform.User.Home;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class DangKyDT1 : UserControl
    {
        HOMEDN home = new HOMEDN();
        public DangKyDT1(HOMEDN Home)
        {
            InitializeComponent();
            this.home = Home;
        }

        public DangKyDT1()
        {
            InitializeComponent();
        }

        PhieuDKDT phieuDKDT = new PhieuDKDT();
        private void setPhieuDKDT()
        {
            phieuDKDT.vitri = VTDT_TxtBox.Text;
            phieuDKDT.soluong = SLDT_TxtBox.Text;
            phieuDKDT.mota = MTCV_TxtBox.Text;
            phieuDKDT.yeucau = YCUV_TxtBox.Text;
        }

        private void Huy_Btn_Click(object sender, EventArgs e)
        {
            ThongTinDN TTTV = new ThongTinDN();
            home.splitContainer1.Panel2.Controls.Clear();
            home.splitContainer1.Panel2.Controls.Add(TTTV);
            TTTV.Dock = DockStyle.Fill;
            TTTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTTV.Size = home.splitContainer1.Panel2.ClientSize;
        }

        private void TiepTuc_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VTDT_TxtBox.Text) ||
                string.IsNullOrWhiteSpace(SLDT_TxtBox.Text) ||
                string.IsNullOrWhiteSpace(MTCV_TxtBox.Text) ||
                string.IsNullOrWhiteSpace(YCUV_TxtBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi qua bước tiếp theo.");
                return;
            }

            int number;
            if (!int.TryParse(SLDT_TxtBox.Text, out number))
            {
                MessageBox.Show("Vui lòng điền số lượng tuyển dụng là số nguyên.");
                return;
            }

            setPhieuDKDT();
            DangKyDT2 DKDT2 = new DangKyDT2(this, home, phieuDKDT);
            home.splitContainer1.Panel2.Controls.Add(DKDT2);
            home.splitContainer1.Panel2.Controls.SetChildIndex(DKDT2, 0);
            DKDT2.Dock = DockStyle.Fill;
            DKDT2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT2.Size = home.splitContainer1.Panel2.ClientSize;
        }

        private void TTDT_Btn_Click(object sender, EventArgs e)
        {
            DSThongTinDangTuyen TTDT = new DSThongTinDangTuyen();
            home.splitContainer1.Panel2.Controls.Clear();
            home.splitContainer1.Panel2.Controls.Add(TTDT);
            TTDT.Dock = DockStyle.Fill;
            TTDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTDT.Size = home.splitContainer1.Panel2.ClientSize;
        }
    }
}
