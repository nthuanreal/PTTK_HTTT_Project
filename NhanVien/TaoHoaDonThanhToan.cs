using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;

namespace UI_winform.NhanVien
{
    public partial class TaoHoaDonThanhToan : Form
    {
        private decimal _maHd;

        public decimal MaHd { get => _maHd; set => _maHd = value; }

        public TaoHoaDonThanhToan()
        {
            InitializeComponent();
        }

        public TaoHoaDonThanhToan(decimal maHd)
        {
            InitializeComponent();
            _maHd = maHd;
            populateData();
            getHinhThucDangTuyen();
        }

        private void populateData()
        {
            string query = $"select * \r\nfrom qlhsut.qlhsut_phieu_quang_cao pqc\r\njoin qlhsut.qlhsut_hop_dong_dang_tuyen hd on pqc.mahopdong = hd.mahopdong\r\njoin qlhsut.qlhsut_thong_tin_dang_tuyen dt on hd.madt = dt.madt\r\njoin qlhsut.qlhsut_doanh_nghiep dn on dt.dn_dangtuyen = dn.madn\r\njoin qlhsut.qlhsut_nguoi_dai_dien ndd on dn.ndd = ndd.mandd\r\nwhere hd.mahopdong = {MaHd}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                TenDoanhNghiep_Label.Text = row["TENDN"].ToString();
                ViTriUngTuyen_Label.Text = row["VITRI_UNGTUYEN"].ToString();
                soLuongUngTuyen_label.Text = ((decimal)row["SOLUONG"]).ToString();
                moTaCongViec_label.Text = row["MOTA"].ToString();
                MaSoThue_Label.Text = row["MASOTHUE"].ToString();
                DiaChi_Label.Text = row["DIACHI"].ToString();
                SDT_Label.Text = row["SDT"].ToString();
                EmailLienHe_Label.Text = row["EMAIL"].ToString();
                NguoiDaiDien_Label.Text = row["HOTEN"].ToString();
                YeuCauUngVien_Label.Text = row["YEUCAU_UNGVIEN"].ToString();
                From_Label.Text = ((DateTime)row["TG_BATDAU"]).ToString("dd-MM-yyyy");
                To_Label.Text = ((DateTime)row["TG_KETTHUC"]).ToString("dd-MM-yyyy");

            }
            else
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau");
            }

        }
        private void getHinhThucDangTuyen()
        {
            string query = $"select *\r\nfrom qlhsut.qlhsut_hinh_thuc_lua_chon htlc\r\njoin qlhsut.qlhsut_hinh_thuc_dang_tuyen htdt on htlc.maht = htdt.maht\r\nwhere htlc.mahopdong = {MaHd}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<String?> list = new List<String?>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = (DataRow)data.Rows[i];
                string? hinhThuc = row["TENHINHTHUC"].ToString();
                list.Add(hinhThuc);

            }
            hinhThucDangTuyen_label.Text = string.Join(", ", list.ToArray());
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Huy_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetCheckedRadioButton(GroupBox groupBox)
        {
            string loaithanhtoan = "";
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    loaithanhtoan = radioButton.Text;
                }
            }
            if (loaithanhtoan == "Theo đợt")
            {
                loaithanhtoan = "Thanh toán theo đợt";
            }
            if (loaithanhtoan == "Toàn bộ")
            {
                loaithanhtoan = "Thanh toán một lần";
            }
            return loaithanhtoan;
        }

        private void XacNhan_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string hinhThuc = GetCheckedRadioButton(groupBox1);
                string sql = $"update qlhsut.qlhsut_phieu_quang_cao\r\nset HINHTHUCTHANHTOAN = N'{hinhThuc}'\r\nwhere mahopdong = {MaHd}";
                DataProvider.Instance.ExecuteNonQuery(sql);
                sendEmail();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống");
            }

        }

        private void sendEmail()
        {
            try
            {
                string from, to, content;
                from = "websitepttk@outlook.com";
                to = "21120347@student.hcmus.edu.vn";
                content = "Yêu cầu đăng tuyển của quý khách trị giá: " + ThanhTien_Label.Text + " vnđ";
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "XÁC NHẬN HỢP ĐỒNG ĐĂNG TUYỂN";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string hinhThuc = GetCheckedRadioButton(groupBox1);
                string sql = $"update QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN\r\nset tinhtrang = N'Đã duyệt'\r\nwhere MAHOPDONG = {MaHd}";
                DataProvider.Instance.ExecuteNonQuery(sql);
                
                sql = $"update qlhsut.qlhsut_phieu_quang_cao\r\nset HINHTHUCTHANHTOAN = N'{hinhThuc}'\r\nwhere mahopdong = {MaHd}";
                DataProvider.Instance.ExecuteNonQuery(sql);

                MessageBox.Show("Thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
;