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

namespace UI_winform
{
    public partial class TraCuuViTriUngTuyen : Form
    {
        private int maUV;
        public TraCuuViTriUngTuyen(int maUV)
        {
            InitializeComponent();
            Load_data();
            BeautifyDataGridView();
            this.maUV = maUV;
        }

        private void Load_data()
        {
            //, YEUCAU_UNGVIEN, LUONG
            string query = "select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
           
            dataGridView1.DataSource = data;
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
            // Check if the clicked column is the button column and a valid row
            // Retrieve MADT value from the clicked row
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int madtValue = Convert.ToInt32(selectedRow.Cells["MADT"].Value);

            // Example action: Show MADT value in a message box
            MessageBox.Show($"MADT value clicked: {madtValue}");
            NopHoSo01 hs01 = new NopHoSo01(maUV,madtValue);
            this.Hide();
            hs01.Show();
        }
    }
}
