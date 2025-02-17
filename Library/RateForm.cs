using Npgsql;

namespace Library
{
    public partial class RateForm : Form
    {

        DataBase database = new DataBase();
        private string userLogin;

        public RateForm(string login)
        {
            InitializeComponent();
            userLogin = login;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            int rating = (int)numericUpDown1.Value;

            string checkQuery = "SELECT COUNT(*) FROM user_ratings WHERE login = @login";

            using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkQuery, database.getConnection()))
            {
                database.openConnection();
                checkCommand.Parameters.AddWithValue("login", userLogin);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Вы уже отправили оценку. Вы не можете отправить оценку повторно.");
                    return;
                }
            }

            string insertQuery = "INSERT INTO user_ratings (login, rating) VALUES (@login, @rating)";

            using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, database.getConnection()))
            {
                insertCommand.Parameters.AddWithValue("login", userLogin);
                insertCommand.Parameters.AddWithValue("rating", rating);
                insertCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Спасибо за оценку!");
            this.Close();
        }
    }
}