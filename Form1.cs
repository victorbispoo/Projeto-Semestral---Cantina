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
            CantCardapio.Items.Add(new Produto(1,"Pão de Queijo",3.50));
            CantCardapio.Items.Add(new Produto(2, "Coxinha", 5.00));
            CantCardapio.Items.Add(new Produto(3, "Pastel de Carne", 6.00));
            CantCardapio.Items.Add(new Produto(4, "Pastel de  Queijo", 5.50));
            CantCardapio.Items.Add(new Produto(5, "Suco Natural", 4.00));
            CantCardapio.Items.Add(new Produto(6, "Refrigerante Lata", 4.50));
            CantCardapio.Items.Add(new Produto(7, "Hamburguer Simples", 8.00));
            CantCardapio.Items.Add(new Produto(8, "Hamburguer com Queijo", 9.00));
            CantCardapio.Items.Add(new Produto(9, "X-Tudo", 12.00));
            CantCardapio.Items.Add(new Produto(10, "Água Mineral",2.50));
        }
    }
}
