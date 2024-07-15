using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;

namespace UI_winform.NhanVien
{
    public partial class ThongTinDoanhNghep : Form
    {
        public ThongTinDoanhNghep()
        {
            InitializeComponent();
        }
        public ThongTinDoanhNghep(string madn)
        {
            MaDn = madn;
            InitializeComponent();
            fetchData(MaDn);
        }

        private void fetchData(string madn)
        {
            string sql = $"select dn.madn, dn.tendn, dn.email as emaildn, dn.masothue, dn.ndd, dn.sdt as sdtdn, dn.diachi as diachidn, ndd.hoten as hoten, ndd.ngsinh, ndd.gioitinh, ndd.diachi as diachindd, ndd.email as emailndd \r\nfrom qlhsut.qlhsut_doanh_nghiep dn join qlhsut.qlhsut_nguoi_dai_dien ndd on dn.ndd = ndd.mandd\r\nwhere TO_CHAR(dn.madn) = '{madn}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Lỗi hệ thống, quay lại sau");
            }
            DataRow dataRow = dt.Rows[0];
            MaDn = ((decimal)dataRow["MADN"]).ToString();
            TenDn = dataRow["TENDN"].ToString();
            MaSoThue = dataRow["MASOTHUE"].ToString();
            DiaChi = dataRow["DIACHIDN"].ToString();
            EmailLienHe = dataRow["EMAILDN"].ToString();
            Sdt = dataRow["SDTDN"].ToString();
            MaNguoiDaiDien = ((decimal)dataRow["NDD"]).ToString();
            TenNguoiDaiDien = dataRow["HOTEN"].ToString();
            NgaySinh = dataRow["NGSINH"].ToString();
            GioiTinh = dataRow["GIOITINH"].ToString();
            DiaChiNguoiDaiDien = dataRow["DIACHINDD"].ToString();

        }

        #region Properties
        private string _maDn;
        private string _tenDn;
        private string _maSoThue;
        private string _diaChi;
        private string _sdt;
        private string _emailLienHe;
        private string _maNguoiDaiDien;
        private string _tenNguoiDaiDien;
        private string _maDinhDanh;
        private string _gioiTinh;
        private string _ngaySinh;
        private string _diaChiNguoiDaiDien;
        private string _sdtNguoiDaiDien;

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM qlhsut.qlhsut_doanh_nghiep WHERE MADN = {MaDn}";
                DataProvider.Instance.ExecuteNonQuery(sql);

                string drop_user = $"DROP USER \"{MaDn}\" CASCADE";
                DataProvider.Instance.ExecuteNonQuery(drop_user);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE qlhsut.qlhsut_doanh_nghiep SET tttaikhoan = 1 where madn = {MaDn}";
                DataProvider.Instance.ExecuteNonQuery(sql);
                sendEmail(MaDn, EmailLienHe);
                MessageBox.Show("Duyệt thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau");
            }
            finally
            {
                this.Close();
            }

        }

        private void sendEmail(string username, string email)
        {
            try
            {
                string from, to, content;
                from = "websitepttk@outlook.com";
                to = email;
                content = "Thông tin đăng ký của bạn đã được duyệt. \nBây giờ bạn có thể đăng nhập vào tài khoản doanh nghiệp của mình với: \n"
                            + "Tên tài khoản: " + username + "\nMật khẩu: 123456"
                            + "\n *** Khuyến nghị: Bạn nên đổi mật khẩu khi đăng nhập thành công lần đầu tiên.";
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "ĐĂNG KÝ THÀNH VIÊN DOANH NGHIỆP THÀNH CÔNG";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, "pttkhttt_PTTKHTTT_NHOM2");

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Category("Custom Props")]
        public string MaDn { get => _maDn; set => _maDn = value; }
        [Category("Custom Props")]
        public string TenDn { get => _tenDn; set { _maSoThue = value; tenDoanhNghiepTxt.Text = value; } }
        [Category("Custom Props")]
        public string MaSoThue { get => _maSoThue; set { _maSoThue = value; maSoThueTxt.Text = value; } }
        [Category("Custom Props")]
        public string DiaChi { get => _diaChi; set { _diaChi = value; diaChiTxt.Text = value; } }
        [Category("Custom Props")]
        public string Sdt { get => _sdt; set { _sdt = value; sdtTxt.Text = value; } }
        [Category("Custom Props")]
        public string EmailLienHe { get => _emailLienHe; set { _emailLienHe = value; emailLienHeTxt.Text = value; } }
        [Category("Custom Props")]
        public string MaNguoiDaiDien { get => _maNguoiDaiDien; set { _maNguoiDaiDien = value; } }
        [Category("Custom Props")]
        public string TenNguoiDaiDien { get => _tenNguoiDaiDien; set { _tenNguoiDaiDien = value; nguoiDaiDienTxt.Text = value; } }

        [Category("Custom Props")]
        public string GioiTinh
        {
            get => _gioiTinh;
            set
            {
                _gioiTinh = value;
                if (value == "Nam")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
        }
        [Category("Custom Props")]
        public string NgaySinh { get => _ngaySinh; set { _ngaySinh = value; ngaySinhTxt.Text = value; } }
        [Category("Custom Props")]
        public string DiaChiNguoiDaiDien { get => _diaChiNguoiDaiDien; set { _diaChiNguoiDaiDien = value; diaChiNddTxt.Text = value; } }
        [Category("Custom Props")]
        public string SdtNguoiDaiDien { get => _sdtNguoiDaiDien; set { _sdtNguoiDaiDien = value; sdtNddTxt.Text = value; } }
        #endregion
    }
}
