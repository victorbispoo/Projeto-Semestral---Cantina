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
    public partial class Estoque : Form
    {
        private string tipoPedido;
        public Estoque(string tipo)
        {
            InitializeComponent();
            tipoPedido = tipo;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nomeProduto = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do produto:", "Adicionar Produto", "", -1, -1);
            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("O nome do produto não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            string idInput = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do produto:", "Adicionar Produto", "", -1, -1);
            if (!int.TryParse(idInput, out id) || id <= 0)
            {
                MessageBox.Show("O ID do produto não pode ser vazio ou 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PersistenciaPedido.produtosEstoque.Any(p => p.Id == id))
            {
                MessageBox.Show("Já existe um produto com este ID. Por favor, escolha outro ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double preco;
            string precoInput = Microsoft.VisualBasic.Interaction.InputBox("Digite o preço do produto:", "Adicionar Produto", "", -1, -1);
            if (!double.TryParse(precoInput, out preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantidade;
            string quantidadeInput = Microsoft.VisualBasic.Interaction.InputBox("Digite a quantidade do produto:", "Adicionar Produto", "", -1, -1);
            if (!int.TryParse(quantidadeInput, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isChapa = false;
            string isChapaInput = Microsoft.VisualBasic.Interaction.InputBox("O produto é da chapa? (Sim/Não)", "Adicionar Produto", "", -1, -1);
            if (isChapaInput.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                isChapa = true;
            }
            else if (!isChapaInput.Equals("Não", StringComparison.OrdinalIgnoreCase)||!isChapaInput.Equals("Nao", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Entrada inválida. Por favor, responda com 'Sim' ou 'Não'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto novoProduto = new Produto(id, nomeProduto, preco, quantidade, isChapa);
            PersistenciaPedido.produtosEstoque.Add(novoProduto);
            listProdutosEstoque.Items.Add(novoProduto);
            MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

            foreach (Produto produto in PersistenciaPedido.produtosEstoque)
            {
                listProdutosEstoque.Items.Add(produto);
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(tipoPedido);
            menu.Show();
            this.Hide();
        }

        private void listProdutosEstoque_DrawItem(object sender, DrawItemEventArgs e)
        {
            alterarFundodaLista(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listProdutosEstoque.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto para editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nomeProduto = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo nome do produto:", "Editar Produto", "", -1, -1);
            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("O nome do produto não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Produto produtoSelecionado = (Produto)listProdutosEstoque.SelectedItem;
            int id;
            string idInput = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo ID do produto:", "Editar Produto", produtoSelecionado.Id.ToString(), -1, -1);
            if (!int.TryParse(idInput, out id) || id <= 0)
            {
                MessageBox.Show("O ID do produto não pode ser vazio ou 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (PersistenciaPedido.produtosEstoque.Any(p => p.Id == id && p != produtoSelecionado))
            {
                MessageBox.Show("Já existe um produto com este ID. Por favor, escolha outro ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double preco;
            string precoInput = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo preço do produto:", "Editar Produto", produtoSelecionado.Preco.ToString("F2"), -1, -1);
            if (!double.TryParse(precoInput, out preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int quantidade;
            string quantidadeInput = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade do produto:", "Editar Produto", produtoSelecionado.Quantidade.ToString(), -1, -1);
            if (!int.TryParse(quantidadeInput, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool isChapa = false;
            string isChapaInput = Microsoft.VisualBasic.Interaction.InputBox("O produto é da chapa? (Sim/Não)", "Editar Produto", produtoSelecionado.IsChapa ? "Sim" : "Não", -1, -1);
            if (isChapaInput.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                isChapa = true;
            }
            else if (!isChapaInput.Equals("Não", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Entrada inválida. Por favor, responda com 'Sim' ou 'Não'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto produtoEditado = new Produto(id, nomeProduto, preco, quantidade, isChapa);
            if (produtoEditado != null)
            {
                PersistenciaPedido.produtosEstoque.Remove(produtoSelecionado);
                PersistenciaPedido.produtosEstoque.Add(produtoEditado);
                listProdutosEstoque.Items.Add(produtoEditado);
                listProdutosEstoque.Items.Remove(produtoSelecionado);
                MessageBox.Show("Produto editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao editar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listProdutosEstoque.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um produto para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Produto produtoSelecionado = (Produto)listProdutosEstoque.SelectedItem;
                DialogResult resultado = MessageBox.Show($"Você tem certeza que deseja remover o produto '{produtoSelecionado.Nome}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    PersistenciaPedido.produtosEstoque.Remove(produtoSelecionado);
                    listProdutosEstoque.Items.Remove(produtoSelecionado);
                    MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int quantidade;
            if (listProdutosEstoque.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um produto para alterar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Produto produtoSelecionado = (Produto)listProdutosEstoque.SelectedItem;
            string quantidadeInput = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade do produto:", "Alterar Quantidade", produtoSelecionado.Quantidade.ToString(), -1, -1);
            if (!int.TryParse(quantidadeInput, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            produtoSelecionado.Quantidade = quantidade;

            int idx = listProdutosEstoque.SelectedIndex;
            listProdutosEstoque.Items[idx] = produtoSelecionado;

            MessageBox.Show("Quantidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
