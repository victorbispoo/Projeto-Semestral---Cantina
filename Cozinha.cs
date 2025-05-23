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
            listBoxPedidos.Items.Clear();
            foreach (Pedido pedido in PersistenciaPedido.pedidos)
            {
                listBoxPedidos.Items.Add(pedido);
            }

        }
        private void listBoxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComanda.Items.Clear();
            if (listBoxPedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                // Corrija para acessar os produtos do pedido selecionado
                foreach (Produto prod in pedidoSelecionado.ProdutosPedido)
                {
                    listBoxComanda.Items.Add(prod);
                }
            }
        }
    }
    }