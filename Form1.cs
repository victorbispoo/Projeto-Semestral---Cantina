using Guna.UI2.WinForms;
using MaterialSkin.Controls;

namespace Projeto_Semestral___Cantina
{
    public partial class Form1 : Form
    {
        private string tipoPedido;
        public Form1(string tipo)
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
        private void CantCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tipoPedido == "Administrador")
            {
                btnVoltarMenu.Visible = true;
            }
            else
            {
                btnVoltarMenu.Visible = false;
            }
            foreach (Produto produto in PersistenciaPedido.produtosEstoque)
            {
                CantCardapio.Items.Add(produto);
            }
        }
        public double total { get; private set; } = 0;
        private void CantBtnAdd_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            if (CantCardapio.SelectedItem is Produto produtoSelecionado)
            {
                if (produtoSelecionado.Quantidade <= 0)
                {
                    MessageBox.Show("Produto sem estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (Produto item in CantCarrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        if (produtoSelecionado.Quantidade <= 0)
                        {
                            MessageBox.Show("Produto sem estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        item.Quantidade++;
                        produtoSelecionado.Quantidade--;

                        encontrado = true;

                        int index = CantCarrinho.Items.IndexOf(item);
                        CantCarrinho.Items.RemoveAt(index);
                        CantCarrinho.Items.Insert(index, item);
                        break;
                    }
                }
                if (!encontrado)
                {
                    Produto novoItem = new Produto(produtoSelecionado.Id, produtoSelecionado.Nome, produtoSelecionado.Preco, 1, produtoSelecionado.IsChapa);
                    CantCarrinho.Items.Add(novoItem);
                    produtoSelecionado.Quantidade--;
                }
                if (produtoSelecionado.Quantidade >0 && produtoSelecionado.Quantidade<5 )
                {
                    MessageBox.Show("Estoque baixo para o produto: " + produtoSelecionado.Nome, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int idx = CantCardapio.SelectedIndex;
                CantCardapio.Items[idx] = produtoSelecionado;
                foreach (Produto item in CantCarrinho.Items)
                {
                    total += item.Preco * item.Quantidade;
                }
                CtnLblTotal.Text = "R$" + total.ToString("F2");
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar ao carrinho!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CtnLblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CantBtnRemov_Click(object sender, EventArgs e)
        {
            if (CantCarrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto para remover do carrinho!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CantCarrinho.SelectedItem is Produto produtoSelecionado)
            {
                Produto produtoEstoque = null;
                foreach (Produto p in CantCardapio.Items)
                {
                    if (p.Id == produtoSelecionado.Id)
                    {
                        produtoEstoque = p;
                        break;
                    }
                }
                if (produtoSelecionado.Quantidade > 1)
                {
                    produtoSelecionado.Quantidade--;
                    if (produtoEstoque != null)
                    {
                        produtoEstoque.Quantidade++;
                      
                        int idx = CantCardapio.Items.IndexOf(produtoEstoque);
                        CantCardapio.Items[idx] = produtoEstoque;
                    }
                    int index = CantCarrinho.Items.IndexOf(produtoSelecionado);
                    CantCarrinho.Items.RemoveAt(index);
                    CantCarrinho.Items.Insert(index, produtoSelecionado);
                    total -= produtoSelecionado.Preco;
                }
                else
                {
                    if (produtoEstoque != null)
                    {
                        produtoEstoque.Quantidade++;
                        int idx = CantCardapio.Items.IndexOf(produtoEstoque);
                        CantCardapio.Items[idx] = produtoEstoque;
                    }
                    CantCarrinho.Items.RemoveAt(CantCarrinho.SelectedIndex);
                    total -= produtoSelecionado.Preco;
                }
            }
            CtnLblTotal.Text = "R$" + total.ToString("F2");
        }

        private void CantBtnFin_Click(object sender, EventArgs e)
        {


            if (CantCarrinho.Items.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nomeCliente = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do usuário", "Cadastro", "Insira o nome do cliente");

                if (string.IsNullOrWhiteSpace(nomeCliente) || nomeCliente == "Insira o nome do cliente" || nomeCliente.Length > 15)
                {
                    MessageBox.Show("Operação cancelada ou nome inválido!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Concluindo_pedido concluindo_Pedido = new Concluindo_pedido(total);
                if (concluindo_Pedido.ShowDialog() == DialogResult.OK)
                {
                    double troco = concluindo_Pedido.Troco;
                    string tipodePedido = concluindo_Pedido.tipoPedido;
                    DateTime horarioPedido = concluindo_Pedido.HorarioPedido;

                    string mensagem = "Produtos:\n";
                    foreach (Produto produto in CantCarrinho.Items)
                    {
                        mensagem += $"{produto.Nome} | R${produto.Preco:F2} | Qtd {produto.Quantidade}\n";
                    }
                    
                    MessageBox.Show(
                        $"{horarioPedido}\nExtrato do pedido de {nomeCliente} - {tipodePedido}\n{mensagem}\nTotal: R${total:F2}\nTroco: R${troco:F2}",
                        "Extrato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    total = 0;
                    CtnLblTotal.Text = "R$0,00";


                    List<Produto> produtos = new List<Produto>();
                    foreach (Produto p in CantCarrinho.Items)
                    {
                        produtos.Add(new Produto(p.Id, p.Nome, p.Preco, p.Quantidade, p.IsChapa));
                    }

                    bool isChapa = produtos.Any(prod => prod.IsChapa);
                    string status = isChapa ? "Pendente" : "Pronto";


                    int novoId = PersistenciaPedido.pedidos
                        .Concat(PersistenciaPedido.pedidosProntos)
                        .Concat(PersistenciaPedido.pedidosEntregues)
                        .Select(p => p.Id)
                        .DefaultIfEmpty(0)
                        .Max() + 1;

                    Pedido pedido = new Pedido(novoId, nomeCliente, status, produtos, DateTime.Now, isChapa, tipodePedido);

                    if (!isChapa)
                    {
                        PersistenciaPedido.pedidosProntos.Add(pedido);
                    }
                    else
                    {
                        PersistenciaPedido.pedidos.Add(pedido);
                    }


                    CantCarrinho.Items.Clear();
                    CantCarrinho.ClearSelected();
                    PersistenciaPedido.produtosEstoque.Clear();
                    foreach(Produto produto in CantCardapio.Items)
                    {
                        Produto estoqueProduto = new Produto(produto.Id, produto.Nome, produto.Preco, produto.Quantidade, produto.IsChapa);
                        PersistenciaPedido.produtosEstoque.Add(estoqueProduto);
                    }
                }
                else
                {

                    MessageBox.Show("Operação cancelada!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void CantLimparCarrinho_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(tipoPedido);
            menu.Show();
            this.Hide();
        }

        private void CantCardapio_DrawItem(object sender, DrawItemEventArgs e)
        {
            alterarFundodaLista(sender, e);
        }

        private void CantCarrinho_DrawItem(object sender, DrawItemEventArgs e)
        {
            alterarFundodaLista(sender, e);
        }
    }
}