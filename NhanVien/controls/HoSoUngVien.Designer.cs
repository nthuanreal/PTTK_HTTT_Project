namespace UI_winform.NhanVien.controls
{
    partial class HoSoUngVien
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panelNavbar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panelNavbar.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(8, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(270, 35);
            label6.TabIndex = 8;
            label6.Text = "HỒ SƠ ỨNG VIÊN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1145, 572);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(859, 566);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(868, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 566);
            panel1.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(250, 135, 135);
            searchBtn.Location = new Point(107, 112);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 40);
            searchBtn.TabIndex = 35;
            searchBtn.Text = "Tra cứu";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 176, 176);
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chưa duyệt", "Đã duyệt", "Gia hạn" });
            comboBox1.Location = new Point(107, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 31);
            comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(4, 34);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 33;
            label2.Text = "Tình trạng";
            // 
            // HoSoUngVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelNavbar);
            MinimumSize = new Size(1145, 777);
            Name = "HoSoUngVien";
            Size = new Size(1145, 777);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button searchBtn;
        private ComboBox comboBox1;
        private Label label2;
    }
}
