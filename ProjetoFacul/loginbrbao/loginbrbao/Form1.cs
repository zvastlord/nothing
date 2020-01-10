using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loginbrbao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nomeusu { get; set; }

        public void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            dao userdao = new dao();
            int tipo_usuario = 0;
            user.nome_usuario = txtUsuario.Text;
            nomeusu = txtUsuario.Text;
            user.senha = txtSenha.Text;
            if (user.nome_usuario != string.Empty && user.senha != string.Empty)
            {
                if (userdao.Autenticar(user, ref tipo_usuario))
                {
                    user.tipo_usuario = tipo_usuario;
                    MessageBox.Show("Logado com sucesso!\nBem-vindo, " + user.nome_usuario);
                    if (tipo_usuario == 1) // admin = 1 | normal = resto
                    {
                        Form3 adminform = new Form3(user);
                        this.Hide();
                        adminform.ShowDialog();
                    }

                    else
                    {
                        Form2 form = new Form2(user);
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!!");
                }
            }
            else
            {
                MessageBox.Show("Algum campo está vazio!");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
