using Npgsql;

namespace Library
{
    public partial class ErrorReportForm : Form
    {
        DataBase database = new DataBase();
        private string userLogin;

        public ErrorReportForm(string login)
        {
            InitializeComponent();
            userLogin = login;
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            string report = tbReport.Text;

            string querystring = "INSERT INTO user_reports (login, report, id_status, status, feedback) VALUES (@login, @report, 1, 'Не выполнено', 'Ответа нет')";

            using (NpgsqlCommand command = new NpgsqlCommand(querystring, database.getConnection()))
            {
                database.openConnection();
                command.Parameters.AddWithValue("login", userLogin);
                command.Parameters.AddWithValue("report", report);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Спасибо за отчет об ошибке!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ArchiveReportForm archiveReportForm = new ArchiveReportForm();
            archiveReportForm.Show();
        }
    }
}