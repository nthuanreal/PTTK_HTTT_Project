namespace UI_winform.DoanhNghiep.controls
{
    partial class ThongTinNDD
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
            ChinhSua_Btn = new Button();
            Huy_Btn = new Button();
            Email_TxtBox = new TextBox();
            DiaChi_TxtBox = new TextBox();
            SDT_TxtBox = new TextBox();
            GioiTinh_TxtBox = new TextBox();
            NgSinh_TxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            CapNhat_Btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TenNDD_TxtBox = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ChinhSua_Btn
            // 
            ChinhSua_Btn.BackColor = Color.LightCoral;
            ChinhSua_Btn.Dock = DockStyle.Fill;
            ChinhSua_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ChinhSua_Btn.Location = new Point(722, 64);
            ChinhSua_Btn.Margin = new Padding(0);
            ChinhSua_Btn.Name = "ChinhSua_Btn";
            ChinhSua_Btn.Size = new Size(250, 55);
            ChinhSua_Btn.TabIndex = 1;
            ChinhSua_Btn.Text = "Chỉnh Sửa";
            ChinhSua_Btn.UseVisualStyleBackColor = false;
            ChinhSua_Btn.Click += ChinhSua_Btn_Click;
            // 
            // Huy_Btn
            // 
            Huy_Btn.BackColor = Color.Red;
            Huy_Btn.Dock = DockStyle.Fill;
            Huy_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Huy_Btn.Location = new Point(422, 5);
            Huy_Btn.Margin = new Padding(5);
            Huy_Btn.Name = "Huy_Btn";
            Huy_Btn.Size = new Size(240, 54);
            Huy_Btn.TabIndex = 3;
            Huy_Btn.Text = "Hủy";
            Huy_Btn.UseVisualStyleBackColor = false;
            Huy_Btn.Visible = false;
            Huy_Btn.Click += Huy_Btn_Click;
            // 
            // Email_TxtBox
            // 
            Email_TxtBox.Font = new Font("Cascadia Code", 12F);
            Email_TxtBox.Location = new Point(502, 519);
            Email_TxtBox.Margin = new Padding(4);
            Email_TxtBox.Name = "Email_TxtBox";
            Email_TxtBox.Size = new Size(648, 35);
            Email_TxtBox.TabIndex = 11;
            // 
            // DiaChi_TxtBox
            // 
            DiaChi_TxtBox.Font = new Font("Cascadia Code", 12F);
            DiaChi_TxtBox.Location = new Point(502, 424);
            DiaChi_TxtBox.Margin = new Padding(4);
            DiaChi_TxtBox.Name = "DiaChi_TxtBox";
            DiaChi_TxtBox.Size = new Size(648, 35);
            DiaChi_TxtBox.TabIndex = 10;
            // 
            // SDT_TxtBox
            // 
            SDT_TxtBox.Font = new Font("Cascadia Code", 12F);
            SDT_TxtBox.Location = new Point(502, 329);
            SDT_TxtBox.Margin = new Padding(4);
            SDT_TxtBox.Name = "SDT_TxtBox";
            SDT_TxtBox.Size = new Size(648, 35);
            SDT_TxtBox.TabIndex = 9;
            // 
            // GioiTinh_TxtBox
            // 
            GioiTinh_TxtBox.Font = new Font("Cascadia Code", 12F);
            GioiTinh_TxtBox.Location = new Point(502, 234);
            GioiTinh_TxtBox.Margin = new Padding(4);
            GioiTinh_TxtBox.Name = "GioiTinh_TxtBox";
            GioiTinh_TxtBox.Size = new Size(648, 35);
            GioiTinh_TxtBox.TabIndex = 8;
            // 
            // NgSinh_TxtBox
            // 
            NgSinh_TxtBox.Font = new Font("Cascadia Code", 12F);
            NgSinh_TxtBox.Location = new Point(502, 139);
            NgSinh_TxtBox.Margin = new Padding(4);
            NgSinh_TxtBox.Name = "NgSinh_TxtBox";
            NgSinh_TxtBox.Size = new Size(648, 35);
            NgSinh_TxtBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(44, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(44, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 32);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(ChinhSua_Btn, 3, 1);
            tableLayoutPanel3.Controls.Add(CapNhat_Btn, 3, 0);
            tableLayoutPanel3.Controls.Add(Huy_Btn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 760);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Size = new Size(1392, 185);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // CapNhat_Btn
            // 
            CapNhat_Btn.BackColor = Color.MediumSeaGreen;
            CapNhat_Btn.Dock = DockStyle.Fill;
            CapNhat_Btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            CapNhat_Btn.Location = new Point(727, 5);
            CapNhat_Btn.Margin = new Padding(5);
            CapNhat_Btn.Name = "CapNhat_Btn";
            CapNhat_Btn.Size = new Size(240, 54);
            CapNhat_Btn.TabIndex = 2;
            CapNhat_Btn.Text = "Cập Nhật";
            CapNhat_Btn.UseVisualStyleBackColor = false;
            CapNhat_Btn.Visible = false;
            CapNhat_Btn.Click += CapNhat_Btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1398, 948);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1390, 86);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(699, 63);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN NGƯỜI ĐẠI DIỆN";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(Email_TxtBox, 1, 5);
            tableLayoutPanel2.Controls.Add(DiaChi_TxtBox, 1, 4);
            tableLayoutPanel2.Controls.Add(SDT_TxtBox, 1, 3);
            tableLayoutPanel2.Controls.Add(GioiTinh_TxtBox, 1, 2);
            tableLayoutPanel2.Controls.Add(NgSinh_TxtBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(TenNDD_TxtBox, 1, 0);
            tableLayoutPanel2.Location = new Point(4, 98);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(40);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66389F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672211F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6672249F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66722F));
            tableLayoutPanel2.Size = new Size(1390, 655);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(44, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 2;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(44, 325);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(210, 32);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(44, 420);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(44, 515);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // TenNDD_TxtBox
            // 
            TenNDD_TxtBox.Font = new Font("Cascadia Code", 12F);
            TenNDD_TxtBox.Location = new Point(502, 44);
            TenNDD_TxtBox.Margin = new Padding(4);
            TenNDD_TxtBox.Name = "TenNDD_TxtBox";
            TenNDD_TxtBox.Size = new Size(648, 35);
            TenNDD_TxtBox.TabIndex = 6;
            // 
            // ThongTinNDD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ThongTinNDD";
            Size = new Size(1398, 948);
            Load += ThongTinNDD_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ChinhSua_Btn;
        private Button Huy_Btn;
        private TextBox Email_TxtBox;
        private TextBox DiaChi_TxtBox;
        private TextBox SDT_TxtBox;
        private TextBox GioiTinh_TxtBox;
        private TextBox NgSinh_TxtBox;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CapNhat_Btn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TenNDD_TxtBox;
    }
}
