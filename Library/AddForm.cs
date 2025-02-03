using Npgsql;

namespace Library
{
    public partial class AddForm : Form
    {
        DataBase database = new DataBase();

        public AddForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Номер капсулы должен быть целым числом.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            AddNewBook(tbTitle.Text, tbAuthor.Text, year);
        }

        private void AddNewBook(string title, string author, int year)
        {
            database.openConnection();
            string query = "INSERT INTO books (title, author, year) VALUES (@title, @author, @year)";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            ListOfBooksForm listOfBooksForm = new ListOfBooksForm();
            listOfBooksForm.Show();
            this.Hide();
        }
    }
}