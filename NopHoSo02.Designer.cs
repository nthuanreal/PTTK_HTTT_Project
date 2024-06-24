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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(297, 477);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 31;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 281);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 31);
            textBox4.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(770, 159);
            textBox1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 241);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 20;
            label5.Text = "Chứng từ, bằng cấp (nếu có)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 23);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 16;
            label1.Text = "Thông tin hồ sơ ứng tuyển";
            // 
            // NopHoSo02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 725);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "NopHoSo02";
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
    }
}