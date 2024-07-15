﻿using Oracle.ManagedDataAccess.Client;
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
using UI_winform.UngVien;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI_winform
{
    public partial class DangKyTVUV : Form
    {
        private BLL bll = new BLL();
        private DataProvider data;
        public DangKyTVUV()
        {
            InitializeComponent();
        }

        private void DangKyTVUV_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void DangKyTVUV_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && dateTimePicker1.Value.ToString() != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && comboBox1.Text!=null && (checkBox1.Checked|| checkBox2.Checked))
            {
                try
                {
                    int MAUV = bll.GetRowCount("QLHSUT.QLHSUT_UNG_VIEN") + 1 + 110000;
                    String HOTEN = textBox1.Text;
                    String ngaysinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    String DIACHI = textBox2.Text;
                    String SDT = textBox3.Text;
                    String EMAIL = textBox4.Text;
                    String TRINHDO = comboBox1.Text;
                    String GIOITINH;
                    if (checkBox1.Checked)
                    {
                        GIOITINH = "Nam";
                    }
                    else
                    {
                        GIOITINH = "Nữ";
                    }
                    bll.insert_data(MAUV, HOTEN, ngaysinh, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO);
                    bll.createCandidateAcc(MAUV);
                    sendEmail(MAUV.ToString(), EMAIL);
                    MessageBox.Show("Đăng ký thành công! Vui lòng kiểm tra email để tiến hành đăng nhập.");
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

        private void sendEmail(string username, string email)
        {
            try
            {
                string from, to, content;
                from = "websitepttk@outlook.com";
                to = email;
                content = "Thông tin đăng ký đã được chấp nhận. \nBây giờ bạn có thể đăng nhập vào tài khoản ứng viên của mình với: \n"
                            + "Tên tài khoản: " + username + "\nMật khẩu: 123456"
                            + "\n *** Khuyến nghị: Bạn nên đổi mật khẩu khi đăng nhập thành công lần đầu tiên.";
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "ĐĂNG KÝ THÀNH VIÊN ỨNG VIÊN THÀNH CÔNG";
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
