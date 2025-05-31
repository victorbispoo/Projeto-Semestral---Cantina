using Guna.UI2.WinForms;

namespace Projeto_Semestral___Cantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CantCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CantCardapio.Items.Add(new Produto(1, "Pão de Queijo", 3.50, 0,false));
            CantCardapio.Items.Add(new Produto(2, "Coxinha", 5.00, 0,false));
            CantCardapio.Items.Add(new Produto(3, "Pastel de Carne", 6.00, 0, true));
            CantCardapio.Items.Add(new Produto(4, "Pastel de  Queijo", 5.50, 0, true));
            CantCardapio.Items.Add(new Produto(5, "Suco Natural", 4.00, 0, false));
            CantCardapio.Items.Add(new Produto(6, "Refrigerante Lata", 4.50, 0, false));
            CantCardapio.Items.Add(new Produto(7, "Hamburguer Simples", 8.00, 0, true));
            CantCardapio.Items.Add(new Produto(8, "Hamburguer com Queijo", 9.00, 0,true));
            CantCardapio.Items.Add(new Produto(9, "X-Tudo", 12.00, 0,true));
            CantCardapio.Items.Add(new Produto(10, "Água Mineral", 2.50, 0, false));
            int idProduto= CantCardapio.Items.Count+ 1;
        }
        public double total { get; private set; } = 0;
        private void CantBtnAdd_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            if (CantCardapio.SelectedItem is Produto produtoSelecionado)
            {
                foreach (Produto item in CantCarrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade++;
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
                }
                total = 0;
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
                if (produtoSelecionado.Quantidade > 1)
                {
                    produtoSelecionado.Quantidade--;
                    int index = CantCarrinho.Items.IndexOf(produtoSelecionado);
                    CantCarrinho.Items.RemoveAt(index);
                    CantCarrinho.Items.Insert(index, produtoSelecionado);
                    total -= produtoSelecionado.Preco;
                }
                else
                {
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
                        mensagem += $"{produto.Nome} - R${produto.Preco:F2} - Qtd {produto.Quantidade}\n";
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
                    CtnLblTotal.Text = "R$0,00";
                }
                else
                {
                    
                    MessageBox.Show("Operação cancelada!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void CantLimparCarrinho_Click(object sender, EventArgs e)
        {
            if (CantCarrinho.Items.Count == 0)
            {
                MessageBox.Show("O carrinho já está vazio!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CantCarrinho.Items.Clear();
            CantCarrinho.ClearSelected();
            total = 0;
            CtnLblTotal.Text = "R$" + total.ToString("F2");
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}