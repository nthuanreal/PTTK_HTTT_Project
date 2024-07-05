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

namespace UI_winform.NhanVien.controls
{
    public partial class DanhSachTaiKhoan : UserControl
    {
        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            string query = "select *\r\nfrom qlhsut.qlhsut_doanh_nghiep\r\nwhere tttaikhoan = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            TaiKhoanListItem[] taiKhoanListItems = new TaiKhoanListItem[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

            }
        }
    }
}
