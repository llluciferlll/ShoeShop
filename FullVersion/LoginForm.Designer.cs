namespace ShoeShop
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // picLogo
            //
            picLogo.ImageLocation = "Icon.png";
            picLogo.Location = new Point(150, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblLogin
            //
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(30, 138);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(50, 20);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Логин:";
            //
            // txtLogin
            //
            txtLogin.Location = new Point(120, 135);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 27);
            txtLogin.TabIndex = 2;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 178);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль:";
            //
            // txtPassword
            //
            txtPassword.Location = new Point(120, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            //
            // btnLogin
            //
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.Location = new Point(120, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            //
            // btnGuest
            //
            btnGuest.Location = new Point(120, 265);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(250, 35);
            btnGuest.TabIndex = 6;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            //
            // LoginForm
            //
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(400, 320);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО «Обувь» — Вход в систему";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGuest;
    }
}
