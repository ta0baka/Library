using Npgsql;

namespace Library
{
    public partial class AddForm : Form
    {
        DataBase database = new DataBase();
        private string userLogin;

        public AddForm(string login)
        {
            InitializeComponent();
            userLogin = login;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text) ||
             string.IsNullOrWhiteSpace(tbAuthor.Text) ||
             string.IsNullOrWhiteSpace(tbYear.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(tbYear.Text, out int year))
            {
                MessageBox.Show("Год должен быть целым числом.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            AddNewBook(tbTitle.Text, tbAuthor.Text, year);
        }

        private void AddNewBook(string title, string author, int year)
        {
            database.openConnection();
            string query = "INSERT INTO books (title, author, year, stop_page, id_b_status) VALUES (@title, @author, @year, 1, 2)";
            NpgsqlCommand command = new NpgsqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("title", title);
            command.Parameters.AddWithValue("author", author);
            command.Parameters.AddWithValue("year", year);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Книга успешно добавлена.", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            database.closeConnection();
        }

        private void LoadTest()
        {
            database.openConnection();
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    string title = $"Книга {i}";
                    string author = $"Автор {i}";
                    int year = 2000 + (i % 20);

                    string query = "INSERT INTO books (title, author, year) VALUES (@title, @author, @year)";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, database.getConnection()))
                    {
                        command.Parameters.AddWithValue("title", title);
                        command.Parameters.AddWithValue("author", author);
                        command.Parameters.AddWithValue("year", year);
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при добавлении книги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Нагрузочное тестирование завершено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении нагрузочного тестирования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ListOfBooksForm listOfBooksForm = new ListOfBooksForm(userLogin);
            listOfBooksForm.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Task.Run(() => LoadTest());
        }
    }
}