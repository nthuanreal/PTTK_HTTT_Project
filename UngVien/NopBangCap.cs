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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UI_winform.UngVien;

namespace UI_winform
{
    public partial class NopBangCap : UserControl
    {
        public int mahs, mauv;
        private BLL bll = new BLL();
        public NopBangCap(int mahs, int mauv)
        {
            this.mahs = mahs;
            this.mauv = mauv;
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            textBox1.Text = mahs.ToString();
            textBox4.Text = (1400001 + bll.GetRowCount("QLHSUT.QLHSUT_THONG_TIN_BANG_CAP")).ToString();
        }
        private void insert_data()
        {
            int mahs = this.mahs;
            int mabc = 140001 + bll.GetRowCount("QLHSUT.QLHSUT_THONG_TIN_BANG_CAP");
            string tenbc = textBox2.Text;
            string noidung = textBox3.Text;
            string ngayhh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(ngayhh);
            bll.insertBangCap(mahs, mabc, tenbc, noidung, ngayhh);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                insert_data();
                HOMEUV mainForm = (HOMEUV)this.ParentForm;
                mainForm.SwitchUserControl(new NopHoSo03(mauv, mahs));
            }
            catch (Exception ex){
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm bằng"+ ex.Message);
            }
        }
    }
}
