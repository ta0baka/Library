namespace Library
{
    partial class ErrorReportForm
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
            tbReport = new TextBox();
            btnSendReport = new Button();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            lLogin = new Label();
            lPassword = new Label();
            lText = new Label();
            btnLogin = new Button();
            lError = new Label();
            btnExit = new Button();
            chbPassword = new CheckBox();
            SuspendLayout();
            // 
            // tbReport
            // 
            tbReport.BackColor = Color.DarkSlateGray;
            tbReport.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbReport.ForeColor = Color.MintCream;
            tbReport.Location = new Point(46, 126);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(399, 175);
            tbReport.TabIndex = 0;
            // 
            // btnSendReport
            // 
            btnSendReport.FlatStyle = FlatStyle.Flat;
            btnSendReport.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSendReport.ForeColor = Color.MintCream;
            btnSendReport.Location = new Point(165, 326);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(163, 39);
            btnSendReport.TabIndex = 1;
            btnSendReport.Text = "Отправить";
            btnSendReport.UseVisualStyleBackColor = true;
            btnSendReport.Click += btnSendReport_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.DarkSlateGray;
            tbEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbEmail.ForeColor = Color.MintCream;
            tbEmail.Location = new Point(119, 126);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(362, 27);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.DarkSlateGray;
            tbPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.ForeColor = Color.MintCream;
            tbPassword.Location = new Point(119, 182);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(362, 27);
            tbPassword.TabIndex = 3;
            // 
            // lLogin
            // 
            lLogin.AutoSize = true;
            lLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lLogin.ForeColor = Color.MintCream;
            lLogin.Location = new Point(46, 130);
            lLogin.Name = "lLogin";
            lLogin.Size = new Size(67, 23);
            lLogin.TabIndex = 4;
            lLogin.Text = "Логин";
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lPassword.ForeColor = Color.MintCream;
            lPassword.Location = new Point(28, 185);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(85, 23);
            lPassword.TabIndex = 5;
            lPassword.Text = "Пароль";
            // 
            // lText
            // 
            lText.AutoSize = true;
            lText.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lText.ForeColor = Color.MintCream;
            lText.Location = new Point(67, 26);
            lText.Name = "lText";
            lText.Size = new Size(399, 80);
            lText.TabIndex = 6;
            lText.Text = "Войдите в свою почту\r\n для отправки отчета\r\n";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.MintCream;
            btnLogin.Location = new Point(181, 251);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 39);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lError
            // 
            lError.AutoSize = true;
            lError.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lError.ForeColor = Color.MintCream;
            lError.Location = new Point(36, 26);
            lError.Name = "lError";
            lError.Size = new Size(430, 80);
            lError.TabIndex = 8;
            lError.Text = "Опишите ошибку,\r\n с которой столкнулись";
            lError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(409, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chbPassword
            // 
            chbPassword.AutoSize = true;
            chbPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chbPassword.ForeColor = Color.MintCream;
            chbPassword.Location = new Point(119, 215);
            chbPassword.Name = "chbPassword";
            chbPassword.Size = new Size(177, 25);
            chbPassword.TabIndex = 10;
            chbPassword.Text = "Показать пароль";
            chbPassword.UseVisualStyleBackColor = true;
            // 
            // ErrorReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(515, 396);
            Controls.Add(chbPassword);
            Controls.Add(btnExit);
            Controls.Add(lError);
            Controls.Add(btnLogin);
            Controls.Add(lText);
            Controls.Add(lPassword);
            Controls.Add(lLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(btnSendReport);
            Controls.Add(tbReport);
            Name = "ErrorReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbReport;
        private Button btnSendReport;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label lLogin;
        private Label lPassword;
        private Label lText;
        private Button btnLogin;
        private Label lError;
        private Button btnExit;
        private CheckBox chbPassword;
    }
}