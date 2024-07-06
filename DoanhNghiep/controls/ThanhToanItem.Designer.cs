namespace UI_winform.DoanhNghiep
{
    partial class ThanhToanItem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            Tien_TxtBox = new TextBox();
            DTT_TxtBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            TT_TxtBox = new TextBox();
            MPQC_TxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MTT_TxtBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(677, 146);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Controls.Add(Tien_TxtBox, 1, 1);
            tableLayoutPanel3.Controls.Add(DTT_TxtBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Location = new Point(341, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel3.Size = new Size(332, 140);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // Tien_TxtBox
            // 
            Tien_TxtBox.Dock = DockStyle.Fill;
            Tien_TxtBox.Location = new Point(164, 49);
            Tien_TxtBox.Name = "Tien_TxtBox";
            Tien_TxtBox.Size = new Size(155, 31);
            Tien_TxtBox.TabIndex = 6;
            // 
            // DTT_TxtBox
            // 
            DTT_TxtBox.Dock = DockStyle.Fill;
            DTT_TxtBox.Location = new Point(164, 3);
            DTT_TxtBox.Name = "DTT_TxtBox";
            DTT_TxtBox.Size = new Size(155, 31);
            DTT_TxtBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 3;
            label4.Text = "Đợt thanh toán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(3, 46);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TT_TxtBox, 1, 2);
            tableLayoutPanel2.Controls.Add(MPQC_TxtBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(MTT_TxtBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.Size = new Size(332, 140);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // TT_TxtBox
            // 
            TT_TxtBox.Dock = DockStyle.Fill;
            TT_TxtBox.Location = new Point(169, 95);
            TT_TxtBox.Name = "TT_TxtBox";
            TT_TxtBox.Size = new Size(160, 31);
            TT_TxtBox.TabIndex = 5;
            // 
            // MPQC_TxtBox
            // 
            MPQC_TxtBox.Dock = DockStyle.Fill;
            MPQC_TxtBox.Location = new Point(169, 49);
            MPQC_TxtBox.Name = "MPQC_TxtBox";
            MPQC_TxtBox.Size = new Size(160, 31);
            MPQC_TxtBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã thanh toán:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu QC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 2;
            label3.Text = "Tình trạng:";
            // 
            // MTT_TxtBox
            // 
            MTT_TxtBox.Dock = DockStyle.Fill;
            MTT_TxtBox.Location = new Point(169, 3);
            MTT_TxtBox.Name = "MTT_TxtBox";
            MTT_TxtBox.Size = new Size(160, 31);
            MTT_TxtBox.TabIndex = 3;
            // 
            // ThanhToanItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "ThanhToanItem";
            Size = new Size(677, 146);
            Load += ThanhToanItem_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TT_TxtBox;
        private TextBox MPQC_TxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MTT_TxtBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox Tien_TxtBox;
        private TextBox DTT_TxtBox;
        private Label label4;
        private Label label5;
    }
}
