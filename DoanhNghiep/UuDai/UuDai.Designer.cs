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
            button1 = new Button();
            chinhSachItem1 = new ChinhSachItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(528, 52);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 85);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(richTextBox1);
            panel2.Location = new Point(-1, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 227);
            panel2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(4, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(813, 212);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(633, 712);
            button1.Name = "button1";
            button1.Size = new Size(168, 42);
            button1.TabIndex = 3;
            button1.Text = "Đăng ký ngay";
            button1.UseVisualStyleBackColor = false;
            // 
            // chinhSachItem1
            // 
            chinhSachItem1.Location = new Point(-1, 369);
            chinhSachItem1.Name = "chinhSachItem1";
            chinhSachItem1.Size = new Size(817, 104);
            chinhSachItem1.TabIndex = 4;
            // 
            // UuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chinhSachItem1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UuDai";
            Size = new Size(819, 800);
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
        private Button button1;
        private ChinhSachItem chinhSachItem1;
    }
}
