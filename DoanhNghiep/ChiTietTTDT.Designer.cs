namespace UI_winform.DoanhNghiep
{
    partial class ChiTietTTDT
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
            NgayBD_TxtBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            NgayKT_TxtBox = new TextBox();
            TTD_TxtBox = new TextBox();
            label8 = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            VTDT_TxtBox = new TextBox();
            SLDT_TxtBox = new TextBox();
            MTCV_TxtBox = new TextBox();
            YCUV_TxtBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // NgayBD_TxtBox
            // 
            NgayBD_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            NgayBD_TxtBox.Location = new Point(92, 4);
            NgayBD_TxtBox.Margin = new Padding(4);
            NgayBD_TxtBox.Name = "NgayBD_TxtBox";
            NgayBD_TxtBox.Size = new Size(239, 33);
            NgayBD_TxtBox.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 12F);
            label9.Location = new Point(4, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 32);
            label9.TabIndex = 7;
            label9.Text = "Từ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F);
            label10.Location = new Point(447, 0);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 8;
            label10.Text = "Đến:";
            // 
            // NgayKT_TxtBox
            // 
            NgayKT_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            NgayKT_TxtBox.Location = new Point(535, 4);
            NgayKT_TxtBox.Margin = new Padding(4);
            NgayKT_TxtBox.Name = "NgayKT_TxtBox";
            NgayKT_TxtBox.Size = new Size(239, 33);
            NgayKT_TxtBox.TabIndex = 24;
            // 
            // TTD_TxtBox
            // 
            TTD_TxtBox.Dock = DockStyle.Left;
            TTD_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TTD_TxtBox.Location = new Point(387, 397);
            TTD_TxtBox.Margin = new Padding(4);
            TTD_TxtBox.Name = "TTD_TxtBox";
            TTD_TxtBox.Size = new Size(402, 33);
            TTD_TxtBox.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F);
            label8.Location = new Point(4, 393);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(252, 32);
            label8.TabIndex = 7;
            label8.Text = "Tình trạng duyệt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 32);
            label4.TabIndex = 2;
            label4.Text = "Vị trí đăng tuyển:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(TTD_TxtBox, 1, 5);
            tableLayoutPanel4.Controls.Add(label8, 0, 5);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(label6, 0, 3);
            tableLayoutPanel4.Controls.Add(label7, 0, 4);
            tableLayoutPanel4.Controls.Add(VTDT_TxtBox, 1, 0);
            tableLayoutPanel4.Controls.Add(SLDT_TxtBox, 1, 1);
            tableLayoutPanel4.Controls.Add(MTCV_TxtBox, 1, 2);
            tableLayoutPanel4.Controls.Add(YCUV_TxtBox, 1, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(43, 167);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(1278, 492);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(4, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(294, 32);
            label3.TabIndex = 3;
            label3.Text = "Số lượng đăng tuyển:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(4, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 32);
            label5.TabIndex = 4;
            label5.Text = "Mô tả công việc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(4, 221);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(252, 32);
            label6.TabIndex = 5;
            label6.Text = "Yêu cầu ứng viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(4, 344);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(308, 32);
            label7.TabIndex = 6;
            label7.Text = "Thời gian đăng tuyển:";
            // 
            // VTDT_TxtBox
            // 
            VTDT_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            VTDT_TxtBox.Location = new Point(387, 4);
            VTDT_TxtBox.Margin = new Padding(4);
            VTDT_TxtBox.Name = "VTDT_TxtBox";
            VTDT_TxtBox.Size = new Size(436, 33);
            VTDT_TxtBox.TabIndex = 22;
            // 
            // SLDT_TxtBox
            // 
            SLDT_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SLDT_TxtBox.Location = new Point(387, 53);
            SLDT_TxtBox.Margin = new Padding(4);
            SLDT_TxtBox.Name = "SLDT_TxtBox";
            SLDT_TxtBox.Size = new Size(436, 33);
            SLDT_TxtBox.TabIndex = 23;
            // 
            // MTCV_TxtBox
            // 
            MTCV_TxtBox.Dock = DockStyle.Fill;
            MTCV_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MTCV_TxtBox.Location = new Point(387, 102);
            MTCV_TxtBox.Margin = new Padding(4);
            MTCV_TxtBox.Multiline = true;
            MTCV_TxtBox.Name = "MTCV_TxtBox";
            MTCV_TxtBox.Size = new Size(887, 115);
            MTCV_TxtBox.TabIndex = 24;
            // 
            // YCUV_TxtBox
            // 
            YCUV_TxtBox.Dock = DockStyle.Fill;
            YCUV_TxtBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            YCUV_TxtBox.Location = new Point(387, 225);
            YCUV_TxtBox.Margin = new Padding(4);
            YCUV_TxtBox.Multiline = true;
            YCUV_TxtBox.Name = "YCUV_TxtBox";
            YCUV_TxtBox.Size = new Size(887, 115);
            YCUV_TxtBox.TabIndex = 25;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(NgayBD_TxtBox, 0, 0);
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(label10, 2, 0);
            tableLayoutPanel5.Controls.Add(NgayKT_TxtBox, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(386, 347);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(889, 43);
            tableLayoutPanel5.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 80);
            panel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 801);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1366, 84);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1372, 888);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Location = new Point(4, 92);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(40);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1364, 702);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(44, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1276, 52);
            label2.TabIndex = 1;
            label2.Text = "CHI TIẾT THÔNG TIN ĐĂNG TUYỂN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChiTietTTDT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 888);
            Controls.Add(tableLayoutPanel1);
            Name = "ChiTietTTDT";
            Text = "ChiTietTTDT";
            Load += ChiTietTTDT_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NgayBD_TxtBox;
        private Label label9;
        private Label label10;
        private TextBox NgayKT_TxtBox;
        private TextBox TTD_TxtBox;
        private Label label8;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox VTDT_TxtBox;
        private TextBox SLDT_TxtBox;
        private TextBox MTCV_TxtBox;
        private TextBox YCUV_TxtBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
    }
}