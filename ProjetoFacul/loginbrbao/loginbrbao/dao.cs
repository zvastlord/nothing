using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace loginbrbao
{
    class dao
    {
        Conexao con = new Conexao();
        public bool Autenticar(Usuario user,ref int tipo_usuario)
        {
            Usuario usuario = new Usuario();
            usuario.nome_usuario = user.nome_usuario;
            usuario.senha = user.senha;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "select * from usuario where nome_usuario = @nome and senha_usuario = @senha";
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nome", usuario.nome_usuario);
            cmd.Parameters.AddWithValue("@senha", usuario.senha);
            cmd.Connection = con.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user.tipo_usuario = Convert.ToInt32(dr["tipo_usuario"]);
                tipo_usuario = user.tipo_usuario;
                con.Fechar();
                return true;
            }
            else
            {
                con.Fechar();
                return false;
            }
        }


        public int TipoUsuario(Usuario user)
        {
            int tipo;
            tipo = user.tipo_usuario;
            return tipo;
        }
    }
}
