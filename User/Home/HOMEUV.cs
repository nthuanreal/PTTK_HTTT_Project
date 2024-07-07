using UI_winform.User.Login;
using UI_winform.Utils;
using UI_winform.utils;
using System.Windows.Forms;

namespace UI_winform
{
    public partial class HOMEUV : Form
    {
        NavigationControl navigationControl;
        private int mauv;
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.Teal;
        public string role;
        bool isLogout = false;

        public HOMEUV(int mauv)
        {
            this.mauv = mauv;
            InitializeComponent();
            SwitchUserControl(new HoSoCuaToi(mauv));
            //InitializeNavigationControl();
        }

        DangNhap curLogin = new DangNhap();
        public HOMEUV(DangNhap CurLogin)
        {
            curLogin = CurLogin;
            this.mauv = int.Parse(Session.Instance.Username);
            //MessageBox.Show(this.mauv.ToString());// debug line
            InitializeComponent();
            SwitchUserControl(new HoSoCuaToi(mauv));
            //InitializeNavigationControl();
        }

        private void DangXuat_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult dg;
            if (isLogout)
            {
                dg = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            switch (dg)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    if (isLogout)
                    {
                        curLogin.con.Close();
                        curLogin.Show();
                    }
                    break;
            }
        }


        private void HOMEUV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void InitializeNavigationControl()
        {
            TraCuuViTriUngTuyen tcut = new TraCuuViTriUngTuyen(mauv);
            HoSoCuaToi hs = new HoSoCuaToi(mauv);
            CapNhatThongTinUV ttuv = new CapNhatThongTinUV(mauv);
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            {ttuv,tcut, hs};
            navigationControl = new NavigationControl(userControls, content); // create an instance of NavigationControl class
            navigationControl.Display(0);
        }
        public void SwitchUserControl(UserControl newControl)
        {
            // Clear the current controls from the panel
            content.Controls.Clear();


            // Add the new UserControl to the panel
            content.Controls.Add(newControl);

            // Set the Dock style to fill the panel
            newControl.Dock = DockStyle.Fill;
            newControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newControl.Size = content.ClientSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(0);
            SwitchUserControl(new CapNhatThongTinUV(mauv));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(1);
            SwitchUserControl(new TraCuuViTriUngTuyen(mauv));
        }
        //Nộp hồ sơ
        private void button3_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(2);
            SwitchUserControl(new HoSoCuaToi(mauv));
        }
        //Đổi mật khẩu
        private void button4_Click(object sender, EventArgs e)
        {

            DoiMatKhau newPage = new DoiMatKhau();
            newPage.ShowDialog();
        }


        
    }
}