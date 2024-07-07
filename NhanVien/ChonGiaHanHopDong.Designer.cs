namespace UI_winform.NhanVien
{
    partial class ChonGiaHanHopDong
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
            label1 = new Label();
            xuatDanhSachBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hợp đồng sắp hết hạn";
            // 
            // xuatDanhSachBtn
            // 
            xuatDanhSachBtn.BackColor = SystemColors.ActiveCaption;
            xuatDanhSachBtn.Location = new Point(12, 67);
            xuatDanhSachBtn.Name = "xuatDanhSachBtn";
            xuatDanhSachBtn.Size = new Size(175, 37);
            xuatDanhSachBtn.TabIndex = 2;
            xuatDanhSachBtn.Text = "Xuất danh sách";
            xuatDanhSachBtn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 139);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(882, 419);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // ChonGiaHanHopDong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 610);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(xuatDanhSachBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ChonGiaHanHopDong";
            Text = "ChonGiaHanHopDong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button xuatDanhSachBtn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}