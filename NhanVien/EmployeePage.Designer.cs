namespace UI_winform
{
    partial class EmployeePage
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
            splitContainer1 = new SplitContainer();
            giaHanBtn = new Button();
            hoSoBtn = new Button();
            hopDongBtn = new Button();
            xuLyHopDong1 = new NhanVien.controls.XuLyHopDong();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.Controls.Add(giaHanBtn);
            splitContainer1.Panel1.Controls.Add(hoSoBtn);
            splitContainer1.Panel1.Controls.Add(hopDongBtn);
            splitContainer1.Panel1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(xuLyHopDong1);
            splitContainer1.Size = new Size(1347, 778);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // giaHanBtn
            // 
            giaHanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giaHanBtn.BackColor = Color.FromArgb(250, 135, 135);
            giaHanBtn.Location = new Point(0, 254);
            giaHanBtn.Margin = new Padding(5, 4, 5, 4);
            giaHanBtn.Name = "giaHanBtn";
            giaHanBtn.Size = new Size(190, 64);
            giaHanBtn.TabIndex = 5;
            giaHanBtn.Text = "XỬ LÝ GIA HẠN";
            giaHanBtn.UseVisualStyleBackColor = false;
            giaHanBtn.Click += giaHanBtn_Click;
            // 
            // hoSoBtn
            // 
            hoSoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hoSoBtn.BackColor = Color.FromArgb(250, 135, 135);
            hoSoBtn.Location = new Point(0, 182);
            hoSoBtn.Margin = new Padding(5, 4, 5, 4);
            hoSoBtn.Name = "hoSoBtn";
            hoSoBtn.Size = new Size(190, 64);
            hoSoBtn.TabIndex = 4;
            hoSoBtn.Text = "HỒ SƠ ỨNG VIÊN";
            hoSoBtn.UseVisualStyleBackColor = false;
            hoSoBtn.Click += hoSoBtn_Click;
            // 
            // hopDongBtn
            // 
            hopDongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            hopDongBtn.Location = new Point(0, 111);
            hopDongBtn.Margin = new Padding(5, 4, 5, 4);
            hopDongBtn.Name = "hopDongBtn";
            hopDongBtn.Size = new Size(190, 64);
            hopDongBtn.TabIndex = 3;
            hopDongBtn.Text = "XỬ LÝ HỢP ĐỒNG";
            hopDongBtn.UseVisualStyleBackColor = false;
            // 
            // xuLyHopDong1
            // 
            xuLyHopDong1.Dock = DockStyle.Fill;
            xuLyHopDong1.Location = new Point(0, 0);
            xuLyHopDong1.Margin = new Padding(2);
            xuLyHopDong1.Name = "xuLyHopDong1";
            xuLyHopDong1.Size = new Size(1147, 778);
            xuLyHopDong1.TabIndex = 0;
            xuLyHopDong1.Load += xuLyHopDong1_Load;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 778);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EmployeePage";
            Text = "EmployeePage";
            FormClosed += EmployeePage_FormClosed;
            Load += EmployeePage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        public Button giaHanBtn;
        public Button hoSoBtn;
        public Button hopDongBtn;
        private NhanVien.controls.XuLyHopDong xuLyHopDong1;
    }
}