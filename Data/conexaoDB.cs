using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static internal class conexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            string stringconexao = "Server=localhost;Database= dbAgenda;User ID=root;Password=root;";

            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;



        }
    }
}
