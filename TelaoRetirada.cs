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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TelaoRetirada_Load(object sender, EventArgs e)
        {
            if (tipoUsuario== "Administrador")
            {
                btnVoltarMenu.Visible = true;
            }
            foreach (Pedido pedido in PersistenciaPedido.pedidosProntos)
            {
                listPedidosProntos.Items.Add($"ID: {pedido.Id} | Cliente: {pedido.NomeCliente} | Tipo: {pedido.TipoPedido}");
            }
            foreach (Pedido pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.IsChapa == true)
                {
                    listPedidosPreparo.Items.Add($"ID: {pedido.Id} | Cliente: {pedido.NomeCliente} | Tipo: {pedido.TipoPedido}");
                }
            }
            foreach (Pedido pedido in PersistenciaPedido.pedidosEntregues)
            {
                listPedidosEntregues.Items.Add($"ID: {pedido.Id} | Cliente:  {pedido.NomeCliente}  | Tipo: {pedido.TipoPedido}");
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
    }
}