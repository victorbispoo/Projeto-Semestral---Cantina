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
        }

        private void bypass_Click(object sender, EventArgs e)
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

        private void telaDeLogin_Load(object sender, EventArgs e)
        {
            PersistenciaPedido.produtosEstoque.Add(new Produto(1, "Pão de Queijo", 3.50, 0, false));
            PersistenciaPedido.produtosEstoque.Add(new Produto(2, "Coxinha", 5.00, 0, false));
            PersistenciaPedido.produtosEstoque.Add(new Produto(3, "Pastel de Carne", 6.00, 0, true));
            PersistenciaPedido.produtosEstoque.Add(new Produto(4, "Pastel de  Queijo", 5.50, 0, true));
            PersistenciaPedido.produtosEstoque.Add(new Produto(5, "Suco Natural", 4.00, 0, false));
            PersistenciaPedido.produtosEstoque.Add(new Produto(6, "Refrigerante Lata", 4.50, 0, false));
            PersistenciaPedido.produtosEstoque.Add(new Produto(7, "Hamburguer Simples", 8.00, 0, true));
            PersistenciaPedido.produtosEstoque.Add(new Produto(8, "Hamburguer com Queijo", 9.00, 0, true));
            PersistenciaPedido.produtosEstoque.Add(new Produto(9, "X-Tudo", 12.00, 0, true));
            PersistenciaPedido.produtosEstoque.Add(new Produto(10, "Água Mineral", 2.50, 0, false));

            PersistenciaPedido.usuarios.Add(new Logins("admin", "BoltAdmin", "Administrador"));
            PersistenciaPedido.usuarios.Add(new Logins("cozinha", "BoltCozinha", "Cozinheiro"));
            PersistenciaPedido.usuarios.Add(new Logins("balcao", "BoltBalcao", "Balcão"));
            PersistenciaPedido.usuarios.Add(new Logins("cantina", "BoltCantina", "Cantineiro"));
            PersistenciaPedido.usuarios.Add(new Logins("telao", "BoltTelao", "Telão"));

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
            if (guna2TextBox2.Text == "Senha")
            {
                guna2TextBox2.Text = "";
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = !verSenha.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void verSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text=="Senha")
            {
                guna2TextBox2.UseSystemPasswordChar=false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = !verSenha.Checked;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Senha")
            {
                guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else
            {
                guna2TextBox2.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Senha";
                guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149);
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
    }
}
