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
    public partial class TelaoRetirada : Form
    {
        private string tipoUsuario;
        public TelaoRetirada(string tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private string caminhoPedidos = PersistenciaPedido.caminhoPedidos;

        private void TelaoRetirada_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == "Administrador")
            {
                btnVoltarMenu.Visible = true;
                BtnVoltarLogin.Visible = false;
            }
            else
            {
                btnVoltarMenu.Visible = false;
                BtnVoltarLogin.Visible = true;
            }
                foreach (Pedido pedido in PersistenciaPedido.pedidosProntos.OrderBy(p => p.DataHora))
                {
                    listPedidosProntos.Items.Add($"ID: {pedido.Id} |  {pedido.NomeCliente}");
                }
            foreach (Pedido pedido in PersistenciaPedido.pedidos.OrderBy(p => p.DataHora))
            {
                if (pedido.IsChapa == true)
                {
                    listPedidosPreparo.Items.Add($"ID: {pedido.Id} |  {pedido.NomeCliente}");
                }
            }
            PersistenciaPedido.CarregarPedidosEntregues(caminhoPedidos);
            PersistenciaPedido.LimparPedidosEntreguesAntigos();
            var ultimos5 = PersistenciaPedido.pedidosEntregues
            .OrderByDescending(p => p.DataHora)
            .Take(5)
            .ToList();
            foreach (var pedido in ultimos5)
            {
                listPedidosEntregues.Items.Add($"ID: {pedido.Id} |  {pedido.NomeCliente}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Menu menu = new Menu(tipoUsuario);
            menu.Show();
            this.Hide();
        }

        private void listPedidosPreparo_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void listPedidosProntos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPedidosEntregues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPedidosEntregues_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void listPedidosProntos_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void BtnVoltarLogin_Click(object sender, EventArgs e)
        {
            telaDeLogin login = new telaDeLogin();
            login.Show();
            this.Hide();
        }
    }
}