using LivroDeOcorrenciasCSharpMySql.Connections;
using LivroDeOcorrenciasCSharpMySql.Infos;
using LivroDeOcorrenciasCSharpMySql.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;

namespace LivroDeOcorrenciasCSharpMySql
{
    public partial class Index : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        Essential essential = new Essential();
        Menu menu = new Menu();

        public string userPosition = "";
        public string userFirstName = "";
        public Index()
        {
            InitializeComponent();

            menu.FormClosed += Form_FormClosed;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {

        }

        void Login()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString());

            try
            {
                connection.Open();

                string email = emailTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Você tem que preencher todos os campos para acessar o sistema.");
                    return;
                }

                string query = $"SELECT firstName, position FROM users WHERE email = @Email AND password = @Password;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        userFirstName = reader["firstName"].ToString();
                        userPosition = reader["position"].ToString();

                        essential.SaveLoginInfoToUse(userFirstName, userPosition);
                    }

                    this.Hide();
                    emailTextBox.Text = "";
                    passwordTextBox.Text = "";
                    menu.WelcomeLabel();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário e senha não encontrados! Tente novamente!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
