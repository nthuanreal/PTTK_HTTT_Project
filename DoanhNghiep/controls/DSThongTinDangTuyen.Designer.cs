namespace UI_winform.DoanhNghiep.controls
{
    partial class DSThongTinDangTuyen
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
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            TinhTrang_ComBox = new ComboBox();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            TimBtn = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            DangKyTTDT_Btn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ThanhToanListView = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel5.Controls.Add(TinhTrang_ComBox, 1, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 77);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(405, 187);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // TinhTrang_ComBox
            // 
            TinhTrang_ComBox.BackColor = Color.LightCoral;
            TinhTrang_ComBox.Dock = DockStyle.Top;
            TinhTrang_ComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TinhTrang_ComBox.FormattingEnabled = true;
            TinhTrang_ComBox.Items.AddRange(new object[] { "Chưa duyệt", "Đã duyệt", "Tất cả" });
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
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 270);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(405, 194);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(TimBtn, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Top;
            tableLayoutPanel8.Location = new Point(165, 96);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel8.Size = new Size(237, 71);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // TimBtn
            // 
            TimBtn.BackColor = Color.LightCoral;
            TimBtn.Dock = DockStyle.Fill;
            TimBtn.Location = new Point(59, 0);
            TimBtn.Margin = new Padding(0);
            TimBtn.Name = "TimBtn";
            TimBtn.Size = new Size(118, 42);
            TimBtn.TabIndex = 0;
            TimBtn.Text = "Tìm ";
            TimBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 470);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(405, 194);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 0, 4);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
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
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel9.Controls.Add(DangKyTTDT_Btn, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 670);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel9.Size = new Size(405, 71);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // DangKyTTDT_Btn
            // 
            DangKyTTDT_Btn.BackColor = Color.LightCoral;
            DangKyTTDT_Btn.Dock = DockStyle.Fill;
            DangKyTTDT_Btn.Location = new Point(121, 0);
            DangKyTTDT_Btn.Margin = new Padding(0);
            DangKyTTDT_Btn.Name = "DangKyTTDT_Btn";
            DangKyTTDT_Btn.Size = new Size(162, 42);
            DangKyTTDT_Btn.TabIndex = 0;
            DangKyTTDT_Btn.Text = "Đăng Ký Ngay";
            DangKyTTDT_Btn.UseVisualStyleBackColor = false;
            DangKyTTDT_Btn.Click += DangKyTTDT_Btn_Click;
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
            ThanhToanListView.ItemActivate += ThanhToanListView_ItemActivate;
            ThanhToanListView.MouseDoubleClick += ThanhToanListView_MouseDoubleClick;
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
            tableLayoutPanel2.TabIndex = 14;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(867, 63);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH THÔNG TIN ĐĂNG TUYỂN";
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
            tableLayoutPanel1.TabIndex = 13;
            // 
            // DSThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "DSThongTinDangTuyen";
            Size = new Size(1396, 946);
            Load += DSThongTinDangTuyen_Load;
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox TinhTrang_ComBox;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView ThanhToanListView;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel8;
        private Button TimBtn;
        private TableLayoutPanel tableLayoutPanel9;
        private Button DangKyTTDT_Btn;
    }
}
