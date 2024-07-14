namespace UI_winform.NhanVien.controls
{
    partial class DanhSachHopDong
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
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(250, 135, 135);
            searchBtn.Location = new Point(969, 166);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 40);
            searchBtn.TabIndex = 32;
            searchBtn.Text = "Tra cứu";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 176, 176);
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chưa duyệt", "Đã duyệt", "Gia hạn" });
            comboBox1.Location = new Point(969, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 36);
            comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(866, 88);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 30;
            label2.Text = "Tình trạng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(9, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(853, 544);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 30);
            label1.TabIndex = 28;
            label1.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // DanhSachHopDong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBtn);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DanhSachHopDong";
            Size = new Size(1137, 600);
            Load += DanhSachHopDong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchBtn;
        private ComboBox comboBox1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
