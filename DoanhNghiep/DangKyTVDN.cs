using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UI_winform.DAO;

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
            if ( txtAddress.Text != null
                && txtCompanyName.Text != null
                && txtEmail.Text != null    
                && txtPhone.Text != null
                && txtRepresentative.Text != null
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
                    insert_Company(NDD);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký, vui lòng thức hiện lại.");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private int insert_Representative()
        {
            String HOTEN = textBox1.Text;
            String NGSINH = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            String DIACHI = textBox4.Text;
            String SDT = textBox5.Text;
            String EMAIL = txtEmail.Text;
            String GIOITINH;
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
            int MANDD = GetNewID("QLHSUT_NGUOI_DAI_DIEN","MANDD");
            string query = @"INSERT INTO QLHSUT.QLHSUT_NGUOI_DAI_DIEN
                    (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) 
                    VALUES(:MANDD, :HOTEN, TO_DATE(:NGSINH, 'YYYY-MM-DD'), :GIOITINH, :SDT, :DIACHI, :EMAIL)";

            // Parameters for the query
            object[] parameters = { MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL};
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return MANDD;
        }
        private void insert_Company(int NDD)
        {
            int MADN = GetNewID("QLHSUT_DOANH_NGHIEP", "MADN");

            String TENDN = txtCompanyName.Text;
            String MASOTHUE = txtTaxID.Text;
            String DIACHI = txtAddress.Text;
            String SDT = txtPhone.Text;
            String EMAIL = txtEmail.Text;
            string query = @"INSERT INTO QLHSUT.QLHSUT_DOANH_NGHIEP
                    (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) 
                    VALUES(:MADN, :TENDN, :MASOTHUE, :NDD, :SDT, :DIACHI, :EMAIL)";

            // Parameters for the query
            object[] parameters = { MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL};
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public int GetNewID(string tableName, string idType)
        {
            string query = $"SELECT MIN(t1.{idType} + 1) FROM {tableName} t1 LEFT JOIN {tableName} t2 ON t1.{idType} + 1 = t2.{idType} WHERE t2.{idType} IS NULL";
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
