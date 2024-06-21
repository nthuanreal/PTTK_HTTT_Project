namespace UI_winform
{
    partial class DangKyDangTuyen2
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
            panelNavbar = new Panel();
            label6 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            panelRegister = new Panel();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            panelNavbar.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1068, 58);
            panelNavbar.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(11, 8);
            label6.Name = "label6";
            label6.Size = new Size(456, 35);
            label6.TabIndex = 1;
            label6.Text = "ĐĂNG KÝ ĐĂNG TUYỂN DỤNG";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(250, 135, 135);
            btnRegister.Location = new Point(407, 349);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 135, 135);
            btnCancel.Location = new Point(257, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "QUAY LẠI";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(148, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(487, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÌNH THỨC ĐĂNG TUYỂN DỤNG";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(217, 217, 217);
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(dateTimePicker2);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(dateTimePicker1);
            panelRegister.Controls.Add(checkedListBox1);
            panelRegister.Controls.Add(lblTitle);
            panelRegister.Controls.Add(btnCancel);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Location = new Point(185, 95);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(746, 439);
            panelRegister.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(257, 191);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 24;
            label4.Text = "Đến";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Location = new Point(308, 191);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(320, 32);
            dateTimePicker2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(257, 160);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 22;
            label3.Text = "Từ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(56, 243);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 21;
            label1.Text = "Hình thức đăng tuyển dụng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(56, 161);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 20;
            label2.Text = "Thời gian đăng tuyển";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(308, 160);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 32);
            dateTimePicker1.TabIndex = 18;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 11F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Báo giấy", "Banner Quảng cáo", "Đăng trên trang mạng" });
            checkedListBox1.Location = new Point(308, 243);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(320, 31);
            checkedListBox1.TabIndex = 17;
            // 
            // DangKyDangTuyen2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 682);
            Controls.Add(panelNavbar);
            Controls.Add(panelRegister);
            Name = "DangKyDangTuyen2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKyDangTuyen2";
            WindowState = FormWindowState.Maximized;
            Load += DangKyDangTuyen2_Load;
            Resize += DangKyDangTuyen2_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }



        #endregion
        private Panel panelNavbar;
        private Label label6;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblTitle;
        private Panel panelRegister;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker2;
    }
}