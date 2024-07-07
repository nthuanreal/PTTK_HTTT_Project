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
            Date_To = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(178, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Doanh nghiệp";
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(178, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Vị trí ứng tuyển";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(178, 241);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 3;
            label4.Text = "Số lượng ứng tuyển";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(178, 310);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 4;
            label5.Text = "Mô tả công việc";
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 437);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 5;
            label6.Text = "Yêu cầu ứng viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(281, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(692, 67);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU ĐĂNG KÝ QUẢNG CÁO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // TuChoi_Button
            // 
            TuChoi_Button.BackColor = Color.IndianRed;
            TuChoi_Button.Location = new Point(336, 715);
            TuChoi_Button.Margin = new Padding(4);
            TuChoi_Button.Name = "TuChoi_Button";
            TuChoi_Button.Size = new Size(135, 45);
            TuChoi_Button.TabIndex = 1;
            TuChoi_Button.Text = "Từ chối";
            TuChoi_Button.UseVisualStyleBackColor = false;
            TuChoi_Button.Click += TuChoi_Button_Click;
            // 
            // Tao_button
            // 
            Tao_button.BackColor = Color.LimeGreen;
            Tao_button.Location = new Point(548, 715);
            Tao_button.Margin = new Padding(4);
            Tao_button.Name = "Tao_button";
            Tao_button.Size = new Size(129, 45);
            Tao_button.TabIndex = 2;
            Tao_button.Text = "Tạo";
            Tao_button.UseVisualStyleBackColor = false;
            Tao_button.Click += Tao_button_Click;
            // 
            // Huy_button
            // 
            Huy_button.BackColor = Color.DarkOrange;
            Huy_button.Location = new Point(752, 715);
            Huy_button.Margin = new Padding(4);
            Huy_button.Name = "Huy_button";
            Huy_button.Size = new Size(136, 45);
            Huy_button.TabIndex = 3;
            Huy_button.Text = "Hủy";
            Huy_button.UseVisualStyleBackColor = false;
            Huy_button.Click += Huy_button_Click;
            // 
            // TenDoanhNghiep_Textbox
            // 
            TenDoanhNghiep_Textbox.Anchor = AnchorStyles.Left;
            TenDoanhNghiep_Textbox.BackColor = SystemColors.Window;
            TenDoanhNghiep_Textbox.Location = new Point(429, 105);
            TenDoanhNghiep_Textbox.Margin = new Padding(4);
            TenDoanhNghiep_Textbox.Name = "TenDoanhNghiep_Textbox";
            TenDoanhNghiep_Textbox.ReadOnly = true;
            TenDoanhNghiep_Textbox.Size = new Size(675, 31);
            TenDoanhNghiep_Textbox.TabIndex = 4;
            // 
            // ViTriUngTuyen_Textbox
            // 
            ViTriUngTuyen_Textbox.Anchor = AnchorStyles.Left;
            ViTriUngTuyen_Textbox.BackColor = SystemColors.Window;
            ViTriUngTuyen_Textbox.Location = new Point(429, 172);
            ViTriUngTuyen_Textbox.Margin = new Padding(4);
            ViTriUngTuyen_Textbox.Name = "ViTriUngTuyen_Textbox";
            ViTriUngTuyen_Textbox.ReadOnly = true;
            ViTriUngTuyen_Textbox.Size = new Size(675, 31);
            ViTriUngTuyen_Textbox.TabIndex = 5;
            ViTriUngTuyen_Textbox.TextChanged += ViTriUngTuyen_Textbox_TextChanged;
            // 
            // SoLuongUngTuyen_Textbox
            // 
            SoLuongUngTuyen_Textbox.Anchor = AnchorStyles.Left;
            SoLuongUngTuyen_Textbox.BackColor = SystemColors.Window;
            SoLuongUngTuyen_Textbox.Location = new Point(429, 238);
            SoLuongUngTuyen_Textbox.Margin = new Padding(4);
            SoLuongUngTuyen_Textbox.Name = "SoLuongUngTuyen_Textbox";
            SoLuongUngTuyen_Textbox.ReadOnly = true;
            SoLuongUngTuyen_Textbox.Size = new Size(675, 31);
            SoLuongUngTuyen_Textbox.TabIndex = 6;
            // 
            // MoTaCongViec_Textbox
            // 
            MoTaCongViec_Textbox.Anchor = AnchorStyles.Left;
            MoTaCongViec_Textbox.BackColor = SystemColors.Window;
            MoTaCongViec_Textbox.Location = new Point(429, 310);
            MoTaCongViec_Textbox.Margin = new Padding(4);
            MoTaCongViec_Textbox.Multiline = true;
            MoTaCongViec_Textbox.Name = "MoTaCongViec_Textbox";
            MoTaCongViec_Textbox.ReadOnly = true;
            MoTaCongViec_Textbox.Size = new Size(675, 92);
            MoTaCongViec_Textbox.TabIndex = 7;
            MoTaCongViec_Textbox.TextChanged += MoTaCongViec_Textbox_TextChanged;
            // 
            // YeuCauUngVien_Textbox
            // 
            YeuCauUngVien_Textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            YeuCauUngVien_Textbox.BackColor = SystemColors.Window;
            YeuCauUngVien_Textbox.Location = new Point(429, 433);
            YeuCauUngVien_Textbox.Margin = new Padding(4);
            YeuCauUngVien_Textbox.Multiline = true;
            YeuCauUngVien_Textbox.Name = "YeuCauUngVien_Textbox";
            YeuCauUngVien_Textbox.ReadOnly = true;
            YeuCauUngVien_Textbox.Size = new Size(675, 83);
            YeuCauUngVien_Textbox.TabIndex = 8;
            // 
            // HinhThucDangTuyenDung_Textbox
            // 
            HinhThucDangTuyenDung_Textbox.BackColor = SystemColors.Window;
            HinhThucDangTuyenDung_Textbox.Location = new Point(429, 627);
            HinhThucDangTuyenDung_Textbox.Margin = new Padding(4);
            HinhThucDangTuyenDung_Textbox.Name = "HinhThucDangTuyenDung_Textbox";
            HinhThucDangTuyenDung_Textbox.ReadOnly = true;
            HinhThucDangTuyenDung_Textbox.Size = new Size(675, 31);
            HinhThucDangTuyenDung_Textbox.TabIndex = 10;
            HinhThucDangTuyenDung_Textbox.TextChanged += HinhThucDangTuyenDung_Textbox_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(178, 545);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 0;
            label7.Text = "Thời gian đăng tuyển";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(178, 630);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(231, 25);
            label8.TabIndex = 1;
            label8.Text = "Hình thức đăng tuyển dụng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 545);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(36, 25);
            label10.TabIndex = 13;
            label10.Text = "Từ:";
            // 
            // Date_From
            // 
            Date_From.AutoEllipsis = true;
            Date_From.AutoSize = true;
            Date_From.Location = new Point(472, 545);
            Date_From.Margin = new Padding(4, 0, 4, 0);
            Date_From.Name = "Date_From";
            Date_From.Size = new Size(106, 25);
            Date_From.TabIndex = 14;
            Date_From.Text = "2024/12/01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 545);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 15;
            label9.Text = "Đến:";
            // 
            // Date_To
            // 
            Date_To.AutoSize = true;
            Date_To.Location = new Point(748, 545);
            Date_To.Margin = new Padding(4, 0, 4, 0);
            Date_To.Name = "Date_To";
            Date_To.Size = new Size(106, 25);
            Date_To.TabIndex = 16;
            Date_To.Text = "2024/12/31";
            // 
            // PhieuDangKyQuangCao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 801);
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
            Controls.Add(HinhThucDangTuyenDung_Textbox);
            Controls.Add(Date_To);
            Controls.Add(label9);
            Controls.Add(Date_From);
            Controls.Add(label10);
            Controls.Add(Huy_button);
            Controls.Add(Tao_button);
            Controls.Add(TuChoi_Button);
            Controls.Add(label1);
            Margin = new Padding(4);
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
        private Label Date_To;
    }
}