﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;
using UI_winform.User.Home;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UI_winform
{
    public partial class HoSoCuaToi : UserControl
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
            int madtValue = Convert.ToInt32(selectedRow.Cells["MAHS"].Value);
            HOMEUV ungvien = (HOMEUV)this.ParentForm;
            ungvien.SwitchUserControl(new DanhSachBangCap(madtValue, maUV));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tths = textBox2.Text.ToString();
            string trangthai = comboBox1.Text.ToString();
            string reload = "";
            object[] parameters = { maUV, $"%{tths}%", $"%{trangthai}%" };
            if (trangthai != "Tất cả")
            {
                reload = "select * FROM QLHSUT.QLHSUT_HO_SO_UNG_TUYEN where MAUV = :mauv AND THONGTIN_HS LIKE :tths AND TRANGTHAIDUYET LIKE :trangthai";
            }
            else
            {
                reload = "select * FROM QLHSUT.QLHSUT_HO_SO_UNG_TUYEN where MAUV = :mauv AND THONGTIN_HS LIKE :tths";
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(reload, parameters);
            dataGridView1.DataSource = data;
        }
    }
}
