using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace loginbrbao
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=tst;port=3306;password=root;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from funcionario where nome_usuario = '"+textBox1.Text+"';", con);
            MySqlCommand cmd2 = new MySqlCommand("delete from usuario where nome_usuario = '" + textBox1.Text + "';", con);
            MySqlCommand cmd3 = new MySqlCommand("select * from usuario where nome_usuario = '" + textBox1.Text + "';", con);
            DataTable dat = new DataTable();
            MySqlDataReader reader = cmd3.ExecuteReader();
            dat.Load(reader);
            if (dat.Rows.Count > 0)
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Usuário deletado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("usuario não encontrado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            DataTable dt = new DataTable();
            string connStr = "server=localhost;user=root;database=tst;port=3306;password=root;";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from funcionario where nome_usuario = '"+textBox1.Text+"';", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else { MessageBox.Show("Sem dados na tabela de funcionarios"); }
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
