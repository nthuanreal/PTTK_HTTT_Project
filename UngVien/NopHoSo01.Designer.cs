namespace UI_winform
{
    partial class NopHoSo01
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
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(446, 569);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 31;
            button1.Text = "Tiếp theo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(446, 246);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Đại học", "Cao Đẳng", "Trung cấp" });
            checkedListBox1.Location = new Point(446, 440);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(139, 26);
            checkedListBox1.TabIndex = 29;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(581, 490);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 24);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(446, 490);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(446, 392);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(446, 343);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(446, 290);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 202);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 493);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 22;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 446);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 21;
            label6.Text = "Trình độ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 394);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 346);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 19;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 295);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 18;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 246);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 17;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 202);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 16;
            label1.Text = "Họ tên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(354, 98);
            label8.Name = "label8";
            label8.Size = new Size(299, 37);
            label8.TabIndex = 32;
            label8.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // NopHoSo01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "NopHoSo01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NopHoSo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}