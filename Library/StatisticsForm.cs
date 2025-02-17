using System.Data;
using Npgsql;

namespace Library
{
    public partial class StatisticsForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=Library;Username=postgres;Password=2928";

        public StatisticsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT login, rating FROM user_ratings";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvRating.DataSource = dataTable;

                            dgvRating.Columns[0].HeaderText = "Логин";
                            dgvRating.Columns[1].HeaderText = "Оценка";
                        }
                    }

                    string averageQuery = "SELECT ROUND(AVG(rating), 2) AS AverageRating FROM user_ratings";
                    using (var averageCommand = new NpgsqlCommand(averageQuery, connection))
                    {
                        using (var averageAdapter = new NpgsqlDataAdapter(averageCommand))
                        {
                            DataTable averageTable = new DataTable();
                            averageAdapter.Fill(averageTable);

                            dgvAverageRating.DataSource = averageTable;

                            dgvAverageRating.Columns[0].HeaderText = "Средняя оценка";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvRating.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этот отзыв?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string login = Convert.ToString(dgvRating.SelectedRows[0].Cells[0].Value);
                    DeleteRating(login);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите отзыв для удаления.");
            }
        }

        private void DeleteRating(string login)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM user_ratings WHERE login = @login";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message);
                }
            }
        }
    }
}