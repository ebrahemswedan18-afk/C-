namespace AlNorWholesale
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlBranding = new System.Windows.Forms.Panel();
            this.lblSysStatus = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.picBrandLogo = new System.Windows.Forms.PictureBox();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginSubtitle = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.pnlBranding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).BeginInit();
            this.pnlInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBranding
            // 
            this.pnlBranding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlBranding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBranding.Controls.Add(this.lblSysStatus);
            this.pnlBranding.Controls.Add(this.lblFeature3);
            this.pnlBranding.Controls.Add(this.lblFeature2);
            this.pnlBranding.Controls.Add(this.lblFeature1);
            this.pnlBranding.Controls.Add(this.picBrandLogo);
            this.pnlBranding.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBranding.Location = new System.Drawing.Point(495, 0);
            this.pnlBranding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBranding.Name = "pnlBranding";
            this.pnlBranding.Size = new System.Drawing.Size(484, 650);
            this.pnlBranding.TabIndex = 1;
            // 
            // lblSysStatus
            // 
            this.lblSysStatus.AutoSize = true;
            this.lblSysStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSysStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblSysStatus.Location = new System.Drawing.Point(129, 594);
            this.lblSysStatus.Name = "lblSysStatus";
            this.lblSysStatus.Size = new System.Drawing.Size(195, 25);
            this.lblSysStatus.TabIndex = 6;
            this.lblSysStatus.Text = "● النظام متصل ومحمي";
            this.lblSysStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeature3
            // 
            this.lblFeature3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature3.Location = new System.Drawing.Point(24, 519);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(393, 38);
            this.lblFeature3.TabIndex = 5;
            this.lblFeature3.Text = "🧾  فواتير مبيعات وحساب تلقائي للإجمالي";
            this.lblFeature3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFeature2
            // 
            this.lblFeature2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature2.Location = new System.Drawing.Point(29, 469);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(388, 38);
            this.lblFeature2.TabIndex = 4;
            this.lblFeature2.Text = "👥  إدارة بيانات العملاء والتواصل السريع";
            this.lblFeature2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFeature1
            // 
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature1.Location = new System.Drawing.Point(24, 424);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(393, 38);
            this.lblFeature1.TabIndex = 3;
            this.lblFeature1.Text = "📦  متابعة دقيقة للأصناف وأرصدة الكراتين";
            this.lblFeature1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBrandLogo
            // 
            this.picBrandLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.picBrandLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBrandLogo.ErrorImage = null;
            this.picBrandLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBrandLogo.Image")));
            this.picBrandLogo.ImageLocation = "";
            this.picBrandLogo.InitialImage = null;
            this.picBrandLogo.Location = new System.Drawing.Point(24, 13);
            this.picBrandLogo.Margin = new System.Windows.Forms.Padding(24);
            this.picBrandLogo.Name = "picBrandLogo";
            this.picBrandLogo.Padding = new System.Windows.Forms.Padding(16);
            this.picBrandLogo.Size = new System.Drawing.Size(393, 394);
            this.picBrandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrandLogo.TabIndex = 0;
            this.picBrandLogo.TabStop = false;
            // 
            // pnlInputs
            // 
            this.pnlInputs.AutoScroll = true;
            this.pnlInputs.BackColor = System.Drawing.Color.White;
            this.pnlInputs.Controls.Add(this.lblHint);
            this.pnlInputs.Controls.Add(this.lblErrorMessage);
            this.pnlInputs.Controls.Add(this.btnExit);
            this.pnlInputs.Controls.Add(this.btnLogin);
            this.pnlInputs.Controls.Add(this.chkShowPassword);
            this.pnlInputs.Controls.Add(this.txtPassword);
            this.pnlInputs.Controls.Add(this.lblPassword);
            this.pnlInputs.Controls.Add(this.txtEmail);
            this.pnlInputs.Controls.Add(this.lblEmail);
            this.pnlInputs.Controls.Add(this.txtUsername);
            this.pnlInputs.Controls.Add(this.lblUsername);
            this.pnlInputs.Controls.Add(this.lblLoginSubtitle);
            this.pnlInputs.Controls.Add(this.lblLoginTitle);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Location = new System.Drawing.Point(0, 0);
            this.pnlInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(495, 650);
            this.pnlInputs.TabIndex = 0;
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHint.Location = new System.Drawing.Point(32, 594);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(428, 31);
            this.lblHint.TabIndex = 12;
            this.lblHint.Text = "بيانات الدخول: ابراهيم | team@alnor.com| al123";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblErrorMessage.Location = new System.Drawing.Point(34, 469);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(428, 30);
            this.lblErrorMessage.TabIndex = 11;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorMessage.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnExit.Location = new System.Drawing.Point(34, 512);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 56);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(158, 516);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(304, 56);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "تسجيل الدخول  ➜";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.chkShowPassword.Location = new System.Drawing.Point(309, 431);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(170, 29);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "إظهار كلمة المرور";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(34, 381);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(427, 37);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPassword.Location = new System.Drawing.Point(351, 348);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 28);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "كلمة المرور:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(34, 288);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(427, 37);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblEmail.Location = new System.Drawing.Point(318, 254);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 28);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "البريد الإلكتروني:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(34, 194);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(427, 37);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblUsername.Location = new System.Drawing.Point(338, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(139, 28);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "اسم المستخدم:";
            // 
            // lblLoginSubtitle
            // 
            this.lblLoginSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLoginSubtitle.Location = new System.Drawing.Point(34, 94);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Size = new System.Drawing.Size(428, 38);
            this.lblLoginSubtitle.TabIndex = 1;
            this.lblLoginSubtitle.Text = "أهلاً بك مجدداً، يرجى إدخال بيانات الدخول للمتابعة";
            this.lblLoginSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(242, 38);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(231, 48);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "تسجيل الدخول";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(979, 650);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.pnlBranding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النور لتجارة الجملة - تسجيل الدخول";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlBranding.ResumeLayout(false);
            this.pnlBranding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).EndInit();
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlBranding;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Label lblSysStatus;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox picBrandLogo;
    }
}
