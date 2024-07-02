namespace UI_winform.NhanVien.controls
{
    partial class XuLyHopDong
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
            panelNavbar = new Panel();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            danhSachHopDong1 = new DanhSachHopDong();
            panelNavbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1145, 87);
            panelNavbar.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(8, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(279, 35);
            label6.TabIndex = 8;
            label6.Text = "XỬ LÝ HỢP ĐỒNG";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 90);
            button1.Name = "button1";
            button1.Size = new Size(174, 66);
            button1.TabIndex = 19;
            button1.Text = "Duyệt Tài Khoản";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(485, 90);
            button2.Name = "button2";
            button2.Size = new Size(174, 66);
            button2.TabIndex = 20;
            button2.Text = "Duyệt Hợp Đồng Đăng Tuyển";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(929, 90);
            button3.Name = "button3";
            button3.Size = new Size(174, 66);
            button3.TabIndex = 21;
            button3.Text = "Duyệt Tài Khoản";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(danhSachHopDong1);
            panel1.Location = new Point(3, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 612);
            panel1.TabIndex = 22;
            // 
            // danhSachHopDong1
            // 
            danhSachHopDong1.Dock = DockStyle.Fill;
            danhSachHopDong1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            danhSachHopDong1.Location = new Point(0, 0);
            danhSachHopDong1.Name = "danhSachHopDong1";
            danhSachHopDong1.Size = new Size(1139, 612);
            danhSachHopDong1.TabIndex = 0;
            // 
            // XuLyHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelNavbar);
            Name = "XuLyHopDong";
            Size = new Size(1145, 777);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private DanhSachHopDong danhSachHopDong1;
    }
}
