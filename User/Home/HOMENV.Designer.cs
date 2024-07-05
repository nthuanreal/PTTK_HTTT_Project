namespace UI_winform.User.Home
{
    partial class HOMENV
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
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            giaHanBtn = new Button();
            pictureBox1 = new PictureBox();
            hoSoBtn = new Button();
            hopDongBtn = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.AppWorkspace;
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1000, 800);
            splitContainer1.SplitterDistance = 207;
            splitContainer1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Cursor = Cursors.AppStarting;
            linkLabel1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(12, 749);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 42);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(giaHanBtn, 0, 6);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(hoSoBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(hopDongBtn, 0, 3);
            tableLayoutPanel1.Location = new Point(-2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(206, 540);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(4, 223);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(198, 74);
            button1.TabIndex = 6;
            button1.Text = "THÔNG TIN CÁ NHÂN";
            button1.UseVisualStyleBackColor = false;
            // 
            // giaHanBtn
            // 
            giaHanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            giaHanBtn.BackColor = Color.FromArgb(250, 135, 135);
            giaHanBtn.FlatStyle = FlatStyle.Popup;
            giaHanBtn.Font = new Font("Cascadia Code", 12F);
            giaHanBtn.Location = new Point(4, 463);
            giaHanBtn.Margin = new Padding(4, 3, 4, 3);
            giaHanBtn.Name = "giaHanBtn";
            giaHanBtn.Size = new Size(198, 77);
            giaHanBtn.TabIndex = 2;
            giaHanBtn.Text = "XỬ LÝ GIA HẠN";
            giaHanBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(63, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // hoSoBtn
            // 
            hoSoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hoSoBtn.BackColor = Color.FromArgb(250, 135, 135);
            hoSoBtn.FlatStyle = FlatStyle.Popup;
            hoSoBtn.Font = new Font("Cascadia Code", 12F);
            hoSoBtn.Location = new Point(4, 383);
            hoSoBtn.Margin = new Padding(4, 3, 4, 3);
            hoSoBtn.Name = "hoSoBtn";
            hoSoBtn.Size = new Size(198, 74);
            hoSoBtn.TabIndex = 1;
            hoSoBtn.Text = "XỬ LÝ HỒ SƠ ỨNG VIÊN";
            hoSoBtn.UseVisualStyleBackColor = false;
            // 
            // hopDongBtn
            // 
            hopDongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            hopDongBtn.FlatStyle = FlatStyle.Popup;
            hopDongBtn.Font = new Font("Cascadia Code", 12F);
            hopDongBtn.Location = new Point(4, 303);
            hopDongBtn.Margin = new Padding(4, 3, 4, 3);
            hopDongBtn.Name = "hopDongBtn";
            hopDongBtn.Size = new Size(198, 74);
            hopDongBtn.TabIndex = 0;
            hopDongBtn.Text = "XỬ LÝ HỢP ĐỒNG";
            hopDongBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.InitialImage = Properties.Resources.user;
            pictureBox3.Location = new Point(352, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(207, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 97);
            panel2.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cascadia Code", 10.8F);
            button5.Location = new Point(220, 25);
            button5.Name = "button5";
            button5.Size = new Size(150, 50);
            button5.TabIndex = 4;
            button5.Text = "CẬP NHẬT";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(24, 25);
            button4.Name = "button4";
            button4.Size = new Size(158, 50);
            button4.TabIndex = 3;
            button4.Text = "ĐỔI MẬT KHẨU";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.75F));
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(label8, 0, 6);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox6, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 5);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 6);
            tableLayoutPanel2.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel2.Font = new Font("Cascadia Code SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(74, 276);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(608, 348);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 211);
            label6.Name = "label6";
            label6.Size = new Size(180, 27);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 261);
            label7.Name = "label7";
            label7.Size = new Size(84, 27);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 311);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 6;
            label8.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(72, 27);
            label5.TabIndex = 3;
            label5.Text = "MANV:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(199, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(199, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(199, 109);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(399, 31);
            textBox6.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(199, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(199, 309);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(399, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(199, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(399, 31);
            textBox5.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 161);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 2;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 111);
            label3.Name = "label3";
            label3.Size = new Size(132, 27);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(199, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(399, 44);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 10);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 31);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Nam";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(79, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 31);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Nữ";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 81);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(413, 52);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HOMENV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(splitContainer1);
            Name = "HOMENV";
            Text = "HOMENV";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        public Button hopDongBtn;
        public Button giaHanBtn;
        public Button hoSoBtn;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        public Button button1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox6;
        private Panel panel3;
        private Label label1;
    }
}