using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace loginbrbao
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string titulo_form;
        public Form3(Usuario user)
        {
            Usuario usuario = new Usuario();
            usuario = user;
            titulo_form = "SGP | Admin: " + user.nome_usuario;
            this.Text = titulo_form;
            InitializeComponent();
            loadDataGrid();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            customdata();
        }

        private void customdata()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            labeldata.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 telalogin = new Form1();
            this.Hide();
            telalogin.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
        }

        private void loadDataGrid()
    {
        DataTable dt = new DataTable();
        string connStr = "server=localhost;user=root;database=tst;port=3306;password=root;";
        using (MySqlConnection cn = new MySqlConnection(connStr))
        {
            MySqlCommand cmd = new MySqlCommand("select * from funcionario", cn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }
}
}
