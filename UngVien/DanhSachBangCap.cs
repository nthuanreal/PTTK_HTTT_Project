using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UI_winform.User.Home;
using UI_winform.UngVien;

namespace UI_winform
{
    public partial class DanhSachBangCap : UserControl
    {
        public int mauv, mahs;
        private BLL bll = new BLL();
        public DanhSachBangCap(int maHS, int maUV)
        {
            this.mahs = maHS;
            this.mauv = maUV;
            InitializeComponent();
            load_data();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HOMEUV ungvien = (HOMEUV)this.ParentForm;
            ungvien.SwitchUserControl(new HoSoCuaToi(mauv));
        }
        private void load_data()
        {
            dataGridView1.DataSource = bll.getBangCap(this.mahs);
        }

        
    }
}
