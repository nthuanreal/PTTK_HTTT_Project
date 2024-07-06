namespace UI_winform.DoanhNghiep
{
    partial class ChinhSachItem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // ngayHetHanTxt
            // 
            ngayHetHanTxt.AutoSize = true;
            ngayHetHanTxt.Location = new Point(637, 0);
            ngayHetHanTxt.Name = "ngayHetHanTxt";
            ngayHetHanTxt.Size = new Size(85, 20);
            ngayHetHanTxt.TabIndex = 15;
            ngayHetHanTxt.Text = "2025/12/01";
            // 
            // tinhTrangTxt
            // 
            tinhTrangTxt.AutoSize = true;
            tinhTrangTxt.Location = new Point(453, 0);
            tinhTrangTxt.Name = "tinhTrangTxt";
            tinhTrangTxt.Size = new Size(37, 20);
            tinhTrangTxt.TabIndex = 14;
            tinhTrangTxt.Text = "10%";
            // 
            // ngayLapTxt
            // 
            ngayLapTxt.AutoSize = true;
            ngayLapTxt.Location = new Point(106, 0);
            ngayLapTxt.Name = "ngayLapTxt";
            ngayLapTxt.Size = new Size(143, 20);
            ngayLapTxt.TabIndex = 13;
            ngayLapTxt.Text = "Hóa đơn trên 5 triệu";
            // 
            // hopDongTxt
            // 
            hopDongTxt.AutoSize = true;
            hopDongTxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopDongTxt.Location = new Point(119, 2);
            hopDongTxt.Name = "hopDongTxt";
            hopDongTxt.Size = new Size(70, 25);
            hopDongTxt.TabIndex = 12;
            hopDongTxt.Text = "ABC_01";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(500, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 11;
            label4.Text = "Ngày hết hạn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(375, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 10;
            label3.Text = "Ưu đãi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 9;
            label2.Text = "Điều kiện:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 2);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã ưu đãi:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 269F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.Controls.Add(ngayHetHanTxt, 5, 0);
            tableLayoutPanel1.Controls.Add(ngayLapTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(tinhTrangTxt, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(728, 31);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 1);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(hopDongTxt);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(731, 79);
            splitContainer1.SplitterDistance = 29;
            splitContainer1.TabIndex = 17;
            // 
            // ChinhSachItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ChinhSachItem";
            Size = new Size(731, 83);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
    }
}
