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
        public static void alterarFundodaLista(object sender, DrawItemEventArgs e)
        {
            {
                if (e.Index < 0 || ((ListBox)sender).Items.Count == 0) return;

                // Define o fundo: LightGray para seleção, fundo padrão para não selecionado
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(((ListBox)sender).BackColor), e.Bounds);
                }

                string itemText = ((ListBox)sender).Items[e.Index].ToString();
                string status = "";
                Color statusColor = Color.Black;

                // Identifica o status e define a cor
                if (itemText.Contains("Pendente"))
                {
                    status = "Pendente";
                    statusColor = Color.Purple;
                }
                else if (itemText.Contains("Em preparo"))
                {
                    status = "Em preparo";
                    statusColor = Color.Orange;
                }
                else if (itemText.Contains("Pronto"))
                {
                    status = "Pronto";
                    statusColor = Color.Green;
                }

                // Se não houver status, desenha tudo em preto
                if (string.IsNullOrEmpty(status))
                {
                    using (Brush blackBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(itemText, e.Font, blackBrush, e.Bounds);
                    }

                    return;
                }

                // Divide o texto: antes, status e depois
                int statusIndex = itemText.IndexOf(status);
                string beforeStatus = statusIndex > 0 ? itemText.Substring(0, statusIndex) : "";
                string afterStatus = statusIndex + status.Length < itemText.Length ? itemText.Substring(statusIndex + status.Length) : "";

                // Desenha cada parte
                float x = e.Bounds.X;
                float y = e.Bounds.Y;
                using (Brush blackBrush = new SolidBrush(Color.Black))
                using (Brush statusBrush = new SolidBrush(statusColor))
                {
                    if (!string.IsNullOrEmpty(beforeStatus))
                    {
                        e.Graphics.DrawString(beforeStatus, e.Font, blackBrush, x, y);
                        x += e.Graphics.MeasureString(beforeStatus, e.Font).Width;
                    }
                    e.Graphics.DrawString(status, e.Font, statusBrush, x, y);
                    x += e.Graphics.MeasureString(status, e.Font).Width;
                    if (!string.IsNullOrEmpty(afterStatus))
                    {
                        e.Graphics.DrawString(afterStatus, e.Font, blackBrush, x, y);
                    }
                }


            }
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
            foreach (Pedido pedido in PersistenciaPedido.pedidosProntos)
            {
                if (pedido.IsChapa == true)
                {
                    listPedidosProntos.Items.Add(pedido);
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
                    listBoxComanda.Items.Add($"ID: {prod.Id} | {prod.Nome} | Qtd: {prod.Quantidade}");
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
                pedidoSelecionado.Status = "Pronto";
                listPedidosProntos.Items.Add(pedidoSelecionado);
                PersistenciaPedido.pedidosProntos.Add(pedidoSelecionado);
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

        private void listBoxPedidos_DrawItem(object sender, DrawItemEventArgs e)
        {
            alterarFundodaLista(sender, e);

        }

     
        private void listPedidosProntos_DrawItem(object sender, DrawItemEventArgs e)
        {
            alterarFundodaLista(sender, e);
        }

    }

}