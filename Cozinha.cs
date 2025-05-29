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
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();

        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.IsChapa == true)
                {
                    listBoxPedidos.Items.Add(pedido);
                }
            }
        }
        private void listBoxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComanda.Items.Clear();
            if (listBoxPedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                foreach (Produto prod in pedidoSelecionado.ProdutosPedido.Where(vaipara => vaipara.IsChapa))
                {
                    listBoxComanda.Items.Add($"ID: {prod.Id} - {prod.Nome}- Quantidade: {prod.Quantidade}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                if(pedidoSelecionado.Status == "Pendente")
                {
                    MessageBox.Show("Não é possível finalizar um pedido que ainda está em preparo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pedidoSelecionado.Status = "Pronto";
                listPedidosProntos.Items.Add(pedidoSelecionado);
                PersistenciaPedido.pedidosConcluidos.Add(pedidoSelecionado);
                PersistenciaPedido.pedidos.Remove(pedidoSelecionado);
                listBoxPedidos.Items.Remove(pedidoSelecionado);
                listBoxComanda.Items.Clear();
                MessageBox.Show("Pedido finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Selecione um pedido para finalizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPreparar_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido para preparar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBoxPedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "Em preparo";
                int idx = listBoxPedidos.SelectedIndex;
                listBoxPedidos.Items[idx] = pedidoSelecionado;

                MessageBox.Show("Pedido em preparo!", "Preparando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxComanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja cancelar este pedido?", "Cancelar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (pedidoSelecionado.Status == "Em preparo")
                    {
                        MessageBox.Show("Não é possível cancelar um pedido em preparo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PersistenciaPedido.pedidos.Remove(pedidoSelecionado);
                        listBoxPedidos.Items.Remove(pedidoSelecionado);
                        listBoxComanda.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}