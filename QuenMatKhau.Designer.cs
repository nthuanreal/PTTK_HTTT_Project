namespace UI_winform
{
    partial class QuenMatKhau
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

        private void InitializeComponent()
        {
            panelForgotPassword = new Panel();
            lblTitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmailValidation = new Label();
            linkNotReceivedEmail = new LinkLabel();
            btnSubmit = new Button();
            linkBack = new LinkLabel();
            lblFooterMessage = new Label();
            panelForgotPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelForgotPassword
            // 
            panelForgotPassword.BorderStyle = BorderStyle.FixedSingle;
            panelForgotPassword.Controls.Add(lblTitle);
            panelForgotPassword.Controls.Add(lblEmail);
            panelForgotPassword.Controls.Add(txtEmail);
            panelForgotPassword.Controls.Add(lblEmailValidation);
            panelForgotPassword.Controls.Add(linkNotReceivedEmail);
            panelForgotPassword.Controls.Add(btnSubmit);
            panelForgotPassword.Controls.Add(linkBack);
            panelForgotPassword.Controls.Add(lblFooterMessage);
            panelForgotPassword.Location = new Point(211, 66);
            panelForgotPassword.Name = "panelForgotPassword";
            panelForgotPassword.Size = new Size(400, 300);
            panelForgotPassword.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quên mật khẩu";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 2;
            // 
            // lblEmailValidation
            // 
            lblEmailValidation.AutoSize = true;
            lblEmailValidation.ForeColor = Color.Red;
            lblEmailValidation.Location = new Point(80, 90);
            lblEmailValidation.Name = "lblEmailValidation";
            lblEmailValidation.Size = new Size(282, 20);
            lblEmailValidation.TabIndex = 3;
            lblEmailValidation.Text = "Email không hợp lệ! / Đã gửi thành công!";
            lblEmailValidation.Visible = false;
            // 
            // linkNotReceivedEmail
            // 
            linkNotReceivedEmail.AutoSize = true;
            linkNotReceivedEmail.Location = new Point(80, 115);
            linkNotReceivedEmail.Name = "linkNotReceivedEmail";
            linkNotReceivedEmail.Size = new Size(187, 20);
            linkNotReceivedEmail.TabIndex = 4;
            linkNotReceivedEmail.TabStop = true;
            linkNotReceivedEmail.Text = "Tôi chưa nhận được email?";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(140, 150);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.Location = new Point(170, 190);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(63, 20);
            linkBack.TabIndex = 6;
            linkBack.TabStop = true;
            linkBack.Text = "Quay lại";
            // 
            // lblFooterMessage
            // 
            lblFooterMessage.AutoSize = true;
            lblFooterMessage.ForeColor = Color.Red;
            lblFooterMessage.Location = new Point(10, 220);
            lblFooterMessage.Name = "lblFooterMessage";
            lblFooterMessage.Size = new Size(435, 20);
            lblFooterMessage.TabIndex = 7;
            lblFooterMessage.Text = "Mật khẩu mới sẽ được gửi đến email. Vui lòng kiểm tra hòm thư.";
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 423);
            Controls.Add(panelForgotPassword);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            Resize += QuenMatKhau_Resize;
            panelForgotPassword.ResumeLayout(false);
            panelForgotPassword.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
        private Panel panelForgotPassword;
        private Label lblTitle;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmailValidation;
        private LinkLabel linkNotReceivedEmail;
        private Button btnSubmit;
        private LinkLabel linkBack;
        private Label lblFooterMessage;
    }
}