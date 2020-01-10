using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace loginbrbao
{
    class Conexao
    {
        private static string conexao = "server=localhost;user=root;database=tst;port=3306;password=root;";
        MySqlConnection con = new MySqlConnection(conexao);
        public MySqlConnection Conectar()
        { 
            con.Open();
            return con;
        }

        public MySqlConnection Fechar()
        {
            con.Close();
            return con;
        }
    }
}
