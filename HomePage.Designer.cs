namespace UI_winform
{
    partial class HomePage
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
            btnDKyDangTuyen = new Button();
            panelNavbar = new Panel();
            label6 = new Label();
            linkBack = new LinkLabel();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnDKyDangTuyen
            // 
            btnDKyDangTuyen.BackColor = Color.FromArgb(250, 135, 135);
            btnDKyDangTuyen.Location = new Point(105, 129);
            btnDKyDangTuyen.Name = "btnDKyDangTuyen";
            btnDKyDangTuyen.Size = new Size(185, 38);
            btnDKyDangTuyen.TabIndex = 15;
            btnDKyDangTuyen.Text = "ĐĂNG KÝ ĐĂNG TUYỂN";
            btnDKyDangTuyen.UseVisualStyleBackColor = false;
            btnDKyDangTuyen.Click += btnDKyDangTuyen_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Controls.Add(linkBack);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(982, 58);
            panelNavbar.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(11, 8);
            label6.Name = "label6";
            label6.Size = new Size(187, 35);
            label6.TabIndex = 8;
            label6.Text = "HOMEPAGE";
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.Location = new Point(896, 17);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(77, 20);
            linkBack.TabIndex = 7;
            linkBack.TabStop = true;
            linkBack.Text = "Đăng xuất";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 551);
            Controls.Add(btnDKyDangTuyen);
            Controls.Add(panelNavbar);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            Resize += HomePage_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDKyDangTuyen;
        private Panel panelNavbar;
        private LinkLabel linkBack;
        private Label label6;
    }
}