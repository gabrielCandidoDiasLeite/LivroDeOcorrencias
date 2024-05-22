using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivroDeOcorrenciasCSharpMySql.Connections;
using LivroDeOcorrenciasCSharpMySql.Infos;
using MySql.Data.MySqlClient;

namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    public partial class ConfirmAdminAddUser : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        AddUser addUser = new AddUser();
        Essential essential = new Essential();
        public ConfirmAdminAddUser()
        {
            InitializeComponent();

            addUser.FormClosed += Form_FormClosed;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            CheckAdmInfo();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void CheckAdmInfo()
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

                    string query = $"SELECT * FROM users WHERE email = '{email}' AND password = '{password}' AND userLevel = '{essential.userLevel}'";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Hide();
                        addUser.ShowDialog();
                        CleanTextBoxes();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Você não possui autorização como administrador!");
                        CleanTextBoxes();
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

        void CleanTextBoxes()
        {
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private bool ValidateUserInput(string email, string password)
        {
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Você tem que preencher todos os campos para acessar o sistema.");
                return false;
            }
            else if (!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Você tem que preencher a senha para acessar o sistema.");
                return false;
            }
            else if (string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Você tem que preencher o e-mail para acessar o sistema.");
                return false;
            }
            return true;
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
