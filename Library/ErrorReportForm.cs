using System.Net.Mail;
using System.Net;

namespace Library
{
    public partial class ErrorReportForm : Form
    {
        public ErrorReportForm()
        {

            InitializeComponent();
            lError.Visible = false;
            tbReport.Visible = false;
            btnSendReport.Visible = false;
            tbPassword.PasswordChar = '•';
            chbPassword.CheckedChanged += new EventHandler(checkBoxShowPassword_CheckedChanged);
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            string reportText = tbReport.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(reportText))
            {
                MessageBox.Show("Пожалуйста, введите текст отчета об ошибке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите адрес электронной почты и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.mail.ru")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(email),
                    Subject = "Отчет об ошибке",
                    Body = reportText,
                    IsBodyHtml = false,
                };

                mailMessage.To.Add("novikova29292828@gmail.com");

                smtpClient.Send(mailMessage);
                MessageBox.Show("Отчет успешно отправлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lText.Visible = false;
            lLogin.Visible = false;
            lPassword.Visible = false;
            tbEmail.Visible = false;
            tbPassword.Visible = false;
            btnLogin.Visible = false;

            lError.Visible = true;
            tbReport.Visible = true;
            btnSendReport.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}