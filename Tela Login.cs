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
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void BtnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            cozinha.Show();
            this.Hide();
        }

        private void btnTelaVendas_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
