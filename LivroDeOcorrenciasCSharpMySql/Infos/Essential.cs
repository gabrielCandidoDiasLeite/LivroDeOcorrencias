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
        public string userLevelAdm = "Administrador";
        public string[] allShifts = ["diurno", "noturno"];
        ConnectionInfo connectionInfo = new ConnectionInfo();
        public void SaveLoginInfoToUse(string userFirstName, string userPosition, string userLevel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query = $"INSERT INTO essential (firstName, position, userLevel) VALUES (@FirstName, @Position, @UserLevel)";
                    if (string.IsNullOrEmpty(userFirstName) || string.IsNullOrEmpty(userPosition) || string.IsNullOrEmpty(userLevel))
                    {
                        return;
                    }
                    else
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@FirstName", userFirstName);
                        command.Parameters.AddWithValue("@Position", userPosition);
                        command.Parameters.AddWithValue("@UserLevel", userLevel);

                        command.ExecuteNonQuery();
                    }
                }
                catch(MySqlException sqlEx)
                {
                    MessageBox.Show($"DataBase Error: {sqlEx.Message})");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message})");
                    return;
                }
            }
        }
        public void DeleteInfo()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString());

            string query = $"DELETE FROM essential";

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

        public string GetDateToUse()
        {
            string dateNow = DateTime.Now.ToString("dd/MM/yyyy");
            return $"{dateNow}";
        }

        public string GetShiftToUse()
        {
            DateTime now = DateTime.Now;

            TimeSpan startDayTime = new TimeSpan(6, 0, 0);
            TimeSpan endDayTime = new TimeSpan(18, 0, 0);

            TimeSpan currentTime = now.TimeOfDay;

            string shift = string.Empty;

            if(currentTime >= startDayTime && currentTime < endDayTime)
            {
                shift = allShifts[0];
            }
            else
            {
                shift = allShifts[1];
            }
            return $"{shift}";
        }
    }
}
