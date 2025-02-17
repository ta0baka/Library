using Npgsql;
using System.Data;

namespace Library
{
    public partial class AdminForm : Form
    {
        DataBase database = new DataBase();
        int selectedRow;

        public AdminForm()
        {
            InitializeComponent();
            FillComboBox();
            dgvReports.SelectionChanged += dgvReports_SelectionChanged;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgvReports(dgvReports);
        }

        private void CreateColumns()
        {
            dgvReports.Columns.Add("id", "ID_Репорта");
            dgvReports.Columns.Add("id_status", "ID_Статуса");
            dgvReports.Columns.Add("login", "Логин пользователя");
            dgvReports.Columns.Add("report", "Жалоба");
            dgvReports.Columns.Add("status", "Статус");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4));
        }

        private void RefreshDgvReports(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT ur.id, ur.id_status, ur.login, ur.report, s.status FROM user_reports ur join report_statuses s ON ur.id_status = s.id_status";
            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            database.openConnection();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void RemoveReport(string errorReport)
        {
            database.openConnection();
            string query = "DELETE FROM error_reports WHERE report = @report";
            using (NpgsqlCommand command = new NpgsqlCommand(query, database.getConnection()))
            {
                command.Parameters.AddWithValue("report", errorReport);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Жалоба успешно удалена.", "Успех", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Жалоба не найдена.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            database.closeConnection();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                var selectedRow = dgvReports.SelectedRows[0];

                string errorReport = selectedRow.Cells["report"].Value?.ToString();

                if (!string.IsNullOrEmpty(errorReport))
                {
                    RemoveReport(errorReport);
                    RefreshDgvReports(dgvReports);
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные жалобы.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите жалобу для удаления.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReports.Rows[selectedRow];
                tbReport.Text = row.Cells[4].Value.ToString();
                tbLogin.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void llRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void FillComboBox()
        {
            database.openConnection();
            string query = "SELECT id_status, status FROM report_statuses";
            NpgsqlCommand com = new NpgsqlCommand(query, database.getConnection());
            NpgsqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                cbStatus.Items.Add(read["status"]);
            }

            read.Close();
            database.closeConnection();
        }

        private void dgvReports_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvReports.SelectedRows[0];
                var status = selectedRow.Cells["status"].Value.ToString();

                if (cbStatus.Items.Contains(status))
                {
                    cbStatus.SelectedItem = status;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RefreshDgvReports(dgvReports);

            string feedback = tbFeedback.Text;
            string login = tbLogin.Text;
            string report = tbReport.Text;

            string selectedStatus = (string)cbStatus.SelectedItem;
            int idStatus = GetStatusId(selectedStatus);

            DataGridViewRow row = dgvReports.Rows[selectedRow];
            var idReport = Convert.ToInt32(row.Cells[0].Value.ToString());

            string updateQuery = "UPDATE user_reports SET id_status = @idStatus, feedback = @feedback WHERE id = @idReport";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, database.getConnection()))
            {
                database.openConnection();
                command.Parameters.AddWithValue("@idStatus", idStatus);
                command.Parameters.AddWithValue("@feedback", feedback);
                command.Parameters.AddWithValue("@idReport", idReport);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сохранено.", "Успех", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
                database.closeConnection();
                RefreshDgvReports(dgvReports);
            }
        }

        private int GetStatusId(string status)
        {
            int idStatus = -1;
            string query = "SELECT id_status FROM report_statuses WHERE status = @status";

            using (NpgsqlCommand com = new NpgsqlCommand(query, database.getConnection()))
            {
                com.Parameters.AddWithValue("@status", status);
                database.openConnection();
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    idStatus = Convert.ToInt32(result);
                }
                database.closeConnection();
            }

            return idStatus;
        }
    }
}