using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DoanhNghiep;
using UI_winform.DoanhNghiep.controls;
using UI_winform.User.Home;

namespace UI_winform.DoanhNghiep
{
    public partial class UuDai : UserControl
    {
        public UuDai()
        {
            InitializeComponent();

        }

        HOMEDN home = new HOMEDN();
        public UuDai(HOMEDN Home)
        {
            InitializeComponent();
            this.home = Home;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKyNgay_Btn_Click(object sender, EventArgs e)
        {
            DangKyDT1 DKDT1 = new DangKyDT1(home);
            home.splitContainer1.Panel2.Controls.Clear();
            home.splitContainer1.Panel2.Controls.Add(DKDT1);
            DKDT1.Dock = DockStyle.Fill;
            DKDT1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT1.Size = home.splitContainer1.Panel2.ClientSize;
        }
    }
}
