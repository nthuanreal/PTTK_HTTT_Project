namespace UI_winform.NhanVien.controls
{
    partial class TaiKhoanListItem
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
            tenDoanhNghiepTxt = new Label();
            label2 = new Label();
            maSoThueTxt = new Label();
            AcceptBtn = new Button();
            ignoreBtn = new Button();
            SuspendLayout();
            // 
            // tenDoanhNghiepTxt
            // 
            tenDoanhNghiepTxt.AutoSize = true;
            tenDoanhNghiepTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenDoanhNghiepTxt.Location = new Point(14, 9);
            tenDoanhNghiepTxt.Name = "tenDoanhNghiepTxt";
            tenDoanhNghiepTxt.Size = new Size(153, 25);
            tenDoanhNghiepTxt.TabIndex = 0;
            tenDoanhNghiepTxt.Text = "Doanh Nghiệp A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 45);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "MST:";
            // 
            // maSoThueTxt
            // 
            maSoThueTxt.AutoSize = true;
            maSoThueTxt.Location = new Point(71, 45);
            maSoThueTxt.Name = "maSoThueTxt";
            maSoThueTxt.Size = new Size(112, 25);
            maSoThueTxt.TabIndex = 2;
            maSoThueTxt.Text = "0123456789";
            // 
            // AcceptBtn
            // 
            AcceptBtn.BackColor = Color.FromArgb(195, 226, 130);
            AcceptBtn.FlatAppearance.BorderSize = 0;
            AcceptBtn.Location = new Point(772, 26);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(94, 32);
            AcceptBtn.TabIndex = 3;
            AcceptBtn.Text = "Duyệt";
            AcceptBtn.UseVisualStyleBackColor = false;
            // 
            // ignoreBtn
            // 
            ignoreBtn.BackColor = Color.FromArgb(228, 102, 102);
            ignoreBtn.FlatAppearance.BorderSize = 0;
            ignoreBtn.Location = new Point(872, 26);
            ignoreBtn.Name = "ignoreBtn";
            ignoreBtn.Size = new Size(94, 32);
            ignoreBtn.TabIndex = 4;
            ignoreBtn.Text = "Từ chối";
            ignoreBtn.UseVisualStyleBackColor = false;
            // 
            // TaiKhoanListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ignoreBtn);
            Controls.Add(AcceptBtn);
            Controls.Add(maSoThueTxt);
            Controls.Add(label2);
            Controls.Add(tenDoanhNghiepTxt);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "TaiKhoanListItem";
            Size = new Size(978, 80);
            Load += TaiKhoanListItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tenDoanhNghiepTxt;
        private Label label2;
        private Label maSoThueTxt;
        private Button AcceptBtn;
        private Button ignoreBtn;
    }
}
