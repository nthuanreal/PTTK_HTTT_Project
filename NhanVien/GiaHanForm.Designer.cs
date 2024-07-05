namespace UI_winform.NhanVien
{
    partial class GiaHanForm
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
            label1 = new Label();
            maHopDongTxt = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ngayLapTxt = new Label();
            ngayHetHanTxt = new Label();
            ngayGiaHan = new DateTimePicker();
            cancelBtn = new Button();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 38);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hợp đồng";
            // 
            // maHopDongTxt
            // 
            maHopDongTxt.AutoSize = true;
            maHopDongTxt.Location = new Point(203, 38);
            maHopDongTxt.Name = "maHopDongTxt";
            maHopDongTxt.Size = new Size(59, 25);
            maHopDongTxt.TabIndex = 1;
            maHopDongTxt.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 105);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày lập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 140);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 3;
            label4.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 200);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 4;
            label5.Text = "Gia hạn đến";
            // 
            // ngayLapTxt
            // 
            ngayLapTxt.AutoSize = true;
            ngayLapTxt.Location = new Point(203, 105);
            ngayLapTxt.Name = "ngayLapTxt";
            ngayLapTxt.Size = new Size(106, 25);
            ngayLapTxt.TabIndex = 5;
            ngayLapTxt.Text = "01-01-2024";
            // 
            // ngayHetHanTxt
            // 
            ngayHetHanTxt.AutoSize = true;
            ngayHetHanTxt.Location = new Point(203, 140);
            ngayHetHanTxt.Name = "ngayHetHanTxt";
            ngayHetHanTxt.Size = new Size(106, 25);
            ngayHetHanTxt.TabIndex = 6;
            ngayHetHanTxt.Text = "01-06-2024";
            // 
            // ngayGiaHan
            // 
            ngayGiaHan.CustomFormat = "dd-MM-yyyy";
            ngayGiaHan.Format = DateTimePickerFormat.Custom;
            ngayGiaHan.Location = new Point(203, 200);
            ngayGiaHan.Name = "ngayGiaHan";
            ngayGiaHan.Size = new Size(250, 31);
            ngayGiaHan.TabIndex = 7;
            ngayGiaHan.ValueChanged += ngayGiaHan_ValueChanged;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Salmon;
            cancelBtn.Location = new Point(143, 289);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(106, 37);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Chartreuse;
            submitBtn.Location = new Point(264, 289);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(106, 37);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "Gia hạn";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // GiaHanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 371);
            Controls.Add(submitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(ngayGiaHan);
            Controls.Add(ngayHetHanTxt);
            Controls.Add(ngayLapTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maHopDongTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "GiaHanForm";
            Text = "GiaHanForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label maHopDongTxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label ngayLapTxt;
        private Label ngayHetHanTxt;
        private DateTimePicker ngayGiaHan;
        private Button cancelBtn;
        private Button submitBtn;
    }
}