﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class ThongTinDTItem : UserControl
    {
        public ThongTinDTItem()
        {
            InitializeComponent();
        }

        PhieuDKDT ttdt = new PhieuDKDT();
        public ThongTinDTItem(PhieuDKDT ttdt)
        {
            InitializeComponent();
            this.ttdt = ttdt;
        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            MDT_TxtBox.Text = ttdt.madt;
            MHD_TxtBox.Text = ttdt.mahopdong;
            TT_TxtBox.Text = ttdt.tinhtrangduyet;
            NgayBD_TxtBox.Text = ttdt.ngaybd;
            NgayKT_TxtBox.Text = ttdt.ngaykt;
            VTTD_TxtBox.Text = ttdt.vitri;

            MDT_TxtBox.ReadOnly = true;
            MHD_TxtBox.ReadOnly = true;
            TT_TxtBox.ReadOnly = true;
            NgayBD_TxtBox.ReadOnly = true;
            NgayKT_TxtBox.ReadOnly = true;
            VTTD_TxtBox.ReadOnly = true;
        }

        private void NewItem_Click(object sender, EventArgs e)
        {
            ChiTietTTDT chitiet = new ChiTietTTDT(ttdt);
            chitiet.ShowDialog();
        }
    }
}