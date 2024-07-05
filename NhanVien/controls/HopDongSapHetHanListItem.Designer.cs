namespace UI_winform.NhanVien.controls
{
    partial class HopDongSapHetHanListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ngayHetHanTxt = new Label();
            tinhTrangTxt = new Label();
            ngayLapTxt = new Label();
            hopDongTxt = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ngayHetHanTxt
            // 
            ngayHetHanTxt.AutoSize = true;
            ngayHetHanTxt.Location = new Point(613, 52);
            ngayHetHanTxt.Name = "ngayHetHanTxt";
            ngayHetHanTxt.Size = new Size(106, 25);
            ngayHetHanTxt.TabIndex = 15;
            ngayHetHanTxt.Text = "2025/12/01";
            // 
            // tinhTrangTxt
            // 
            tinhTrangTxt.AutoSize = true;
            tinhTrangTxt.Location = new Point(337, 52);
            tinhTrangTxt.Name = "tinhTrangTxt";
            tinhTrangTxt.Size = new Size(125, 25);
            tinhTrangTxt.TabIndex = 14;
            tinhTrangTxt.Text = "Đã thanh toán";
            // 
            // ngayLapTxt
            // 
            ngayLapTxt.AutoSize = true;
            ngayLapTxt.Location = new Point(107, 52);
            ngayLapTxt.Name = "ngayLapTxt";
            ngayLapTxt.Size = new Size(106, 25);
            ngayLapTxt.TabIndex = 13;
            ngayLapTxt.Text = "2024/12/01";
            // 
            // hopDongTxt
            // 
            hopDongTxt.AutoSize = true;
            hopDongTxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopDongTxt.Location = new Point(146, 13);
            hopDongTxt.Name = "hopDongTxt";
            hopDongTxt.Size = new Size(70, 25);
            hopDongTxt.TabIndex = 12;
            hopDongTxt.Text = "ABC_01";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(485, 52);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 11;
            label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(233, 52);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 10;
            label3.Text = "Tình trạng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 9;
            label2.Text = "Ngày lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã hợp đồng:";
            // 
            // HopDongSapHetHanListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(ngayHetHanTxt);
            Controls.Add(tinhTrangTxt);
            Controls.Add(ngayLapTxt);
            Controls.Add(hopDongTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(881, 104);
            Name = "HopDongSapHetHanListItem";
            Size = new Size(881, 104);
            Load += HopDongSapHetHanListItem_Load;
            Click += HopDongSapHetHanListItem_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ngayHetHanTxt;
        private Label tinhTrangTxt;
        private Label ngayLapTxt;
        private Label hopDongTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
