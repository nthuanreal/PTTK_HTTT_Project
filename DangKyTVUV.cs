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
    public partial class DangKyTVUV : Form
    {
        public DangKyTVUV()
        {
            InitializeComponent();
        }

        private void DangKyTVUV_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap loginForm = new DangNhap();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
