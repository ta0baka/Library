namespace Library
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPassword = new TextBox();
            lPassword = new Label();
            lLogin = new Label();
            lLoginAccount = new Label();
            chbPassword = new CheckBox();
            btnLogin = new Button();
            llRegister = new LinkLabel();
            tbLogin = new TextBox();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.DarkSlateGray;
            tbPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.ForeColor = Color.MintCream;
            tbPassword.Location = new Point(351, 191);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(199, 34);
            tbPassword.TabIndex = 10;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Century Gothic", 22.2F);
            lPassword.ForeColor = Color.MintCream;
            lPassword.Location = new Point(191, 181);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(156, 44);
            lPassword.TabIndex = 7;
            lPassword.Text = "Пароль";
            // 
            // lLogin
            // 
            lLogin.AutoSize = true;
            lLogin.Font = new Font("Century Gothic", 22.2F);
            lLogin.ForeColor = Color.MintCream;
            lLogin.Location = new Point(200, 100);
            lLogin.Name = "lLogin";
            lLogin.Size = new Size(127, 44);
            lLogin.TabIndex = 6;
            lLogin.Text = "Логин";
            // 
            // lLoginAccount
            // 
            lLoginAccount.AutoSize = true;
            lLoginAccount.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lLoginAccount.ForeColor = Color.MintCream;
            lLoginAccount.Location = new Point(203, 18);
            lLoginAccount.Name = "lLoginAccount";
            lLoginAccount.Size = new Size(360, 51);
            lLoginAccount.TabIndex = 12;
            lLoginAccount.Text = "Вход в аккаунт";
            // 
            // chbPassword
            // 
            chbPassword.AutoSize = true;
            chbPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chbPassword.ForeColor = Color.MintCream;
            chbPassword.Location = new Point(351, 231);
            chbPassword.Name = "chbPassword";
            chbPassword.Size = new Size(177, 25);
            chbPassword.TabIndex = 13;
            chbPassword.Text = "Показать пароль";
            chbPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.MintCream;
            btnLogin.Location = new Point(301, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 56);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // llRegister
            // 
            llRegister.AutoSize = true;
            llRegister.DisabledLinkColor = Color.MintCream;
            llRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            llRegister.LinkColor = Color.MintCream;
            llRegister.Location = new Point(274, 357);
            llRegister.Name = "llRegister";
            llRegister.Size = new Size(216, 23);
            llRegister.TabIndex = 15;
            llRegister.TabStop = true;
            llRegister.Text = "Еще не смешарик?";
            llRegister.LinkClicked += llRegister_LinkClicked;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = Color.DarkSlateGray;
            tbLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLogin.ForeColor = Color.MintCream;
            tbLogin.Location = new Point(351, 110);
            tbLogin.Multiline = true;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(199, 34);
            tbLogin.TabIndex = 16;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(732, 403);
            Controls.Add(tbLogin);
            Controls.Add(llRegister);
            Controls.Add(btnLogin);
            Controls.Add(chbPassword);
            Controls.Add(lLoginAccount);
            Controls.Add(tbPassword);
            Controls.Add(lPassword);
            Controls.Add(lLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Авторизация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPassword;
        private Label lPassword;
        private Label lLogin;
        private Label lLoginAccount;
        private CheckBox chbPassword;
        private Button btnLogin;
        private LinkLabel llRegister;
        private TextBox tbLogin;
    }
}
