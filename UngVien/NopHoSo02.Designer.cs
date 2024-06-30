namespace UI_winform
{
    partial class NopHoSo02
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
            button1 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(506, 383);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 31;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 225);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 48);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 128);
            textBox1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 20);
            label5.TabIndex = 20;
            label5.Text = "Chứng từ, bằng cấp (nếu có)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 16;
            label1.Text = "Thông tin hồ sơ ứng tuyển";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(292, 383);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(103, 34);
            button2.TabIndex = 32;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // NopHoSo02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "NopHoSo02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NopHoSo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private Button button2;
    }
}