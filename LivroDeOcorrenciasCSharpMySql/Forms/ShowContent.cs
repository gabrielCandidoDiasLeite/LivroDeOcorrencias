using LivroDeOcorrenciasCSharpMySql.Connections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    public partial class ShowContent : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        string queryToGetContent = string.Empty;
        public ShowContent()
        {
            InitializeComponent();
        }

        public void QueryToGetContent (string query)
        {
            queryToGetContent = query;
        }

        public void Content()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string position, firstName, date, shift, content, image1path, image2path, image3path, image4path;

                    MySqlCommand command = new MySqlCommand(queryToGetContent, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            position = reader["position"].ToString();
                            firstName = reader["firstName"].ToString();
                            date = reader["date"].ToString();
                            shift = reader["shift"].ToString();
                            content = reader["content"].ToString();
                            image1path = reader["image1path"].ToString();
                            image2path = reader["image2path"].ToString();
                            image3path = reader["image3path"].ToString();
                            image4path = reader["image4path"].ToString();

                            headerLabel.Text = $"{position} {firstName}, {date}, {shift}";
                            contentTextBox.Text = content;
                            image1pictureBox.ImageLocation = image1path;
                            image2pictureBox.ImageLocation = image2path;
                            image3pictureBox.ImageLocation = image3path;
                            image4pictureBox.ImageLocation = image4path;
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show($"DataBase Error:{sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
