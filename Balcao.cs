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
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
            btnFinalizarPedido.Click += button1_Click;

        }

        private void listBoxPedidospraEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComanda.Items.Clear();
            if (listBoxPedidospraEntrega.SelectedItem is Pedido pedidoSelecionado)
            {
                foreach (Produto prod in pedidoSelecionado.ProdutosPedido)
                {
                    listBoxComanda.Items.Add($"ID: {prod.Id} - {prod.Nome}- Quantidade: {prod.Quantidade}");
                }
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.IsChapa == false)
                {
                    listBoxPedidospraEntrega.Items.Add(pedido);
                }
            }
            foreach (Pedido pedido in PersistenciaPedido.pedidosConcluidos)
            {
                listBoxPedidospraEntrega.Items.Add(pedido);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxPedidospraEntrega.SelectedItem is Pedido pedidoEscolhido)
            {
                pedidoEscolhido.Status = "Entregue";
                listBoxPedidosEntregues.Items.Add(pedidoEscolhido);
                PersistenciaPedido.pedidosConcluidos.Add(pedidoEscolhido);
                PersistenciaPedido.pedidos.Remove(pedidoEscolhido);
                listBoxPedidospraEntrega.Items.Remove(pedidoEscolhido);
                listBoxComanda.Items.Clear();
                MessageBox.Show("Pedido finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Selecione um pedido para finalizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void listBoxPedidospraEntrega_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void listBoxPedidosEntregues_DrawItem(object sender, DrawItemEventArgs e)
        {
        }
    }
}