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
    public partial class NopHoSo02 : Form
    {
        private NopHoSo01 NopHoSo01;
        public NopHoSo02()
        {
            NopHoSo01 = new NopHoSo01();
            InitializeComponent();
        }
        public NopHoSo02(NopHoSo01 copy)
        {
            this.NopHoSo01 = copy;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.NopHoSo01.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================

            //===========================
            this.NopHoSo01.Close();
            this.Close();
        }
    }
}
