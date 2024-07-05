namespace UI_winform.controls
{
    partial class SideBar
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
            hopDongBtn = new Button();
            hoSoBtn = new Button();
            giaHanBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // hopDongBtn
            // 
            hopDongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            hopDongBtn.FlatStyle = FlatStyle.Popup;
            hopDongBtn.Font = new Font("Cascadia Code", 12F);
            hopDongBtn.Location = new Point(4, 223);
            hopDongBtn.Margin = new Padding(4, 3, 4, 3);
            hopDongBtn.Name = "hopDongBtn";
            hopDongBtn.Size = new Size(215, 74);
            hopDongBtn.TabIndex = 0;
            hopDongBtn.Text = "XỬ LÝ HỢP ĐỒNG";
            hopDongBtn.UseVisualStyleBackColor = false;
            hopDongBtn.Click += hopDongBtn_Click;
            // 
            // hoSoBtn
            // 
            hoSoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hoSoBtn.BackColor = Color.FromArgb(250, 135, 135);
            hoSoBtn.FlatStyle = FlatStyle.Popup;
            hoSoBtn.Font = new Font("Cascadia Code", 12F);
            hoSoBtn.Location = new Point(4, 303);
            hoSoBtn.Margin = new Padding(4, 3, 4, 3);
            hoSoBtn.Name = "hoSoBtn";
            hoSoBtn.Size = new Size(215, 74);
            hoSoBtn.TabIndex = 1;
            hoSoBtn.Text = "HỒ SƠ ỨNG VIÊN";
            hoSoBtn.UseVisualStyleBackColor = false;
            hoSoBtn.Click += hoSoBtn_Click;
            // 
            // giaHanBtn
            // 
            giaHanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            giaHanBtn.BackColor = Color.FromArgb(250, 135, 135);
            giaHanBtn.FlatStyle = FlatStyle.Popup;
            giaHanBtn.Font = new Font("Cascadia Code", 12F);
            giaHanBtn.Location = new Point(4, 383);
            giaHanBtn.Margin = new Padding(4, 3, 4, 3);
            giaHanBtn.Name = "giaHanBtn";
            giaHanBtn.Size = new Size(215, 74);
            giaHanBtn.TabIndex = 2;
            giaHanBtn.Text = "XỬ LÝ GIA HẠN";
            giaHanBtn.UseVisualStyleBackColor = false;
            giaHanBtn.Click += giaHanBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(hopDongBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(giaHanBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(hoSoBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(-1, -2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(223, 596);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(71, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Cursor = Cursors.AppStarting;
            linkLabel1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(21, 725);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 42);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(linkLabel1);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SideBar";
            Size = new Size(223, 783);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button hopDongBtn;
        public Button hoSoBtn;
        public Button giaHanBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}
