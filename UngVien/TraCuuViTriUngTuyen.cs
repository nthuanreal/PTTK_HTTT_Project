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
    public partial class TraCuuViTriUngTuyen : Form
    {
        private int maUV;
        public TraCuuViTriUngTuyen(int maUV)
        {
            InitializeComponent();
            string query = "select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN";
            Load_data(query);
            selectData();
            BeautifyDataGridView();
            this.maUV = maUV;
        }

        private void Load_data(string query)
        {
            //, YEUCAU_UNGVIEN, LUONG
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            dataGridView1.DataSource = data;
        }
        private void selectData()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "ứng tuyển";
            buttonColumn.UseColumnTextForButtonValue = true; // Display text on the button
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void BeautifyDataGridView()
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            int LUONG_MIN = 0, LUONG_MAX = 999999999;
            if (textBox2.Text != "")
            {
                LUONG_MIN = Convert.ToInt32(textBox2.Text);
            }
            if (textBox3.Text != "")
            {
                LUONG_MAX = Convert.ToInt32(textBox3.Text);
            }
            string query = $"select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE VITRI_UNGTUYEN LIKE '%{comboBox1.Text}%' AND LUONG >= {LUONG_MIN} AND LUONG <= {LUONG_MAX}" +
                $"AND MOTA LIKE '%{textBox1.Text}%'";
            Load_data(query);
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
            HoSoCuaToi hsct = new HoSoCuaToi(maUV);
            hsct.Show();
            this.Hide();
        }
    }
}
