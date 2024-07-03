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

namespace UI_winform
{
    public partial class NopHoSo02 : Form
    {
        private NopHoSo01 NopHoSo01;
        public NopHoSo02(NopHoSo01 copy)
        {
            this.NopHoSo01 = copy;
            InitializeComponent();
            load_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.NopHoSo01.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.NopHoSo01.Close();
            this.Close();
        }
        private void load_data()
        {
            object[] parameters = { this.NopHoSo01.madt };
            string query = "select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN, LUONG FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN where MADT = :MADT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            string MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN, LUONG;

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                MADT = row["MADT"].ToString();
                DN_DANGTUYEN = row["DN_DANGTUYEN"].ToString();
                VITRI_UNGTUYEN = row["VITRI_UNGTUYEN"].ToString();
                SOLUONG = row["SOLUONG"].ToString();
                MOTA = row["MOTA"].ToString();
                YEUCAU_UNGVIEN = row["YEUCAU_UNGVIEN"].ToString();
                LUONG = row["LUONG"].ToString();
                string content = $"Mã đăng tuyển: {MADT}  Doanh nghiệp: {DN_DANGTUYEN} \r\n" +
                                 $"Vị trí: {VITRI_UNGTUYEN}   Số lượng: {SOLUONG}\r\n" +
                                 $"Mô tả: {MOTA}\r\n" +
                                 $"Yêu cầu ứng viên: {YEUCAU_UNGVIEN}\r\n" +
                                 $"Lương: {LUONG}";
                textBox1.Text = content;
            }
        }
    }
}
