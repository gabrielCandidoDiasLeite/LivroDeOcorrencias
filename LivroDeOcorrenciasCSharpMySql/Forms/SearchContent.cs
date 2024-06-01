using LivroDeOcorrenciasCSharpMySql.Connections;
using LivroDeOcorrenciasCSharpMySql.Infos;
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
    public partial class SearchContent : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        Essential essential = new Essential();
        public SearchContent()
        {
            InitializeComponent();
        }

        private void getDateButton_Click(object sender, EventArgs e)
        {
            DateFillDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUsersPosition();
        }
        private void getPositionButton_Click(object sender, EventArgs e)
        {
            PositionFillDataGridView();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GetUsersFirstName();
        }
        private void getFirstNameButton_Click(object sender, EventArgs e)
        {
            FirstNameFillDataGridView();
        }
        private void shiftsButton_Click(object sender, EventArgs e)
        {
            GetUsersShift();
        }
        private void getShiftButton_Click(object sender, EventArgs e)
        {
            ShiftFillDataGridView();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DetailedFillDataGridView();
        }
        public void ClearDataTable()
        {
            dataGridView1.Rows.Clear();
        }
        public void GetUsersPosition()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT position FROM users";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    positionComboBox.Items.Clear();
                    while (reader.Read())
                    {
                        positionComboBox.Items.Add(reader["position"]);
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
        public void GetUsersFirstName()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT firstName FROM users";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    firstNameComboBox.Items.Clear();
                    while (reader.Read())
                    {
                        firstNameComboBox.Items.Add(reader["firstName"]);
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
        public void GetUsersShift()
        {
            shiftComboBox.Items.Clear();
            for (int i = 0; i < essential.allShifts.Length; i++)
            {
                shiftComboBox.Items.Add(essential.allShifts[i]);
            }
        }
        void DateFillDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string date = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                    dateTextBox.Text = date;

                    string query = $"SELECT position, firstName, date, shift FROM daily WHERE date = '{date}'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    ClearDataTable();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["date"], reader["position"], reader["firstName"], reader["shift"]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Nenhum resultado encontrado nesta data!");
                        return;
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
        void PositionFillDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string position = positionComboBox.Text;
                    positionTextBox.Text = position;

                    string query = $"SELECT position, firstName, date, shift FROM daily WHERE position = '{position}'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    ClearDataTable();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["date"], reader["position"], reader["firstName"], reader["shift"]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Nenhum resultado encontrado com este cargo!");
                        return;
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
        void FirstNameFillDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string firstName = firstNameComboBox.Text;
                    firstNameTextBox.Text = firstName;

                    string query = $"SELECT position, firstName, date, shift FROM daily WHERE firstName = '{firstName}'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    ClearDataTable();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["date"], reader["position"], reader["firstName"], reader["shift"]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Nenhum resultado encontrado com este nome!");
                        return;
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
        void ShiftFillDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string shift = shiftComboBox.Text;
                    shiftTextBox.Text = shift;

                    string query = $"SELECT position, firstName, date, shift FROM daily WHERE shift = '{shift}'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    ClearDataTable();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["date"], reader["position"], reader["firstName"], reader["shift"]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Nenhum resultado encontrado com este turno!");
                        return;
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
        void DetailedFillDataGridView()
        {
            string date = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string position = positionComboBox.Text;
            string firstName = firstNameComboBox.Text;
            string shift = shiftComboBox.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query =
                        $"SELECT position, firstName, date, shift FROM daily WHERE position = '{position}' AND firstName = '{firstName}' AND date = '{date}' AND shift = '{shift}'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    ClearDataTable();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["date"], reader["position"], reader["firstName"], reader["shift"]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Nenhum resultado encontrado!");
                        return;
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
