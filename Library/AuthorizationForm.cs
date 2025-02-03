using Npgsql;
using System.Data;

namespace Library
{
    public partial class AuthorizationForm : Form
    {
        DataBase database = new DataBase();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.MaxLength = 20;
            tbPassword.MaxLength = 20;
            tbPassword.PasswordChar = 'Х';
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
                tbPassword.PasswordChar = 'Х';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"SELECT login, password FROM users WHERE login = '{login}' AND password = '{password}'";

            NpgsqlCommand command = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                ListOfBooksForm listOfBooksForm = new ListOfBooksForm();
                this.Hide();
                listOfBooksForm.Show();
            }
            else
            {
                MessageBox.Show("ќшибка при авторизации", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}