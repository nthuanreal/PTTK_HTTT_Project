namespace UI_winform
{
    partial class TraCuuViTriUngTuyen
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(997, 49);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 31;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(511, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 31);
            textBox1.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 18);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 20;
            label5.Text = "TÌM KIẾM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 61);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 32;
            label1.Text = "Vị trí";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Nhân viên chính thức", "Bán thời gian", "Thực tập sinh", "Tất cả" });
            checkedListBox1.Location = new Point(131, 60);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(253, 32);
            checkedListBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 61);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 34;
            label2.Text = "Mức lương";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 63);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 36;
            label3.Text = "Từ khóa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(815, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 31);
            textBox2.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(958, 462);
            dataGridView1.TabIndex = 37;
            // 
            // TraCuuViTriUngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 725);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Name = "TraCuuViTriUngTuyen";
            Text = "TraCuuViTriUngTuyen";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private BindingSource bindingSource1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}