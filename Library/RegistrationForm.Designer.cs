namespace Library
{
    partial class RegistrationForm
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
            checkBox1 = new CheckBox();
            lRegister = new Label();
            llAuthorization = new LinkLabel();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            lPassword = new Label();
            lLogin = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.ForeColor = Color.MintCream;
            checkBox1.Location = new Point(347, 233);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(177, 25);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lRegister
            // 
            lRegister.AutoSize = true;
            lRegister.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lRegister.ForeColor = Color.MintCream;
            lRegister.Location = new Point(219, 20);
            lRegister.Name = "lRegister";
            lRegister.Size = new Size(308, 51);
            lRegister.TabIndex = 20;
            lRegister.Text = "Регистрация";
            // 
            // llAuthorization
            // 
            llAuthorization.AutoSize = true;
            llAuthorization.DisabledLinkColor = Color.MintCream;
            llAuthorization.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            llAuthorization.LinkColor = Color.MintCream;
            llAuthorization.Location = new Point(284, 363);
            llAuthorization.Name = "llAuthorization";
            llAuthorization.Size = new Size(182, 23);
            llAuthorization.TabIndex = 19;
            llAuthorization.TabStop = true;
            llAuthorization.Text = "Уже смешарик?";
            llAuthorization.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.DarkSlateGray;
            tbPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.ForeColor = Color.MintCream;
            tbPassword.Location = new Point(347, 193);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(199, 34);
            tbPassword.TabIndex = 18;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = Color.DarkSlateGray;
            tbLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLogin.ForeColor = Color.MintCream;
            tbLogin.Location = new Point(347, 112);
            tbLogin.Multiline = true;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(199, 34);
            tbLogin.TabIndex = 17;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Century Gothic", 22.2F);
            lPassword.ForeColor = Color.MintCream;
            lPassword.Location = new Point(187, 183);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(156, 44);
            lPassword.TabIndex = 15;
            lPassword.Text = "Пароль";
            // 
            // lLogin
            // 
            lLogin.AutoSize = true;
            lLogin.Font = new Font("Century Gothic", 22.2F);
            lLogin.ForeColor = Color.MintCream;
            lLogin.Location = new Point(196, 102);
            lLogin.Name = "lLogin";
            lLogin.Size = new Size(127, 44);
            lLogin.TabIndex = 14;
            lLogin.Text = "Логин";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.MintCream;
            btnLogin.Location = new Point(284, 281);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 56);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(732, 403);
            Controls.Add(btnLogin);
            Controls.Add(checkBox1);
            Controls.Add(lRegister);
            Controls.Add(llAuthorization);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(lPassword);
            Controls.Add(lLogin);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Регистрация";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label lRegister;
        private LinkLabel llAuthorization;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label lPassword;
        private Label lLogin;
        private Button btnLogin;
    }
}