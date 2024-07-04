namespace UI_winform.User.Home
{
    partial class HOMEDN
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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(982, 753);
            splitContainer1.SplitterDistance = 170;
            splitContainer1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Cursor = Cursors.AppStarting;
            linkLabel1.Font = new Font("Cascadia Code", 18F);
            linkLabel1.Location = new Point(0, 704);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 42);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 3);
            tableLayoutPanel1.Controls.Add(button3, 0, 4);
            tableLayoutPanel1.Controls.Add(button4, 0, 5);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(167, 522);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox2.Location = new Point(43, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cascadia Code", 12F);
            button1.Location = new Point(3, 243);
            button1.Name = "button1";
            button1.Size = new Size(161, 64);
            button1.TabIndex = 3;
            button1.Text = "THÔNG TIN THÀNH VIÊN";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.LightCoral;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cascadia Code", 12F);
            button2.Location = new Point(3, 313);
            button2.Name = "button2";
            button2.Size = new Size(161, 64);
            button2.TabIndex = 4;
            button2.Text = "ĐĂNG KÝ ĐĂNG TUYỂN";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.LightCoral;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cascadia Code", 12F);
            button3.Location = new Point(3, 383);
            button3.Name = "button3";
            button3.Size = new Size(161, 64);
            button3.TabIndex = 5;
            button3.Text = "THANH TOÁN";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.LightCoral;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Cascadia Code", 12F);
            button4.Location = new Point(3, 453);
            button4.Name = "button4";
            button4.Size = new Size(161, 66);
            button4.TabIndex = 6;
            button4.Text = "DÀNH RIÊNG CHO BẠN";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(159, 655);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 60);
            panel2.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.LightCoral;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Cascadia Code", 10.8F);
            button6.Location = new Point(266, 3);
            button6.Name = "button6";
            button6.Size = new Size(161, 54);
            button6.TabIndex = 8;
            button6.Text = "CẬP NHẬT";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.LightCoral;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Cascadia Code", 10.8F);
            button5.Location = new Point(39, 3);
            button5.Name = "button5";
            button5.Size = new Size(161, 54);
            button5.TabIndex = 7;
            button5.Text = "ĐỔI MẬT KHẨU";
            button5.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1360931F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.86391F));
            tableLayoutPanel2.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel2.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(70, 110);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6638927F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.667223F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.667223F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.667223F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.667223F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.667223F));
            tableLayoutPanel2.Size = new Size(676, 386);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Font = new Font("Cascadia Code", 12F);
            textBox6.Location = new Point(226, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(447, 31);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Cascadia Code", 12F);
            textBox5.Location = new Point(226, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(447, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Cascadia Code", 12F);
            textBox4.Location = new Point(226, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(447, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Cascadia Code", 12F);
            textBox3.Location = new Point(226, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(447, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Cascadia Code", 12F);
            textBox2.Location = new Point(226, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(447, 31);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(216, 27);
            label2.TabIndex = 0;
            label2.Text = "Tên doanh nghiệp:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 1;
            label3.Text = "Mã số thuế:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(3, 146);
            label4.Name = "label4";
            label4.Size = new Size(192, 27);
            label4.TabIndex = 2;
            label4.Text = "Người đại diện:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(3, 210);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 3;
            label5.Text = "Đại chỉ:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(3, 274);
            label6.Name = "label6";
            label6.Size = new Size(180, 27);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(3, 339);
            label7.Name = "label7";
            label7.Size = new Size(84, 27);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Cascadia Code", 12F);
            textBox1.Location = new Point(226, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 31);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Location = new Point(360, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 125);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(482, 52);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // HOMEDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(splitContainer1);
            Name = "HOMEDN";
            Text = "HOMEDN";
            Load += HOMEDN_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private LinkLabel linkLabel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Panel panel2;
        private Button button6;
        private Button button5;
    }
}