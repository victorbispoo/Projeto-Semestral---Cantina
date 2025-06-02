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
        }

        private void listBoxPedidospraEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComanda.Items.Clear();
            if (listBoxPedidospraEntrega.SelectedItem is Pedido pedidoSelecionado)
            {
                foreach (Produto prod in pedidoSelecionado.ProdutosPedido)
                {
                    listBoxComanda.Items.Add($"ID: {prod.Id} | {prod.Nome} | Quantidade: {prod.Quantidade}");
                }
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listBoxPedidospraEntrega.Items.Clear();
            foreach (Pedido pedido in PersistenciaPedido.pedidosProntos)
            {
                listBoxPedidospraEntrega.Items.Add(pedido);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxPedidospraEntrega.SelectedItem is Pedido pedidoEscolhido)
            {
                pedidoEscolhido.Status = "Entregue";

                PersistenciaPedido.pedidosEntregues.Add(pedidoEscolhido);
                PersistenciaPedido.pedidosProntos.Remove(pedidoEscolhido);

                listBoxPedidospraEntrega.Items.Remove(pedidoEscolhido);
                listBoxPedidosEntregues.Items.Add(pedidoEscolhido);

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
            {
                if (e.Index < 0 || listBoxPedidospraEntrega.Items.Count == 0) return;

                e.DrawBackground();
                string itemText = listBoxPedidospraEntrega.Items[e.Index].ToString();
                string status = "";
                Color statusColor = Color.Black;

                // Identifica o status e define a cor
                if (itemText.Contains("Pendente"))
                {
                    status = "Pendente";
                    statusColor = Color.OrangeRed;
                }
                else if (itemText.Contains("Em preparo"))
                {
                    status = "Em preparo";
                    statusColor = Color.Yellow;
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
                    e.DrawFocusRectangle();
                    return;
                }

                // Divide o texto: antes, status, depois
                int statusIndex = itemText.IndexOf(status);
                string beforeStatus = statusIndex > 0 ? itemText.Substring(0, statusIndex) : "";
                string afterStatus = statusIndex + status.Length < itemText.Length ? itemText.Substring(statusIndex + status.Length) : "";

                // Desenha cada parte
                float x = e.Bounds.X;
                float y = e.Bounds.Y;
                using (Brush blackBrush = new SolidBrush(Color.Black))
                using (Brush statusBrush = new SolidBrush(statusColor))
                {
                    // Parte antes do status
                    if (!string.IsNullOrEmpty(beforeStatus))
                    {
                        e.Graphics.DrawString(beforeStatus, e.Font, blackBrush, x, y);
                        x += e.Graphics.MeasureString(beforeStatus, e.Font).Width;
                    }

                    // Status colorido
                    e.Graphics.DrawString(status, e.Font, statusBrush, x, y);
                    x += e.Graphics.MeasureString(status, e.Font).Width;

                    // Parte depois do status
                    if (!string.IsNullOrEmpty(afterStatus))
                    {
                        e.Graphics.DrawString(afterStatus, e.Font, blackBrush, x, y);
                    }
                }

                e.DrawFocusRectangle();

            }

        }
       

        private void listBoxPedidosEntregues_DrawItem(object sender, DrawItemEventArgs e)
        {
            {
                if (e.Index < 0 || listBoxPedidosEntregues.Items.Count == 0) return;

                e.DrawBackground();
                string itemText = listBoxPedidosEntregues.Items[e.Index].ToString();
                string status = "";
                Color statusColor = Color.Black;

                // Identifica o status e define a cor
                if (itemText.Contains("Pendente"))
                {
                    status = "Pendente";
                    statusColor = Color.Orange;
                }
                else if (itemText.Contains("Em preparo"))
                {
                    status = "Em preparo";
                    statusColor = Color.Yellow;
                }
                else if (itemText.Contains("Pronto"))
                {
                    status = "Pronto";
                    statusColor = Color.Green;
                }
                else if (itemText.Contains("Entregue"))
                {
                    status = "Entregue";
                    statusColor = Color.Blue;
                }

                // Se não houver status, desenha tudo em preto
                if (string.IsNullOrEmpty(status))
                {
                    using (Brush blackBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(itemText, e.Font, blackBrush, e.Bounds);
                    }
                    e.DrawFocusRectangle();
                    return;
                }

                // Divide o texto: antes, status, depois
                int statusIndex = itemText.IndexOf(status);
                string beforeStatus = statusIndex > 0 ? itemText.Substring(0, statusIndex) : "";
                string afterStatus = statusIndex + status.Length < itemText.Length ? itemText.Substring(statusIndex + status.Length) : "";

                // Desenha cada parte
                float x = e.Bounds.X;
                float y = e.Bounds.Y;
                using (Brush blackBrush = new SolidBrush(Color.Black))
                using (Brush statusBrush = new SolidBrush(statusColor))
                {
                    // Parte antes do status
                    if (!string.IsNullOrEmpty(beforeStatus))
                    {
                        e.Graphics.DrawString(beforeStatus, e.Font, blackBrush, x, y);
                        x += e.Graphics.MeasureString(beforeStatus, e.Font).Width;
                    }

                    // Status colorido
                    e.Graphics.DrawString(status, e.Font, statusBrush, x, y);
                    x += e.Graphics.MeasureString(status, e.Font).Width;

                    // Parte depois do status
                    if (!string.IsNullOrEmpty(afterStatus))
                    {
                        e.Graphics.DrawString(afterStatus, e.Font, blackBrush, x, y);
                    }
                }

                e.DrawFocusRectangle();

            }

        }
   

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}