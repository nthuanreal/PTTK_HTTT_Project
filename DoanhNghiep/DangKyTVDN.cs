
using System.Net.Mail;
using System.Net;
using UI_winform.DAO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI_winform
{
    public partial class DangKyTVDN : Form
    {
        public DangKyTVDN()
        {
            InitializeComponent();
        }

        private void DangKyTVDN_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void DangKyTVDN_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            this.panelRegister.Left = (this.ClientSize.Width - this.panelRegister.Width) / 2;
            this.panelRegister.Top = (this.ClientSize.Height - this.panelRegister.Height) / 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != null
                && txtCompanyName.Text != null
                && txtEmail.Text != null
                && txtPhone.Text != null
                //&& txtRepresentative.Text != null
                && txtTaxID.Text != null
                && textBox1.Text != null
                && dateTimePicker1.Value.ToString() != null
                && textBox4.Text != null
                && textBox5.Text != null
                && (checkBox1.Checked || checkBox2.Checked))
            {
                try
                {
                    int NDD = insert_Representative();
                    int MADN = insert_Company(NDD);
                    createCompanyAcc(MADN);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký, vui lòng thức hiện lại." + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private int insert_Representative()
        {
            try
            {
                string HOTEN = textBox1.Text;
                string NGSINH = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string DIACHI = textBox4.Text;
                string SDT = textBox5.Text;
                string EMAIL = txtEmail.Text;
                string GIOITINH;
                if (checkBox1.Checked || checkBox2.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        GIOITINH = "Nam";
                    }
                    else
                    {
                        GIOITINH = "Nữ";
                    }
                }
                else
                {
                    GIOITINH = "Khác";
                }
                int MANDD = GetNewID("QLHSUT.QLHSUT_NGUOI_DAI_DIEN", "MANDD");
                string query = @"INSERT INTO QLHSUT.QLHSUT_NGUOI_DAI_DIEN
                    (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) 
                    VALUES(:MANDD, :HOTEN, TO_DATE(:NGSINH, 'yyyy-MM-dd'), :GIOITINH, :SDT, :DIACHI, :EMAIL)";

                // Parameters for the query
                object[] parameters = { MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL };
                DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return MANDD;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private int insert_Company(int NDD)
        {
            try
            {
                int MADN = GetNewID("QLHSUT.QLHSUT_DOANH_NGHIEP", "MADN");

                string TENDN = txtCompanyName.Text;
                string MASOTHUE = txtTaxID.Text;
                string DIACHI = txtAddress.Text;
                string SDT = txtPhone.Text;
                string EMAIL = txtEmail.Text;
                string query = @"INSERT INTO QLHSUT.QLHSUT_DOANH_NGHIEP
                    (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) 
                    VALUES(:MADN, :TENDN, :MASOTHUE, :NDD, :SDT, :DIACHI, :EMAIL)";

                // Parameters for the query
                object[] parameters = { MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL };
                DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return MADN;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;

            }
        }

        private void createCompanyAcc(int madn)
        {
            string username = madn.ToString();
            string sql = $"CREATE USER \"{username}\" IDENTIFIED BY 123456";
            DataProvider.Instance.ExecuteNonQuery(sql);
            string grant_sql = $"GRANT CONNECT, RESOURCE, RESTRICTED SESSION TO \"{username}\"";
            DataProvider.Instance.ExecuteNonQuery(grant_sql);
            string grant_role = $"GRANT RL_QLHSUT_DOANHNGHIEP TO \"{username}\"";
            DataProvider.Instance.ExecuteNonQuery(grant_role);
        }



        public int GetNewID(string tableName, string idType)
        {
            string query = $"SELECT MIN(t1.{idType} + 1) FROM {tableName} t1 LEFT JOIN {tableName} t2 ON t1.{idType} + 1 = t2.{idType} WHERE t2.{idType} IS NULL";
            //MessageBox.Show(query);
            int x = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
            return x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}