namespace UI_winform.NhanVien
{
    partial class PhieuDangKyQuangCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            TuChoi_Button = new Button();
            Tao_button = new Button();
            Huy_button = new Button();
            TenDoanhNghiep_Textbox = new TextBox();
            ViTriUngTuyen_Textbox = new TextBox();
            SoLuongUngTuyen_Textbox = new TextBox();
            MoTaCongViec_Textbox = new TextBox();
            YeuCauUngVien_Textbox = new TextBox();
            HinhThucDangTuyenDung_Textbox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            Date_From = new Label();
            label9 = new Label();
            label11 = new Label();
            Exit_Button = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(142, 87);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Doanh nghiệp";
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(142, 141);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Vị trí ứng tuyển";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(142, 193);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng ứng tuyển";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(142, 248);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 4;
            label5.Text = "Mô tả công việc";
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 308);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "Yêu cầu ứng viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(584, 57);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU ĐĂNG KÝ QUẢNG CÁO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // TuChoi_Button
            // 
            TuChoi_Button.BackColor = Color.IndianRed;
            TuChoi_Button.Location = new Point(269, 544);
            TuChoi_Button.Name = "TuChoi_Button";
            TuChoi_Button.Size = new Size(108, 36);
            TuChoi_Button.TabIndex = 1;
            TuChoi_Button.Text = "Từ chối";
            TuChoi_Button.UseVisualStyleBackColor = false;
            // 
            // Tao_button
            // 
            Tao_button.BackColor = Color.LimeGreen;
            Tao_button.Location = new Point(438, 544);
            Tao_button.Name = "Tao_button";
            Tao_button.Size = new Size(103, 36);
            Tao_button.TabIndex = 2;
            Tao_button.Text = "Tạo";
            Tao_button.UseVisualStyleBackColor = false;
            // 
            // Huy_button
            // 
            Huy_button.BackColor = Color.DarkOrange;
            Huy_button.Location = new Point(602, 544);
            Huy_button.Name = "Huy_button";
            Huy_button.Size = new Size(109, 36);
            Huy_button.TabIndex = 3;
            Huy_button.Text = "Hủy";
            Huy_button.UseVisualStyleBackColor = false;
            // 
            // TenDoanhNghiep_Textbox
            // 
            TenDoanhNghiep_Textbox.Anchor = AnchorStyles.Left;
            TenDoanhNghiep_Textbox.BackColor = SystemColors.Window;
            TenDoanhNghiep_Textbox.Location = new Point(343, 84);
            TenDoanhNghiep_Textbox.Name = "TenDoanhNghiep_Textbox";
            TenDoanhNghiep_Textbox.Size = new Size(541, 27);
            TenDoanhNghiep_Textbox.TabIndex = 4;
            // 
            // ViTriUngTuyen_Textbox
            // 
            ViTriUngTuyen_Textbox.Anchor = AnchorStyles.Left;
            ViTriUngTuyen_Textbox.BackColor = SystemColors.Window;
            ViTriUngTuyen_Textbox.Location = new Point(343, 138);
            ViTriUngTuyen_Textbox.Name = "ViTriUngTuyen_Textbox";
            ViTriUngTuyen_Textbox.Size = new Size(541, 27);
            ViTriUngTuyen_Textbox.TabIndex = 5;
            ViTriUngTuyen_Textbox.TextChanged += ViTriUngTuyen_Textbox_TextChanged;
            // 
            // SoLuongUngTuyen_Textbox
            // 
            SoLuongUngTuyen_Textbox.Anchor = AnchorStyles.Left;
            SoLuongUngTuyen_Textbox.BackColor = SystemColors.Window;
            SoLuongUngTuyen_Textbox.Location = new Point(343, 190);
            SoLuongUngTuyen_Textbox.Name = "SoLuongUngTuyen_Textbox";
            SoLuongUngTuyen_Textbox.Size = new Size(541, 27);
            SoLuongUngTuyen_Textbox.TabIndex = 6;
            // 
            // MoTaCongViec_Textbox
            // 
            MoTaCongViec_Textbox.Anchor = AnchorStyles.Left;
            MoTaCongViec_Textbox.BackColor = SystemColors.Window;
            MoTaCongViec_Textbox.Location = new Point(343, 245);
            MoTaCongViec_Textbox.Name = "MoTaCongViec_Textbox";
            MoTaCongViec_Textbox.Size = new Size(541, 27);
            MoTaCongViec_Textbox.TabIndex = 7;
            MoTaCongViec_Textbox.TextChanged += MoTaCongViec_Textbox_TextChanged;
            // 
            // YeuCauUngVien_Textbox
            // 
            YeuCauUngVien_Textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            YeuCauUngVien_Textbox.BackColor = SystemColors.Window;
            YeuCauUngVien_Textbox.Location = new Point(343, 305);
            YeuCauUngVien_Textbox.Multiline = true;
            YeuCauUngVien_Textbox.Name = "YeuCauUngVien_Textbox";
            YeuCauUngVien_Textbox.Size = new Size(541, 67);
            YeuCauUngVien_Textbox.TabIndex = 8;
            // 
            // HinhThucDangTuyenDung_Textbox
            // 
            HinhThucDangTuyenDung_Textbox.BackColor = SystemColors.Window;
            HinhThucDangTuyenDung_Textbox.Location = new Point(343, 474);
            HinhThucDangTuyenDung_Textbox.Name = "HinhThucDangTuyenDung_Textbox";
            HinhThucDangTuyenDung_Textbox.Size = new Size(541, 27);
            HinhThucDangTuyenDung_Textbox.TabIndex = 10;
            HinhThucDangTuyenDung_Textbox.TextChanged += HinhThucDangTuyenDung_Textbox_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(132, 408);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 0;
            label7.Text = "Thời gian đăng tuyển";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(132, 477);
            label8.Name = "label8";
            label8.Size = new Size(189, 20);
            label8.TabIndex = 1;
            label8.Text = "Hình thức đăng tuyển dụng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 408);
            label10.Name = "label10";
            label10.Size = new Size(29, 20);
            label10.TabIndex = 13;
            label10.Text = "Từ:";
            // 
            // Date_From
            // 
            Date_From.AutoEllipsis = true;
            Date_From.AutoSize = true;
            Date_From.Location = new Point(378, 408);
            Date_From.Name = "Date_From";
            Date_From.Size = new Size(85, 20);
            Date_From.TabIndex = 14;
            Date_From.Text = "2024/12/01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(553, 408);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 15;
            label9.Text = "Đến:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(598, 408);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 16;
            label11.Text = "2024/12/31";
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.Red;
            Exit_Button.Location = new Point(899, 9);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(44, 31);
            Exit_Button.TabIndex = 17;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = false;
            // 
            // PhieuDangKyQuangCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 641);
            Controls.Add(YeuCauUngVien_Textbox);
            Controls.Add(MoTaCongViec_Textbox);
            Controls.Add(SoLuongUngTuyen_Textbox);
            Controls.Add(TenDoanhNghiep_Textbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ViTriUngTuyen_Textbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Exit_Button);
            Controls.Add(HinhThucDangTuyenDung_Textbox);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(Date_From);
            Controls.Add(label10);
            Controls.Add(Huy_button);
            Controls.Add(Tao_button);
            Controls.Add(TuChoi_Button);
            Controls.Add(label1);
            Name = "PhieuDangKyQuangCao";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button TuChoi_Button;
        private Button Tao_button;
        private Button Huy_button;
        private TextBox TenDoanhNghiep_Textbox;
        private TextBox ViTriUngTuyen_Textbox;
        private TextBox SoLuongUngTuyen_Textbox;
        private TextBox MoTaCongViec_Textbox;
        private TextBox YeuCauUngVien_Textbox;
        private TextBox HinhThucDangTuyenDung_Textbox;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label Date_From;
        private Label label9;
        private Label label11;
        private Button Exit_Button;
    }
}