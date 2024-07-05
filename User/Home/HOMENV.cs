using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.User.Home
{
    public partial class HOMENV : Form
    {
        public HOMENV()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap newWindow = new DangNhap();
            this.FormClosing += (s, args) => newWindow.Show();
            this.Close();
        }
    }
}
