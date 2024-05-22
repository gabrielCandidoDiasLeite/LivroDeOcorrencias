using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroDeOcorrenciasCSharpMySql.Connections
{
    public class ConnectionInfo
    {
        public string MySqlConnectionString()
        {
            string datasource = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "";
            string database = "livrodeocorrencias";

            return new string($"datasource={datasource};port={port};username={username};password={password};database={database};");
        }
    }
}