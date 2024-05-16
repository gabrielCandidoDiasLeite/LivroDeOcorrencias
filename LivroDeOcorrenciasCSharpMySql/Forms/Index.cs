using LivroDeOcorrenciasCSharpMySql.Connections;
using LivroDeOcorrenciasCSharpMySql.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace LivroDeOcorrenciasCSharpMySql
{
    public partial class Index : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        Menu menu = new Menu();
        public Index()
        {
            InitializeComponent();
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

                if (email == "" || password == "")
                {
                    MessageBox.Show("Você tem que preencher todos os campos para acessar o sistema.");
                    return;
                }

                string query = $"SELECT firstName, position FROM users WHERE email = '{email}' AND password = '{password}';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário e senha não encontrados! Tente novamente!");
                    return;
                }
                else
                {
                    this.Hide();
                    email = "";
                    password = "";
                    menu.ShowDialog();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
