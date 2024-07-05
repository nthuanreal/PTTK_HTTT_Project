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
            TTTV_Btn = new Button();
            DKDT_Btn = new Button();
            TT_Btn = new Button();
            DRCB_Btn = new Button();
            pictureBox2 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            Email_TxtBox = new TextBox();
            SDT_TxtBox = new TextBox();
            DiaChi_TxtBox = new TextBox();
            NDD_TxtBox = new TextBox();
            MaThue_TxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TenDN_TxtBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            DoiMK_Btn = new Button();
            ChinhSua_Btn = new Button();
            CapNhat_Btn = new Button();
            Huy_Btn = new Button();
            pictureBox1 = new PictureBox();
            TTNDD_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1228, 941);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.SplitterWidth = 5;
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
            linkLabel1.Location = new Point(4, 883);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 49);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TTNDD_Btn, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(TTTV_Btn, 0, 2);
            tableLayoutPanel1.Controls.Add(DRCB_Btn, 0, 6);
            tableLayoutPanel1.Controls.Add(TT_Btn, 0, 5);
            tableLayoutPanel1.Controls.Add(DKDT_Btn, 0, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(209, 748);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TTTV_Btn
            // 
            TTTV_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTTV_Btn.BackColor = Color.LightCoral;
            TTTV_Btn.FlatStyle = FlatStyle.Popup;
            TTTV_Btn.Font = new Font("Cascadia Code", 12F);
            TTTV_Btn.Location = new Point(4, 304);
            TTTV_Btn.Margin = new Padding(4);
            TTTV_Btn.Name = "TTTV_Btn";
            TTTV_Btn.Size = new Size(201, 80);
            TTTV_Btn.TabIndex = 3;
            TTTV_Btn.Text = "THÔNG TIN THÀNH VIÊN";
            TTTV_Btn.UseVisualStyleBackColor = false;
            TTTV_Btn.Click += TTTV_Btn_Click;
            // 
            // DKDT_Btn
            // 
            DKDT_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKDT_Btn.BackColor = Color.LightCoral;
            DKDT_Btn.FlatStyle = FlatStyle.Popup;
            DKDT_Btn.Font = new Font("Cascadia Code", 12F);
            DKDT_Btn.Location = new Point(4, 480);
            DKDT_Btn.Margin = new Padding(4);
            DKDT_Btn.Name = "DKDT_Btn";
            DKDT_Btn.Size = new Size(201, 80);
            DKDT_Btn.TabIndex = 4;
            DKDT_Btn.Text = "ĐĂNG KÝ ĐĂNG TUYỂN";
            DKDT_Btn.UseVisualStyleBackColor = false;
            DKDT_Btn.Click += DKDT_Btn_Click;
            // 
            // TT_Btn
            // 
            TT_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TT_Btn.BackColor = Color.LightCoral;
            TT_Btn.FlatStyle = FlatStyle.Popup;
            TT_Btn.Font = new Font("Cascadia Code", 12F);
            TT_Btn.Location = new Point(4, 568);
            TT_Btn.Margin = new Padding(4);
            TT_Btn.Name = "TT_Btn";
            TT_Btn.Size = new Size(201, 80);
            TT_Btn.TabIndex = 5;
            TT_Btn.Text = "THANH TOÁN";
            TT_Btn.UseVisualStyleBackColor = false;
            TT_Btn.Click += TT_Btn_Click;
            // 
            // DRCB_Btn
            // 
            DRCB_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DRCB_Btn.BackColor = Color.LightCoral;
            DRCB_Btn.FlatStyle = FlatStyle.Popup;
            DRCB_Btn.Font = new Font("Cascadia Code", 12F);
            DRCB_Btn.Location = new Point(4, 656);
            DRCB_Btn.Margin = new Padding(4);
            DRCB_Btn.Name = "DRCB_Btn";
            DRCB_Btn.Size = new Size(201, 88);
            DRCB_Btn.TabIndex = 6;
            DRCB_Btn.Text = "DÀNH RIÊNG CHO BẠN";
            DRCB_Btn.UseVisualStyleBackColor = false;
            DRCB_Btn.Click += DRCB_Btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox2.Image = Properties.Resources.user1;
            pictureBox2.Location = new Point(54, 37);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1011, 941);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 86);
            panel1.TabIndex = 8;
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
            label1.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(Email_TxtBox, 1, 5);
            tableLayoutPanel4.Controls.Add(SDT_TxtBox, 1, 4);
            tableLayoutPanel4.Controls.Add(DiaChi_TxtBox, 1, 3);
            tableLayoutPanel4.Controls.Add(NDD_TxtBox, 1, 2);
            tableLayoutPanel4.Controls.Add(MaThue_TxtBox, 1, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(label5, 0, 3);
            tableLayoutPanel4.Controls.Add(label6, 0, 4);
            tableLayoutPanel4.Controls.Add(label7, 0, 5);
            tableLayoutPanel4.Controls.Add(TenDN_TxtBox, 1, 0);
            tableLayoutPanel4.Location = new Point(4, 98);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(40);
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66389F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672211F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66722F));
            tableLayoutPanel4.Size = new Size(1003, 650);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // Email_TxtBox
            // 
            Email_TxtBox.Font = new Font("Cascadia Code", 12F);
            Email_TxtBox.Location = new Point(367, 518);
            Email_TxtBox.Margin = new Padding(4);
            Email_TxtBox.Name = "Email_TxtBox";
            Email_TxtBox.Size = new Size(592, 35);
            Email_TxtBox.TabIndex = 11;
            // 
            // SDT_TxtBox
            // 
            SDT_TxtBox.Font = new Font("Cascadia Code", 12F);
            SDT_TxtBox.Location = new Point(367, 423);
            SDT_TxtBox.Margin = new Padding(4);
            SDT_TxtBox.Name = "SDT_TxtBox";
            SDT_TxtBox.Size = new Size(592, 35);
            SDT_TxtBox.TabIndex = 10;
            // 
            // DiaChi_TxtBox
            // 
            DiaChi_TxtBox.Font = new Font("Cascadia Code", 12F);
            DiaChi_TxtBox.Location = new Point(367, 328);
            DiaChi_TxtBox.Margin = new Padding(4);
            DiaChi_TxtBox.Name = "DiaChi_TxtBox";
            DiaChi_TxtBox.Size = new Size(592, 35);
            DiaChi_TxtBox.TabIndex = 9;
            // 
            // NDD_TxtBox
            // 
            NDD_TxtBox.Font = new Font("Cascadia Code", 12F);
            NDD_TxtBox.Location = new Point(367, 233);
            NDD_TxtBox.Margin = new Padding(4);
            NDD_TxtBox.Name = "NDD_TxtBox";
            NDD_TxtBox.Size = new Size(592, 35);
            NDD_TxtBox.TabIndex = 8;
            // 
            // MaThue_TxtBox
            // 
            MaThue_TxtBox.Font = new Font("Cascadia Code", 12F);
            MaThue_TxtBox.Location = new Point(367, 138);
            MaThue_TxtBox.Margin = new Padding(4);
            MaThue_TxtBox.Name = "MaThue_TxtBox";
            MaThue_TxtBox.Size = new Size(592, 35);
            MaThue_TxtBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(44, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 32);
            label2.TabIndex = 0;
            label2.Text = "Tên doanh nghiệp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(44, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 1;
            label3.Text = "Mã số thuế:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(44, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 32);
            label4.TabIndex = 2;
            label4.Text = "Người đại diện:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(44, 324);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 3;
            label5.Text = "Đại chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(44, 419);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 32);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(44, 514);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // TenDN_TxtBox
            // 
            TenDN_TxtBox.Font = new Font("Cascadia Code", 12F);
            TenDN_TxtBox.Location = new Point(367, 44);
            TenDN_TxtBox.Margin = new Padding(4);
            TenDN_TxtBox.Name = "TenDN_TxtBox";
            TenDN_TxtBox.Size = new Size(592, 35);
            TenDN_TxtBox.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(DoiMK_Btn, 1, 1);
            tableLayoutPanel3.Controls.Add(ChinhSua_Btn, 3, 1);
            tableLayoutPanel3.Controls.Add(CapNhat_Btn, 3, 0);
            tableLayoutPanel3.Controls.Add(Huy_Btn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 755);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Size = new Size(1005, 183);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // DoiMK_Btn
            // 
            DoiMK_Btn.BackColor = Color.LightCoral;
            DoiMK_Btn.Dock = DockStyle.Fill;
            DoiMK_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            DoiMK_Btn.Location = new Point(301, 64);
            DoiMK_Btn.Margin = new Padding(0);
            DoiMK_Btn.Name = "DoiMK_Btn";
            DoiMK_Btn.Size = new Size(180, 54);
            DoiMK_Btn.TabIndex = 0;
            DoiMK_Btn.Text = "Đổi Mật Khẩu";
            DoiMK_Btn.UseVisualStyleBackColor = false;
            DoiMK_Btn.Click += DoiMK_Btn_Click;
            // 
            // ChinhSua_Btn
            // 
            ChinhSua_Btn.BackColor = Color.LightCoral;
            ChinhSua_Btn.Dock = DockStyle.Fill;
            ChinhSua_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ChinhSua_Btn.Location = new Point(521, 64);
            ChinhSua_Btn.Margin = new Padding(0);
            ChinhSua_Btn.Name = "ChinhSua_Btn";
            ChinhSua_Btn.Size = new Size(180, 54);
            ChinhSua_Btn.TabIndex = 1;
            ChinhSua_Btn.Text = "Chỉnh Sửa";
            ChinhSua_Btn.UseVisualStyleBackColor = false;
            ChinhSua_Btn.Click += ChinhSua_Btn_Click;
            // 
            // CapNhat_Btn
            // 
            CapNhat_Btn.BackColor = Color.MediumSeaGreen;
            CapNhat_Btn.Dock = DockStyle.Fill;
            CapNhat_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            CapNhat_Btn.Location = new Point(526, 5);
            CapNhat_Btn.Margin = new Padding(5);
            CapNhat_Btn.Name = "CapNhat_Btn";
            CapNhat_Btn.Size = new Size(170, 54);
            CapNhat_Btn.TabIndex = 2;
            CapNhat_Btn.Text = "Cập Nhật";
            CapNhat_Btn.UseVisualStyleBackColor = false;
            CapNhat_Btn.Visible = false;
            CapNhat_Btn.Click += CapNhat_Btn_Click;
            // 
            // Huy_Btn
            // 
            Huy_Btn.BackColor = Color.Red;
            Huy_Btn.Dock = DockStyle.Fill;
            Huy_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Huy_Btn.Location = new Point(306, 5);
            Huy_Btn.Margin = new Padding(5);
            Huy_Btn.Name = "Huy_Btn";
            Huy_Btn.Size = new Size(170, 54);
            Huy_Btn.TabIndex = 3;
            Huy_Btn.Text = "Hủy";
            Huy_Btn.UseVisualStyleBackColor = false;
            Huy_Btn.Visible = false;
            Huy_Btn.Click += Huy_Btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Location = new Point(450, 138);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 156);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TTNDD_Btn
            // 
            TTNDD_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTNDD_Btn.BackColor = Color.LightCoral;
            TTNDD_Btn.FlatStyle = FlatStyle.Popup;
            TTNDD_Btn.Font = new Font("Cascadia Code", 12F);
            TTNDD_Btn.Location = new Point(4, 392);
            TTNDD_Btn.Margin = new Padding(4);
            TTNDD_Btn.Name = "TTNDD_Btn";
            TTNDD_Btn.Size = new Size(201, 80);
            TTNDD_Btn.TabIndex = 4;
            TTNDD_Btn.Text = "THÔNG TIN ĐẠI DIỆN";
            TTNDD_Btn.UseVisualStyleBackColor = false;
            TTNDD_Btn.Click += TTNDD_Btn_Click;
            // 
            // HOMEDN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 941);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
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
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private Button TTTV_Btn;
        private Button DKDT_Btn;
        private Button TT_Btn;
        private Button DRCB_Btn;
        private LinkLabel linkLabel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox Email_TxtBox;
        private TextBox SDT_TxtBox;
        private TextBox DiaChi_TxtBox;
        private TextBox NDD_TxtBox;
        private TextBox MaThue_TxtBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TenDN_TxtBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button DoiMK_Btn;
        private Button ChinhSua_Btn;
        private Button CapNhat_Btn;
        private Button Huy_Btn;
        private Button TTNDD_Btn;
    }
}