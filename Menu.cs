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
    public partial class Menu : Form
    {
        private string tipoUsuario;
        public Menu(string tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTelaVendas_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(tipoUsuario);
            form1.Show();
            this.Hide();
        }

        private void BtnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha(tipoUsuario);
            cozinha.Show();
            this.Hide();
        }

        private void BtnBalcao_Click(object sender, EventArgs e)
        {
            Balcao balcao = new Balcao(tipoUsuario);
            balcao.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaoRetirada telaoRetirada = new TelaoRetirada(tipoUsuario);
            telaoRetirada.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque(tipoUsuario);
            estoque.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == "Cozinheiro")
            {
                new Cozinha(tipoUsuario).Show();
                this.Close();
            }
            else if (tipoUsuario == "Balcão")
            {
                new Balcao(tipoUsuario).Show();
                this.Close();
            }
            else if (tipoUsuario == "Cantineiro")
            {
                new Form1(tipoUsuario).Show();
                this.Close();
            }
            else if (tipoUsuario == "Telão")
            {
                new TelaoRetirada(tipoUsuario).Show();
                this.Close();
            }
            else { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltarLogin_Click(object sender, EventArgs e)
        {
            telaDeLogin login = new telaDeLogin();
            login.Show();
            this.Close();
        }
    }
}
