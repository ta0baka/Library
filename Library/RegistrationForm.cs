using Npgsql;

namespace Library
{
    public partial class RegistrationForm : Form
    {
        DataBase database = new DataBase();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbLogin.MaxLength = 20;
            tbPassword.MaxLength = 20;
            tbPassword.PasswordChar = '•';
            checkBox1.CheckedChanged += new EventHandler(checkBoxShowPassword_CheckedChanged);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            this.Close();
            authorizationForm.ShowDialog();
            this.Show();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;

            string querystring = $"INSERT INTO users(login, password) VALUES ('{login}', '{password}')";

            NpgsqlCommand command = new NpgsqlCommand(querystring, database.getConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListOfBooksForm frm3 = new ListOfBooksForm();
                this.Hide();
                frm3.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.closeConnection();
        }
    }
}