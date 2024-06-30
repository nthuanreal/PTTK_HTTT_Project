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

namespace UI_winform
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void hopDongBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            string query = "select * from qlhsut_hop_dong_dang_tuyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int n = data.Rows.Count;
            HopDongListItem[] hopDongListItems = new HopDongListItem[n];

            for (int i = 0; i < n; i++)
            {
                DataRow row = data.Rows[i];
                hopDongListItems[i].MaHopDong = (string)row["MAHOPDONG"];

                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //} else
                //{
                flowLayoutPanel1.Controls.Add(hopDongListItems[i]);
                //}
            }
        }
    }

}
