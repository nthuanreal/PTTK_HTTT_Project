using UI_winform.User.Home;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class DangKyDT2 : UserControl
    {
        HOMEDN home = new HOMEDN();
        DangKyDT1 DKDT1 = new DangKyDT1();
        PhieuDKDT phieuDKDT = new PhieuDKDT();
        public DangKyDT2(DangKyDT1 dkdt1, HOMEDN Home)
        {
            InitializeComponent();
            this.DKDT1 = dkdt1;
            this.home = Home;
        }

        public DangKyDT2(DangKyDT1 dkdt1, HOMEDN Home, PhieuDKDT phieuDKDT)
        {
            InitializeComponent();
            this.DKDT1 = dkdt1;
            this.home = Home;
            this.phieuDKDT = phieuDKDT;
        }

        public DangKyDT2()
        {
            InitializeComponent();
        }

        private void QuayLai_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.SetChildIndex(this, 1);
            DKDT1.Dock = DockStyle.Fill;
            DKDT1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT1.Size = home.splitContainer1.Panel2.ClientSize;
        }

        private void setPhieuDKDT()
        {
            phieuDKDT.ngaybd = NgayBD_Picker.Value.ToString("dd-MM-yyyy");
            phieuDKDT.ngaykt = NgayKT_Picker.Value.ToString("dd-MM-yyyy");

            string checkedText = string.Empty;
            checkedText = string.Join("|", HTDT_ListBox.CheckedItems.Cast<object>().Select(item => item.ToString()));
            phieuDKDT.hinhthucluachon = checkedText;
        }

        private void DangKy_Btn_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (object item in HTDT_ListBox.CheckedItems)
            {
                count += 1;
            }

            if (NgayBD_Picker.Value >= NgayKT_Picker.Value)
            {
                MessageBox.Show("Vui lòng chọn thời gian đăng tuyển hợp lệ!");
                return;
            }

            if (count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 hình thức đăng tuyển!");
                return;
            }

            setPhieuDKDT();
            LapPhieuDKDT PhieuDKDT = new LapPhieuDKDT(home, phieuDKDT);
            home.splitContainer1.Panel2.Controls.Add(PhieuDKDT);
            home.splitContainer1.Panel2.Controls.SetChildIndex(PhieuDKDT, 0);
            PhieuDKDT.Dock = DockStyle.Fill;
            PhieuDKDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhieuDKDT.Size = home.splitContainer1.Panel2.ClientSize;
        }
    }
}
