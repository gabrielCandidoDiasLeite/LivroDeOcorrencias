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
        ConfirmAdminAddUser ConfirmAdminAddUser = new ConfirmAdminAddUser();
        public Index()
        {
            InitializeComponent();

            menu.FormClosed += Form_FormClosed;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginButton();
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserButton();
        }

        void LoginButton()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string email = emailTextBox.Text;
                    string password = passwordTextBox.Text;

                    if (!ValidateUserInput(email, password))
                    {
                        return;
                    }

                    string query = $"SELECT firstName, position, userLevel FROM users WHERE email = @Email AND password = @Password;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string userFirstName = reader["firstName"].ToString();
                            string userPosition = reader["position"].ToString();
                            string userLevel = reader["userLevel"].ToString() ;

                            essential.SaveLoginInfoToUse(userFirstName, userPosition, userLevel);
                        }

                        Hide();
                        CleanTextBoxes();
                        menu.WelcomeLabel();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e senha não encontrados! Tente novamente!");
                        return;
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show($"DataBase Error: {sqlEx.Message}");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
            }
        }
        
        void AddUserButton()
        {
            ConfirmAdminAddUser.ShowDialog();
        }

        void CleanTextBoxes()
        {
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private bool ValidateUserInput(string email, string password)
        {
            if(string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password)){
                MessageBox.Show("Você tem que preencher todos os campos para acessar o sistema.");
                return false;
            }
            else if(!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Você tem que preencher a senha para acessar o sistema.");
                return false;
            }
            else if(string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Você tem que preencher o e-mail para acessar o sistema.");
                return false;
            }
            return true;
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            essential.DeleteInfo();
            Show();
        }
    }
}
