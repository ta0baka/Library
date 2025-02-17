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
            int userId;
            var userLogin = tbLogin.Text;
            var password = tbPassword.Text;
            database.openConnection();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $@"SELECT id, role FROM users WHERE login ='{userLogin}' and password = '{password}'";
            NpgsqlCommand command = new NpgsqlCommand(querystring, database.getConnection());
            command.Parameters.AddWithValue("login", userLogin);
            command.Parameters.AddWithValue("password", password);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string role = table.Rows[0]["role"].ToString();
                userId = Convert.ToInt32(table.Rows[0]["id"]);
                switch (role)
                {
                    case "user":
                        ListOfBooksForm listOfBooksForm = new ListOfBooksForm(userLogin);
                        listOfBooksForm.Show();
                        this.Hide();
                        break;
                    case "admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("ќшибка.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ќеверный логин или пароль.");
            }
            database.closeConnection();
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}