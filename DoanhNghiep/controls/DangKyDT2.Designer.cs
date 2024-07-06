namespace UI_winform.DoanhNghiep.controls
{
    partial class DangKyDT2
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            NgayKT_Picker = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            NgayBD_Picker = new DateTimePicker();
            HTDT_ListBox = new CheckedListBox();
            label1 = new Label();
            panel1 = new Panel();
            QuayLai_Btn = new Button();
            DangKy_Btn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(44, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1300, 52);
            label2.TabIndex = 1;
            label2.Text = "HÌNH THỨC ĐĂNG TUYỂN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Controls.Add(HTDT_ListBox, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(43, 176);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1302, 529);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(4, 211);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 32);
            label3.TabIndex = 3;
            label3.Text = "Hình thức đăng tuyển:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(308, 32);
            label4.TabIndex = 2;
            label4.Text = "Thời gian đăng tuyển:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.Controls.Add(NgayKT_Picker, 1, 1);
            tableLayoutPanel5.Controls.Add(label6, 0, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(NgayBD_Picker, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(393, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(906, 205);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // NgayKT_Picker
            // 
            NgayKT_Picker.Font = new Font("Segoe UI", 11F);
            NgayKT_Picker.Format = DateTimePickerFormat.Short;
            NgayKT_Picker.Location = new Point(273, 104);
            NgayKT_Picker.Margin = new Padding(2);
            NgayKT_Picker.Name = "NgayKT_Picker";
            NgayKT_Picker.Size = new Size(324, 37);
            NgayKT_Picker.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(4, 102);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 4;
            label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 3;
            label5.Text = "Từ ngày:";
            // 
            // NgayBD_Picker
            // 
            NgayBD_Picker.Font = new Font("Segoe UI", 11F);
            NgayBD_Picker.Format = DateTimePickerFormat.Short;
            NgayBD_Picker.Location = new Point(273, 2);
            NgayBD_Picker.Margin = new Padding(2);
            NgayBD_Picker.Name = "NgayBD_Picker";
            NgayBD_Picker.Size = new Size(324, 37);
            NgayBD_Picker.TabIndex = 19;
            // 
            // HTDT_ListBox
            // 
            HTDT_ListBox.BackColor = SystemColors.Control;
            HTDT_ListBox.Dock = DockStyle.Fill;
            HTDT_ListBox.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            HTDT_ListBox.FormattingEnabled = true;
            HTDT_ListBox.Items.AddRange(new object[] { "Đăng tuyển trên Web", "Banner quảng cáo", "Phát tờ rơi" });
            HTDT_ListBox.Location = new Point(393, 214);
            HTDT_ListBox.Name = "HTDT_ListBox";
            HTDT_ListBox.Size = new Size(906, 312);
            HTDT_ListBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(671, 63);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ ĐĂNG TUYỂN DỤNG";
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
            // QuayLai_Btn
            // 
            QuayLai_Btn.BackColor = Color.LightCoral;
            QuayLai_Btn.Dock = DockStyle.Fill;
            QuayLai_Btn.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            QuayLai_Btn.Location = new Point(417, 18);
            QuayLai_Btn.Margin = new Padding(0);
            QuayLai_Btn.Name = "QuayLai_Btn";
            QuayLai_Btn.Size = new Size(250, 54);
            QuayLai_Btn.TabIndex = 0;
            QuayLai_Btn.Text = "Quay lại";
            QuayLai_Btn.UseVisualStyleBackColor = false;
            QuayLai_Btn.Click += QuayLai_Btn_Click;
            // 
            // DangKy_Btn
            // 
            DangKy_Btn.BackColor = Color.LightCoral;
            DangKy_Btn.Dock = DockStyle.Fill;
            DangKy_Btn.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            DangKy_Btn.Location = new Point(722, 18);
            DangKy_Btn.Margin = new Padding(0);
            DangKy_Btn.Name = "DangKy_Btn";
            DangKy_Btn.Size = new Size(250, 54);
            DangKy_Btn.TabIndex = 1;
            DangKy_Btn.Text = "Đăng ký";
            DangKy_Btn.UseVisualStyleBackColor = false;
            DangKy_Btn.Click += DangKy_Btn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(QuayLai_Btn, 1, 1);
            tableLayoutPanel3.Controls.Add(DangKy_Btn, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 853);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1390, 90);
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
            tableLayoutPanel1.Size = new Size(1396, 946);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Location = new Point(4, 98);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(40);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1388, 748);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // DangKyDT2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "DangKyDT2";
            Size = new Size(1396, 946);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Panel panel1;
        private Button QuayLai_Btn;
        private Button DangKy_Btn;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckedListBox HTDT_ListBox;
        private DateTimePicker NgayKT_Picker;
        private DateTimePicker NgayBD_Picker;
    }
}
