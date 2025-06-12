using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Semestral___Cantina
{
    public partial class telaDeLogin : Form
    {
        public telaDeLogin()
        {
            InitializeComponent();
            if (guna2TextBox2.Text != "Insira sua senha")
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
        }

        private void bypass_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu("Administrador");
            menu.Show();
            this.Hide();
        }
        private string caminhoLogins = PersistenciaPedido.caminhoLogins;
        private void telaDeLogin_Load(object sender, EventArgs e)
        {
            PersistenciaPedido.CarregarLogins(caminhoLogins);
            PersistenciaPedido.SalvarLogins(caminhoLogins);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Usuário")
            {
                guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else
            {
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Usuário")
            {
                guna2TextBox1.Text = "";
            }
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Insira sua senha")
            {
                guna2TextBox2.Text = "";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void verSenha_CheckedChanged(object sender, EventArgs e)
        {
                guna2TextBox2.UseSystemPasswordChar = !verSenha.Checked;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Insira sua senha")
            {
                guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149);
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.ForeColor = Color.Black;
                guna2TextBox2.UseSystemPasswordChar = !verSenha.Checked;
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Insira sua senha";
                guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149);
                guna2TextBox2.UseSystemPasswordChar = false;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "Usuário";
                guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = guna2TextBox1.Text;
            string senhaDigitada = guna2TextBox2.Text;

            Logins login = null;
            foreach (Logins u in PersistenciaPedido.usuarios)
            {
                if (u.Usuario == usuarioDigitado)
                {
                    login = u;
                    break;
                }
            }

            if (login != null && login.ValidarSenha(senhaDigitada))
            {

                Menu menu = new Menu(login.Tipo);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if(guna2TextBox2.Text =="Insira sua senha")
            {
                guna2TextBox2.Text = "";
            }
        }
    }
}
