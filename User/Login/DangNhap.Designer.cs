namespace UI_winform
{
    partial class DangNhap
    {


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
            panelLogin = new Panel();
            txtRole = new ComboBox();
            IblRole = new Label();
            btnTogglePassword = new Button();
            lblLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            linkForgotPassword = new LinkLabel();
            linkRegisterApplicant = new LinkLabel();
            linkRegisterEmployer = new LinkLabel();
            txtPassword = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(217, 217, 217);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(txtRole);
            panelLogin.Controls.Add(IblRole);
            panelLogin.Controls.Add(btnTogglePassword);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(linkForgotPassword);
            panelLogin.Controls.Add(linkRegisterApplicant);
            panelLogin.Controls.Add(linkRegisterEmployer);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Location = new Point(102, 35);
            panelLogin.Margin = new Padding(4, 4, 4, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(774, 617);
            panelLogin.TabIndex = 0;
            panelLogin.TabStop = true;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 11F);
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Quản trị viên", "Doanh nghiệp", "Ứng viên", "Nhân viên" });
            txtRole.Location = new Point(291, 314);
            txtRole.Margin = new Padding(4, 4, 4, 4);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(285, 38);
            txtRole.TabIndex = 10;
            // 
            // IblRole
            // 
            IblRole.AutoSize = true;
            IblRole.Font = new Font("Segoe UI", 12F);
            IblRole.Location = new Point(195, 315);
            IblRole.Margin = new Padding(4, 0, 4, 0);
            IblRole.Name = "IblRole";
            IblRole.Size = new Size(82, 32);
            IblRole.TabIndex = 9;
            IblRole.Text = "Vai trò";
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = SystemColors.ControlLightLight;
            btnTogglePassword.BackgroundImageLayout = ImageLayout.None;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnTogglePassword.Location = new Point(544, 244);
            btnTogglePassword.Margin = new Padding(4, 4, 4, 4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(31, 31);
            btnTogglePassword.TabIndex = 5;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.MouseDown += btnTogglePassword_MouseDown;
            btnTogglePassword.MouseUp += btnTogglePassword_MouseUp;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblLogin.Location = new Point(268, 25);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(235, 43);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "ĐĂNG NHẬP";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(195, 109);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(115, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tài khoản";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(195, 200);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 32);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(195, 148);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(382, 37);
            txtUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 135, 135);
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.Location = new Point(291, 432);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(430, 381);
            linkForgotPassword.Margin = new Padding(4, 0, 4, 0);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(142, 25);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Quên mật khẩu?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // linkRegisterApplicant
            // 
            linkRegisterApplicant.AutoSize = true;
            linkRegisterApplicant.Location = new Point(121, 532);
            linkRegisterApplicant.Margin = new Padding(4, 0, 4, 0);
            linkRegisterApplicant.Name = "linkRegisterApplicant";
            linkRegisterApplicant.Size = new Size(308, 25);
            linkRegisterApplicant.TabIndex = 7;
            linkRegisterApplicant.TabStop = true;
            linkRegisterApplicant.Text = "Chưa có tài khoản ứng viên? Đăng ký";
            linkRegisterApplicant.LinkClicked += linkRegisterApplicant_LinkClicked;
            // 
            // linkRegisterEmployer
            // 
            linkRegisterEmployer.AutoSize = true;
            linkRegisterEmployer.Location = new Point(121, 571);
            linkRegisterEmployer.Margin = new Padding(4, 0, 4, 0);
            linkRegisterEmployer.Name = "linkRegisterEmployer";
            linkRegisterEmployer.Size = new Size(418, 25);
            linkRegisterEmployer.TabIndex = 8;
            linkRegisterEmployer.TabStop = true;
            linkRegisterEmployer.Text = "Doanh nghiệp cần đăng tuyển? Đăng ký thành viên";
            linkRegisterEmployer.LinkClicked += linkRegisterEmployer_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(195, 239);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(382, 37);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 691);
            Controls.Add(panelLogin);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(994, 736);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            Load += DangNhap_Load;
            Resize += DangNhap_Resize;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        private Panel panelLogin;
        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegisterApplicant;
        private LinkLabel linkRegisterEmployer;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion


        protected internal Button btnTogglePassword;
        private ComboBox txtRole;
        private Label IblRole;
    }
}