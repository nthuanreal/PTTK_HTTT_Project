namespace UI_winform.DoanhNghiep
{
    partial class UuDai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UuDai));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            DangKyNgay_Btn = new Button();
            chinhSachItem1 = new ChinhSachItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(4, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 63);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN VỀ CHÚNG TÔI";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 106);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(richTextBox1);
            panel2.Location = new Point(-1, 114);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 284);
            panel2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(5, 8);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1013, 264);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // DangKyNgay_Btn
            // 
            DangKyNgay_Btn.BackColor = Color.LightCoral;
            DangKyNgay_Btn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangKyNgay_Btn.Location = new Point(791, 890);
            DangKyNgay_Btn.Margin = new Padding(4, 4, 4, 4);
            DangKyNgay_Btn.Name = "DangKyNgay_Btn";
            DangKyNgay_Btn.Size = new Size(210, 52);
            DangKyNgay_Btn.TabIndex = 3;
            DangKyNgay_Btn.Text = "Đăng ký ngay";
            DangKyNgay_Btn.UseVisualStyleBackColor = false;
            DangKyNgay_Btn.Click += DangKyNgay_Btn_Click;
            // 
            // chinhSachItem1
            // 
            chinhSachItem1.Location = new Point(-1, 461);
            chinhSachItem1.Margin = new Padding(5, 5, 5, 5);
            chinhSachItem1.Name = "chinhSachItem1";
            chinhSachItem1.Size = new Size(1021, 130);
            chinhSachItem1.TabIndex = 4;
            // 
            // UuDai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(chinhSachItem1);
            Controls.Add(DangKyNgay_Btn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UuDai";
            Size = new Size(1022, 998);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Button DangKyNgay_Btn;
        private ChinhSachItem chinhSachItem1;
    }
}
