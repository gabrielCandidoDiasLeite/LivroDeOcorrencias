using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivroDeOcorrenciasCSharpMySql.Connections;
using MySql.Data.MySqlClient;

namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    public partial class AddUser : Form
    {
        ConnectionInfo ConnectionInfo = new ConnectionInfo();
        public AddUser()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddNewUser()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string firstName = firstNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    string position = positionComboBox.Text;
                    string email = emailTextBox.Text;
                    string password = passwordTextBox.Text;
                    string checkPassword = checkPasswordTextBox.Text;
                    string userLevel = userLevelComboBox.Text;

                    if (!ValidateUserInput(firstName, lastName, position, email, password, checkPassword, userLevel))
                    {
                        return;
                    }

                    if (EmailAlreadyUsed(email, connection))
                    {
                        return;
                    }

                    string query = new string($"INSERT INTO users (firstName, lastName, position, email, password, userLevel) " +
                        $"VALUES (@FirstName, @LastName, @Position, @Email, @Password, @UserLevel)");

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue ("@FirstName", firstName);
                    command.Parameters.AddWithValue ("@LastName", lastName);
                    command.Parameters.AddWithValue ("@Position", position);
                    command.Parameters.AddWithValue ("@Email", email);
                    command.Parameters.AddWithValue ("@Password", password);
                    command.Parameters.AddWithValue("UserLevel", userLevel);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    Close();

                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show($"DataBase Error: {sqlEx.Message}");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    return;
                }
            }
        }

        private bool ValidateUserInput(string firstName, string lastName, string position, string email, string password, string checkPassword, string userLevel)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(position) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(checkPassword) || string.IsNullOrEmpty(userLevel))
            {
                MessageBox.Show("Você precisa preencher todos os campos para cadastrar um novo usuário!");
                return false;
            }

            if(password != checkPassword)
            {
                MessageBox.Show("As senhas não são iguais!");
                return false;
            }

            if(!IsValidPassword(password))
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres, incluindo um caractere maiúsculo, um caractere especial e um caractere numérico!");
                return false;
            }

            return true;
        }

        private bool EmailAlreadyUsed(string email, MySqlConnection connection)
        {
            string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
            MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection);
            checkEmailCommand.Parameters.AddWithValue("@Email", email);

            int emailExists = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

            if (emailExists > 0)
            {
                MessageBox.Show("E-mail já cadastrado! Cadastre um novo e-mail!");
                return true;
            }

            return false;
        }

        private bool IsValidPassword(string password)
        {
            var passwordPattern = new Regex(@"^(?=.*[A-Z])(?=.*[\W_])(?=.*[0-9]).{8,}$");
            return passwordPattern.IsMatch(password);
        }
    }
}
