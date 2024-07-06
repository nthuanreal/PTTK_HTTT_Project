namespace UI_winform.DoanhNghiep
{
    partial class ThanhToan
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(482, 52);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN THANH TOÁN";
            // 
            // panel2
            // 
            panel2.Location = new Point(15, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 686);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(503, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 686);
            panel3.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(250, 135, 135);
            searchBtn.Location = new Point(91, 291);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 40);
            searchBtn.TabIndex = 35;
            searchBtn.Text = "Tra cứu";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 176, 176);
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã thanh toán", "Chờ xử lý", "Chưa thanh toán" });
            comboBox1.Location = new Point(115, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 33);
            comboBox1.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 33;
            label4.Text = "Tình trạng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Từ khóa";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(115, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 32);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(255, 176, 176);
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mã thanh toán", "Ngày giao dịch" });
            comboBox2.Location = new Point(115, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 33);
            comboBox2.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(12, 127);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 36;
            label5.Text = "Thông tin";
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ThanhToan";
            Size = new Size(800, 800);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button searchBtn;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
    }
}
