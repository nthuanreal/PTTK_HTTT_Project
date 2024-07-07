using Oracle.ManagedDataAccess.Client;
using UI_winform.User.Home;
using UI_winform.utils;

namespace UI_winform.DoanhNghiep.controls
{
    public partial class LapPhieuDKDT : UserControl
    {
        HOMEDN home = new HOMEDN();
        PhieuDKDT phieuDKDT = new PhieuDKDT();
        public LapPhieuDKDT()
        {
            InitializeComponent();
        }

        public LapPhieuDKDT(HOMEDN Home)
        {
            InitializeComponent();
            this.home = Home;
        }

        public LapPhieuDKDT(HOMEDN Home, PhieuDKDT phieu)
        {
            InitializeComponent();
            this.home = Home;
            this.phieuDKDT = phieu;
        }

        private void getHTDT()
        {
            string[] hinhthuc = phieuDKDT.hinhthucluachon.Split('|');

            foreach (string item in hinhthuc)
            {
                // remove any leading or trailing whitespace from the item
                string trimmedItem = item.Trim();

                // do something with the trimmed item
                Console.WriteLine(trimmedItem);
            }

        }


        private void Huy_Btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.SetChildIndex(this, 2);
        }

        private void XacNhan_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new OracleCommand();
                cmd.Connection = Session.Instance.OracleConnection;
                cmd.CommandText = "QLHSUT.DN_THEM_TTDT";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("V_MADN", OracleDbType.Int32).Value =int.Parse(Session.Instance.Username);
                cmd.Parameters.Add("V_VITRI", OracleDbType.NVarchar2).Value = VTDT_TxtBox.Text;
                cmd.Parameters.Add("V_SOLUONG", OracleDbType.Int32).Value = int.Parse(SLDT_TxtBox.Text);
                cmd.Parameters.Add("V_MOTA", OracleDbType.NVarchar2).Value = MTCV_TxtBox.Text;
                cmd.Parameters.Add("V_YEUCAU", OracleDbType.NVarchar2).Value = YCUV_TxtBox.Text;
                var outputParam = cmd.Parameters.Add("V_MADANGTUYEN", OracleDbType.Int32);
                outputParam.Direction = System.Data.ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                int V_MADANGTUYEN = int.Parse(cmd.Parameters["V_MADANGTUYEN"].Value.ToString());
                //MessageBox.Show(V_MADANGTUYEN.ToString()); // Debug line


                var cmd2 = new OracleCommand();
                cmd2.Connection = Session.Instance.OracleConnection;
                cmd2.CommandText = "QLHSUT.DN_THEM_MAHD";
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("V_MADT", OracleDbType.Int32).Value = V_MADANGTUYEN;
                var outputParam2 = cmd2.Parameters.Add("V_MAHOPDONG", OracleDbType.Int32);
                outputParam.Direction = System.Data.ParameterDirection.Output;

                cmd2.ExecuteNonQuery();
                int V_MAHOPDONG = int.Parse(cmd2.Parameters["V_MAHOPDONG"].Value.ToString());
                //MessageBox.Show(V_MAHOPDONG.ToString()); // Debug line

                var cmd3 = new OracleCommand();
                cmd3.Connection = Session.Instance.OracleConnection;
                cmd3.CommandText = "QLHSUT.DN_THEM_PHIEUQC";
                cmd3.CommandType = System.Data.CommandType.StoredProcedure;
                cmd3.Parameters.Add("V_MAHD", OracleDbType.Int32).Value = V_MAHOPDONG;
                cmd3.Parameters.Add("V_NGAYBD", OracleDbType.Varchar2).Value = NgayBD_TxtBox.Text;
                cmd3.Parameters.Add("V_NGAYKT", OracleDbType.Varchar2).Value = NgayBD_TxtBox.Text;

                cmd3.ExecuteNonQuery();


                var cmd4 = new OracleCommand();
                cmd4.Connection = Session.Instance.OracleConnection;
                cmd4.CommandText = "QLHSUT.DN_THEM_HINHTHUCDT";
                cmd4.CommandType = System.Data.CommandType.StoredProcedure;
                cmd4.Parameters.Add("V_MAHD", OracleDbType.Int32).Value = V_MAHOPDONG;
                OracleParameter TENHINHTHUC = cmd4.Parameters.Add("V_TENHINHTHUC", OracleDbType.Varchar2);
                string[] hinhthuc = phieuDKDT.hinhthucluachon.Split('|');
                foreach (string item in hinhthuc)
                {
                    TENHINHTHUC.Value = item;
                    cmd4.ExecuteNonQuery();
                }


                MessageBox.Show("Đăng ký thông tin đăng tuyển thành công! Vui lòng chờ nhân viên kiểm duyệt.");
                ThongTinDN TTTV = new ThongTinDN();
                home.splitContainer1.Panel2.Controls.Clear();
                home.splitContainer1.Panel2.Controls.Add(TTTV);
                TTTV.Dock = DockStyle.Fill;
                TTTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                TTTV.Size = home.splitContainer1.Panel2.ClientSize;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở việc thêm ttdt"); // debug line
                MessageBox.Show(ex.Message);
            }
        }

        private void LapPhieuDKDT_Load(object sender, EventArgs e)
        {
            VTDT_TxtBox.Text = phieuDKDT.vitri;
            SLDT_TxtBox.Text = phieuDKDT.soluong;
            MTCV_TxtBox.Text = phieuDKDT.mota;
            YCUV_TxtBox.Text = phieuDKDT.yeucau;
            NgayBD_TxtBox.Text = phieuDKDT.ngaybd;
            NgayKT_TxtBox.Text = phieuDKDT.ngaykt;
            HTDT_TxtBox.Text = phieuDKDT.hinhthucluachon;

            VTDT_TxtBox.ReadOnly = true;
            SLDT_TxtBox.ReadOnly = true;
            MTCV_TxtBox.ReadOnly = true;
            YCUV_TxtBox.ReadOnly = true;
            NgayBD_TxtBox.ReadOnly = true;
            NgayKT_TxtBox.ReadOnly = true;
            HTDT_TxtBox.ReadOnly = true;
        }
    }
}
