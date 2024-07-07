using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.Utils;

namespace UI_winform.NhanVien.controls
{
    public partial class XuLyHopDong : UserControl
    {
        private NavigationControl navigationControl;

        public XuLyHopDong()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> controls = new List<UserControl>()
            { new DanhSachTaiKhoan(),new DanhSachHopDong() };
            navigationControl = new NavigationControl(controls, panel1);
            navigationControl.Display(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }
    }
}
