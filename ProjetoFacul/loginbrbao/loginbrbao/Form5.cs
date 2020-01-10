using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace loginbrbao
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtBoxUsername.Text != string.Empty && textBoxCPF.Text != string.Empty && textBoxEndereco.Text != string.Empty && textBoxNomeCompleto.Text != string.Empty && textBoxSalario.Text != string.Empty && textBoxSenha.Text != string.Empty)
            {
                DataTable dat = new DataTable();
                string connStr = "server=localhost;user=root;database=tst;port=3306;password=root;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand validar = new MySqlCommand("select count(*) from usuario where nome_usuario = @nomeusu;", con);
                validar.Parameters.AddWithValue("@nomeusu", txtBoxUsername.Text);
                int qtdeRegistros = Convert.ToInt32(validar.ExecuteScalar());
                if (qtdeRegistros >= 1)
                {
                    MessageBox.Show("Usuário já cadastrado !");
                    con.Close();
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("insert into funcionario (nome_usuario,nome_completo,cpf,endereço,salario) values ('" + txtBoxUsername.Text + "','" + textBoxNomeCompleto.Text + "','" + textBoxCPF.Text + "','" + textBoxEndereco.Text + "'," + Convert.ToDouble(textBoxSalario.Text) + ");", con);
                    MySqlCommand cmd2 = new MySqlCommand("insert into usuario (nome_usuario,senha_usuario,tipo_usuario) values ('" + txtBoxUsername.Text + "','" + textBoxSenha.Text + "',0);", con);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Usuário cadastrado!");
                            con.Close();
                        }
                    }
                }
            }
            else { MessageBox.Show("algum campo está em branco!"); }
       }
    }
}
