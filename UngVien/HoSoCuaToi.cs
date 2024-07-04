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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UI_winform
{
    public partial class HoSoCuaToi : Form
    {
        private int maUV;
        public HoSoCuaToi(int maUV)
        {
            InitializeComponent();
            this.maUV = maUV;
            Load_data();
            
        }

        private void Load_data()
        {
            //, YEUCAU_UNGVIEN, LUONG
            string query = "select * FROM QLHSUT.QLHSUT_HO_SO_UNG_TUYEN where MAUV = :mauv";
            object[] parameters = { maUV };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            dataGridView1.DataSource = data;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int madtValue = Convert.ToInt32(selectedRow.Cells["MADT"].Value);
            // MessageBox.Show($"MADT value clicked: {madtValue}");
            NopHoSo01 hs01 = new NopHoSo01(maUV, madtValue);
            this.Hide();
            hs01.Show();
        }

        

        private void TraCuuViTriUngTuyen_Load(object sender, EventArgs e)
        {

        }

        private void DropdownButton_Click(object sender, EventArgs e)
        {
            // Toggle visibility of options panel
            optionsPanel.Visible = !optionsPanel.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatThongTinUV cntt = new CapNhatThongTinUV(maUV);
            this.Hide();
            cntt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraCuuViTriUngTuyen ttvt = new TraCuuViTriUngTuyen(maUV);
            ttvt.Show();
            this.Hide();
        }
    }
}
