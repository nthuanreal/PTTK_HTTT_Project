namespace UI_winform.DoanhNghiep
{
    partial class ThanhToan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ThanhToanListView = new ListView();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            TinhTrang_ComBox = new ComboBox();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            ThongTin_ComBox = new ComboBox();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            SearchBox = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            TimBtn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(191, 634);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(300, 150);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(587, 63);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN THANH TOÁN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1388, 86);
            panel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(1396, 946);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(ThanhToanListView, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 97);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1390, 750);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // ThanhToanListView
            // 
            ThanhToanListView.Dock = DockStyle.Fill;
            ThanhToanListView.Location = new Point(3, 3);
            ThanhToanListView.Name = "ThanhToanListView";
            ThanhToanListView.Size = new Size(967, 744);
            ThanhToanListView.TabIndex = 0;
            ThanhToanListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(976, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(411, 744);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Controls.Add(TinhTrang_ComBox, 0, 0);
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 470);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(405, 194);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // TinhTrang_ComBox
            // 
            TinhTrang_ComBox.BackColor = Color.LightCoral;
            TinhTrang_ComBox.Dock = DockStyle.Top;
            TinhTrang_ComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TinhTrang_ComBox.FormattingEnabled = true;
            TinhTrang_ComBox.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Tất cả" });
            TinhTrang_ComBox.Location = new Point(165, 3);
            TinhTrang_ComBox.Name = "TinhTrang_ComBox";
            TinhTrang_ComBox.Size = new Size(237, 33);
            TinhTrang_ComBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 1;
            label5.Text = "Tình trạng";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(ThongTin_ComBox, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 270);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(405, 194);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 1;
            label4.Text = "Thông tin";
            // 
            // ThongTin_ComBox
            // 
            ThongTin_ComBox.BackColor = Color.LightCoral;
            ThongTin_ComBox.Dock = DockStyle.Top;
            ThongTin_ComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ThongTin_ComBox.FormattingEnabled = true;
            ThongTin_ComBox.Items.AddRange(new object[] { "Mã thanh toán", "Mã phiếu QC" });
            ThongTin_ComBox.Location = new Point(165, 3);
            ThongTin_ComBox.Name = "ThongTin_ComBox";
            ThongTin_ComBox.Size = new Size(237, 33);
            ThongTin_ComBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 52);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(SearchBox, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 77);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(405, 187);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 1;
            label3.Text = "Từ khóa";
            // 
            // SearchBox
            // 
            SearchBox.Dock = DockStyle.Top;
            SearchBox.Location = new Point(165, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(237, 31);
            SearchBox.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel8.Controls.Add(TimBtn, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 670);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel8.Size = new Size(405, 71);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // TimBtn
            // 
            TimBtn.BackColor = Color.LightCoral;
            TimBtn.Dock = DockStyle.Fill;
            TimBtn.Location = new Point(129, 0);
            TimBtn.Margin = new Padding(0);
            TimBtn.Name = "TimBtn";
            TimBtn.Size = new Size(145, 42);
            TimBtn.TabIndex = 0;
            TimBtn.Text = "Tìm ";
            TimBtn.UseVisualStyleBackColor = false;
            TimBtn.Click += TimBtn_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "ThanhToan";
            Size = new Size(1396, 946);
            Load += ThanhToan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView ThanhToanListView;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox TinhTrang_ComBox;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private ComboBox ThongTin_ComBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox SearchBox;
        private TableLayoutPanel tableLayoutPanel8;
        private Button TimBtn;
    }
}
