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
    public partial class Concluindo_pedido : Form
    {
        public DateTime HorarioPedido { get; private set; }
        public string tipoPedido { get; private set; }
        public double Troco { get; private set; }
        private double totalPedido;
        public Concluindo_pedido(double total)
        {
            InitializeComponent();
            radioButton5.Checked = true;
            pagDebito.Checked = true;
            totalPedido = total;
        }

        private void Concluindo_pedido_Load(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
              tipoPedido = "Viagem";
            }
            else if (radioButton5.Checked)
            {
                tipoPedido = "Consumo";
            }
            else
            {
                MessageBox.Show("Selecione um tipo de pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (pagDinheiro.Checked)
            {
                string precoCliente = Microsoft.VisualBasic.Interaction.InputBox($"Digite o valor do pagamento\nValor a ser cobrado: R${totalPedido:F2}", "Pagamento", "Insira o valor recebido");
                if (double.TryParse(precoCliente, out double valorRecebido))
                {
                    if (valorRecebido >= totalPedido)
                    {
                        Troco = valorRecebido - totalPedido;
                        MessageBox.Show($"Pagamento recebido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Valor insuficiente para o pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (pagCredito.Checked)
            {
                MessageBox.Show($"Faça a cobrança de R$ {totalPedido:F2} no Crédito", "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (pagDebito.Checked)
            {
                MessageBox.Show($"Faça a cobrança de R${totalPedido:F2} no Débito", "Débito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (pagPix.Checked)
            {
                MessageBox.Show($"Faça a cobrança de R${totalPedido:F2} no Pix", "Pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um método de pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            HorarioPedido = DateTime.Now;
        }

        private void pagDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
