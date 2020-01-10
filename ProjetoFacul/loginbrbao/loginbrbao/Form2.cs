using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace loginbrbao
{
    public partial class Form2 : Form
    {
        public bool marcado = false;
        string titulo_form;

         public Form2(Usuario user)
        {
            Usuario usuario = new Usuario();
            usuario = user;
            titulo_form = "SGP | Usuário: " + user.nome_usuario;
            this.Text = titulo_form;
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimeCustom();
        }

        private void dateTimeCustom()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            lbldatahora.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (marcado)
            {
                Usuario usuario = new Usuario();
                usuario.nome_usuario = Form1.nomeusu;
                Conexao con = new Conexao();
                DataTable dat = new DataTable();
                string nomeusu = usuario.nome_usuario;
                                string horaagora = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                                string pfinal = horaagora;
                                string dt = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                string updateQuery = "UPDATE ponto SET ponto_final = '"+pfinal+"' WHERE nome_usuario = '"+nomeusu+"' AND pontodata = '"+dt+"';";
                MySqlConnection connStr = new MySqlConnection("server=localhost;user=root;database=tst;port=3306;password=root;");
                connStr.Open();
                string consultaQuery = "SELECT ponto_final FROM ponto WHERE pontodata = '"+dt+"' AND nome_usuario = '"+usuario.nome_usuario+"' AND ponto_final IS NOT NULL;";
                MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(consultaQuery, connStr);
                MySqlDataReader reader = command.ExecuteReader();
                dat.Load(reader);
                if (dat.Rows.Count > 0)
                {
                    MessageBox.Show("Ponto já cadastrado hoje!");
                    marcado = false;
                }
                else
                {
                    MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(updateQuery, connStr);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Horario de Saída Marcado com Sucesso!");
                        marcado = false;
                        connStr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não foi marcado :(");
                        connStr.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não marcou horario de entrada!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            this.Hide();
            telalogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!marcado)
            {
                Usuario usuario = new Usuario();
                usuario.nome_usuario = Form1.nomeusu;
                Conexao con = new Conexao();
                DataTable dat = new DataTable();
                string nomeusu = usuario.nome_usuario;
                string horaagora = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                string pinicio = horaagora;
                string dt = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                string insertQuery = "INSERT INTO tst.ponto(nome_usuario, ponto_inicio, pontodata) values ('"+nomeusu+"', '"+pinicio+"', '"+@dt+"')";
                MySqlConnection connStr = new MySqlConnection("server=localhost;user=root;database=tst;port=3306;password=root;");
                connStr.Open();
                string consultaQuery = "SELECT ponto_inicio FROM ponto WHERE pontodata = '"+dt+"' AND nome_usuario = '"+usuario.nome_usuario+"';";
                MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(consultaQuery, connStr);
                MySqlDataReader reader = command.ExecuteReader();
                dat.Load(reader);
                if (dat.Rows.Count > 0)
                {
                    MessageBox.Show("Ponto já cadastrado hoje!");
                    marcado = true;
                } else {
                
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertQuery, connStr);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Horario de Entrada Marcado com Sucesso!");
                    marcado = true;
                    connStr.Close();
                }
                else { MessageBox.Show("Não foi marcado :(");
                connStr.Close();
                }
            }
            }
            else
            {
                MessageBox.Show("Você já marcou o horario de entrada!");
            } 
            }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 telalogin = new Form1();
            this.Hide();
            telalogin.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string connStr = "server=localhost;user=root;database=tst;port=3306;password=root;";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from ponto where nome_usuario = '"+Form1.nomeusu+"';", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else { MessageBox.Show("Sem dados"); }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
