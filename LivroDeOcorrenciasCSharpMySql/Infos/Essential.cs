using LivroDeOcorrenciasCSharpMySql.Connections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroDeOcorrenciasCSharpMySql.Infos
{
    public class Essential
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();

        //public string savedUserFirstName, savedUserPosition;
        public void SaveLoginInfoToUse(string userFirstName, string userPosition)
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString());

            string query = $"INSERT INTO essential (firstName, position) VALUES ('{userFirstName}', '{userPosition}')";

            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(userFirstName) || string.IsNullOrEmpty(userPosition))
                {
                    return;
                }
                else
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60;

                    MySqlDataReader reader = command.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message})");
                return;
            }
        }
        public void DeleteInfo()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString());

            string query = $"DELETE FROM essential"; //WHERE firstName = {_userFirstName}";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(@query, connection);
                command.CommandTimeout = 60;

                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }
        public string LoadInfoToUse()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString());

            string firstName = "";
            string position = "";

            try
            {
                connection.Open();

                string query = $"SELECT firstName, position FROM essential";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        firstName = reader["firstName"].ToString();
                        position = reader["position"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return $"{position} {firstName}";
        }
    }
}
