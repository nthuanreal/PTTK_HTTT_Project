namespace UI_winform.User.Login
{
    partial class DoiMatKhau
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
            panelChangePassword = new Panel();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            labelCurrentPassword = new Label();
            textBoxCurrentPassword = new TextBox();
            lblTitle = new Label();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblValidation = new Label();
            btnSubmit = new Button();
            linkBack = new LinkLabel();
            panelChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelChangePassword
            // 
            panelChangePassword.BackColor = Color.FromArgb(217, 217, 217);
            panelChangePassword.BorderStyle = BorderStyle.FixedSingle;
            panelChangePassword.Controls.Add(labelConfirmPassword);
            panelChangePassword.Controls.Add(textBoxConfirmPassword);
            panelChangePassword.Controls.Add(labelCurrentPassword);
            panelChangePassword.Controls.Add(textBoxCurrentPassword);
            panelChangePassword.Controls.Add(lblTitle);
            panelChangePassword.Controls.Add(lblNewPassword);
            panelChangePassword.Controls.Add(txtNewPassword);
            panelChangePassword.Controls.Add(lblValidation);
            panelChangePassword.Controls.Add(btnSubmit);
            panelChangePassword.Controls.Add(linkBack);
            panelChangePassword.Location = new Point(109, 45);
            panelChangePassword.Margin = new Padding(4, 4, 4, 4);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(774, 588);
            panelChangePassword.TabIndex = 1;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 13F);
            labelConfirmPassword.Location = new Point(156, 346);
            labelConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(223, 36);
            labelConfirmPassword.TabIndex = 9;
            labelConfirmPassword.Text = "Nhập lại mật khẩu";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 12F);
            textBoxConfirmPassword.Location = new Point(156, 394);
            textBoxConfirmPassword.Margin = new Padding(4, 4, 4, 4);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(475, 39);
            textBoxConfirmPassword.TabIndex = 10;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.Font = new Font("Segoe UI", 13F);
            labelCurrentPassword.Location = new Point(156, 122);
            labelCurrentPassword.Margin = new Padding(4, 0, 4, 0);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(215, 36);
            labelCurrentPassword.TabIndex = 7;
            labelCurrentPassword.Text = "Mật khẩu hiện tại";
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Font = new Font("Segoe UI", 12F);
            textBoxCurrentPassword.Location = new Point(156, 170);
            textBoxCurrentPassword.Margin = new Padding(4, 4, 4, 4);
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(475, 39);
            textBoxCurrentPassword.TabIndex = 8;
            textBoxCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(214, 34);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(363, 63);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13F);
            lblNewPassword.Location = new Point(156, 236);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(174, 36);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(156, 284);
            txtNewPassword.Margin = new Padding(4, 4, 4, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(475, 39);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblValidation
            // 
            lblValidation.AutoSize = true;
            lblValidation.ForeColor = Color.Red;
            lblValidation.ImageAlign = ContentAlignment.TopRight;
            lblValidation.Location = new Point(156, 440);
            lblValidation.Margin = new Padding(4, 0, 4, 0);
            lblValidation.Name = "lblValidation";
            lblValidation.Size = new Size(90, 25);
            lblValidation.TabIndex = 3;
            lblValidation.Text = "*message";
            lblValidation.TextAlign = ContentAlignment.MiddleRight;
            lblValidation.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(250, 135, 135);
            btnSubmit.Location = new Point(315, 490);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(170, 54);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.Location = new Point(649, 541);
            linkBack.Margin = new Padding(4, 0, 4, 0);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(76, 25);
            linkBack.TabIndex = 6;
            linkBack.TabStop = true;
            linkBack.Text = "Quay lại";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 691);
            Controls.Add(panelChangePassword);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(994, 736);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChangePassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelCurrentPassword;
        private TextBox textBoxCurrentPassword;
        private Label lblTitle;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblValidation;
        private Button btnSubmit;
        private LinkLabel linkBack;
    }
}