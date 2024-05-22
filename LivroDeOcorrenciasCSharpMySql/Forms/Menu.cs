using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivroDeOcorrenciasCSharpMySql.Infos;
using LivroDeOcorrenciasCSharpMySql.Connections;
using MySql.Data.MySqlClient;

namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    public partial class Menu : Form
    {
        Essential essential = new Essential();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            essential.DeleteInfo();
            Close();
        }

        public void WelcomeLabel()
        {
            label1.Text = $"Bem vindo {essential.LoadInfoToUse()}";
        }
    }
}
