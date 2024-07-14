﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.User.Home;
using UI_winform.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class DSThongTinDangTuyen : UserControl
    {
        public DSThongTinDangTuyen()
        {
            InitializeComponent();
            dsDKDT = getList();
        }

        HOMEDN home = new HOMEDN();
        public DSThongTinDangTuyen(HOMEDN Home)
        {
            InitializeComponent();
            dsDKDT = getList();
            this.home = Home;
        }

        private void DSThongTinDangTuyen_Load(object sender, EventArgs e)
        {
            ThemDSTTDT();
        }

        private void ThemDSTTDT()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (PhieuDKDT ttdt in dsDKDT)
            {
                ThongTinDTItem item = new ThongTinDTItem(ttdt);
                flowLayoutPanel1.Controls.Add(item); // Add the item to the flow layout panel
                item.Width = flowLayoutPanel1.Width;
                item.Dock = DockStyle.Top;
                item.Margin = new Padding(10);
            }
        }

        List<PhieuDKDT> dsDKDT = new List<PhieuDKDT>();
        private static List<PhieuDKDT> getList()
        {
            List<PhieuDKDT> list = new List<PhieuDKDT>();
            string query_sql = $"select TO_CHAR(tt.MADT) MADT, tt.VITRI_UNGTUYEN VITRI_UNGTUYEN, tt.SOLUONG SOLUONG, tt.MOTA MOTA, tt.YEUCAU_UNGVIEN YEUCAU_UNGVIEN, TO_CHAR(hd.MAHOPDONG) MAHOPDONG, hd.TINHTRANG TINHTRANG, TO_CHAR(qc.TG_BATDAU) TG_BATDAU, TO_CHAR(qc.TG_KETTHUC) TG_KETTHUC "
                                + $"\r\nfrom qlhsut.qlhsut_thong_tin_dang_tuyen tt join qlhsut.qlhsut_hop_dong_dang_tuyen hd on tt.MADT = hd.MADT\r\njoin qlhsut.qlhsut_phieu_quang_cao qc on hd.mahopdong = qc.mahopdong "
                                + $"\r\nwhere tt.dn_dangtuyen = {Session.Instance.Username}";
            //MessageBox.Show(query_sql);
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuDKDT ttdt = new PhieuDKDT();
                        ttdt.madt = reader.IsDBNull(reader.GetOrdinal("MADT")) ? "" : reader.GetString(reader.GetOrdinal("MADT"));
                        ttdt.vitri = reader.IsDBNull(reader.GetOrdinal("VITRI_UNGTUYEN")) ? "" : reader.GetString(reader.GetOrdinal("VITRI_UNGTUYEN"));
                        ttdt.soluong = reader.IsDBNull(reader.GetOrdinal("SOLUONG")) ? "" : reader.GetString(reader.GetOrdinal("SOLUONG"));
                        ttdt.mota = reader.IsDBNull(reader.GetOrdinal("MOTA")) ? "" : reader.GetString(reader.GetOrdinal("MOTA"));
                        ttdt.yeucau = reader.IsDBNull(reader.GetOrdinal("YEUCAU_UNGVIEN")) ? "" : reader.GetString(reader.GetOrdinal("YEUCAU_UNGVIEN"));
                        ttdt.mahopdong = reader.IsDBNull(reader.GetOrdinal("MAHOPDONG")) ? "" : reader.GetString(reader.GetOrdinal("MAHOPDONG"));
                        ttdt.tinhtrangduyet = reader.IsDBNull(reader.GetOrdinal("TINHTRANG")) ? "" : reader.GetString(reader.GetOrdinal("TINHTRANG"));
                        ttdt.ngaybd = reader.IsDBNull(reader.GetOrdinal("TG_BATDAU")) ? "" : reader.GetString(reader.GetOrdinal("TG_BATDAU"));
                        ttdt.ngaykt = reader.IsDBNull(reader.GetOrdinal("TG_KETTHUC")) ? "" : reader.GetString(reader.GetOrdinal("TG_KETTHUC"));
                        list.Add(ttdt);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu!");
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        DangKyDT1 DKDT1;
        private void DangKyTTDT_Btn_Click(object sender, EventArgs e)
        {
            DKDT1 = new DangKyDT1(home);
            home.splitContainer1.Panel2.Controls.Clear();
            home.splitContainer1.Panel2.Controls.Add(DKDT1);
            DKDT1.Dock = DockStyle.Fill;
            DKDT1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT1.Size = home.splitContainer1.Panel2.ClientSize;
            //setDKTD1Size();
        }

        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void TimBtn_Click(object sender, EventArgs e)
        {
            string TinhTrang = TinhTrang_ComBox.Text;
            if (TinhTrang == "Tất cả")
            {
                TinhTrang = "";
            }

            List < PhieuDKDT> list = new List<PhieuDKDT>();
            string query_sql = $"select TO_CHAR(tt.MADT) MADT, tt.VITRI_UNGTUYEN VITRI_UNGTUYEN, tt.SOLUONG SOLUONG, tt.MOTA MOTA, tt.YEUCAU_UNGVIEN YEUCAU_UNGVIEN, TO_CHAR(hd.MAHOPDONG) MAHOPDONG, hd.TINHTRANG TINHTRANG, TO_CHAR(qc.TG_BATDAU) TG_BATDAU, TO_CHAR(qc.TG_KETTHUC) TG_KETTHUC "
                                + $"\r\nfrom qlhsut.qlhsut_thong_tin_dang_tuyen tt join qlhsut.qlhsut_hop_dong_dang_tuyen hd on tt.MADT = hd.MADT\r\njoin qlhsut.qlhsut_phieu_quang_cao qc on hd.mahopdong = qc.mahopdong "
                                + $"\r\nwhere tt.dn_dangtuyen = {Session.Instance.Username} and hd.tinhtrang like N'%{TinhTrang}%'";
            //MessageBox.Show(query_sql);
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuDKDT ttdt = new PhieuDKDT();
                        ttdt.madt = reader.IsDBNull(reader.GetOrdinal("MADT")) ? "" : reader.GetString(reader.GetOrdinal("MADT"));
                        ttdt.vitri = reader.IsDBNull(reader.GetOrdinal("VITRI_UNGTUYEN")) ? "" : reader.GetString(reader.GetOrdinal("VITRI_UNGTUYEN"));
                        ttdt.soluong = reader.IsDBNull(reader.GetOrdinal("SOLUONG")) ? "" : reader.GetString(reader.GetOrdinal("SOLUONG"));
                        ttdt.mota = reader.IsDBNull(reader.GetOrdinal("MOTA")) ? "" : reader.GetString(reader.GetOrdinal("MOTA"));
                        ttdt.yeucau = reader.IsDBNull(reader.GetOrdinal("YEUCAU_UNGVIEN")) ? "" : reader.GetString(reader.GetOrdinal("YEUCAU_UNGVIEN"));
                        ttdt.mahopdong = reader.IsDBNull(reader.GetOrdinal("MAHOPDONG")) ? "" : reader.GetString(reader.GetOrdinal("MAHOPDONG"));
                        ttdt.tinhtrangduyet = reader.IsDBNull(reader.GetOrdinal("TINHTRANG")) ? "" : reader.GetString(reader.GetOrdinal("TINHTRANG"));
                        ttdt.ngaybd = reader.IsDBNull(reader.GetOrdinal("TG_BATDAU")) ? "" : reader.GetString(reader.GetOrdinal("TG_BATDAU"));
                        ttdt.ngaykt = reader.IsDBNull(reader.GetOrdinal("TG_KETTHUC")) ? "" : reader.GetString(reader.GetOrdinal("TG_KETTHUC"));
                        list.Add(ttdt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu!");
                MessageBox.Show(ex.Message);
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (PhieuDKDT ttdt in list)
            {
                ThongTinDTItem TTDTItem = new ThongTinDTItem(ttdt);
                flowLayoutPanel1.Controls.Add(TTDTItem); // Set properties based on recipe object
                TTDTItem.Width = flowLayoutPanel1.Width - 20;
                TTDTItem.Dock = DockStyle.Top;
                TTDTItem.Margin = new Padding(10);
            }

        }
    }
}
