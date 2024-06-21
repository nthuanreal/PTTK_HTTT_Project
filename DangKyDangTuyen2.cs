using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform
{
    public partial class DangKyDangTuyen2 : Form
    {
        public DangKyDangTuyen2()
        {
            InitializeComponent();
        }
        private void DangKyDangTuyen2_Load(object sender, EventArgs e)
        {
            CenterPanel();
            NavBar();
        }

        private void DangKyDangTuyen2_Resize(object sender, EventArgs e)
        {
            NavBar();
            CenterPanel();
        }
        private void NavBar()
        {
            panelNavbar.Left = 0;
            panelNavbar.Top = 0;
            panelNavbar.Height = 60;
            panelNavbar.Width = this.ClientSize.Width;
        }
        private void CenterPanel()
        {
            this.panelRegister.Left = (this.ClientSize.Width - this.panelRegister.Width) / 2;
            this.panelRegister.Top = (this.ClientSize.Height - this.panelRegister.Height) / 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyDangTuyen1 dkDangTuyenForm = new DangKyDangTuyen1();
            dkDangTuyenForm.FormClosed += (s, args) => this.Close();
            dkDangTuyenForm.Show();
        }
    }
}
