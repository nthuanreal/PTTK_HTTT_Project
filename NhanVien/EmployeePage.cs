using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.controls;
using UI_winform.DAO;
using UI_winform.NhanVien.controls;

namespace UI_winform
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {

        }



        private void EmployeePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void xuLyHopDong1_Load(object sender, EventArgs e)
        {

        }

        private void hoSoBtn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HoSoUngVien());
        }

        private void giaHanBtn_Click(object sender, EventArgs e)
        {

        }
    }


}
