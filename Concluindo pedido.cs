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
        private double totalPedido;
        public Concluindo_pedido(double total)
        {
            InitializeComponent();
            radioButton5.Checked = true;
            pagDinheiro.Checked = true;
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
      
            if (pagDinheiro.Checked)
            {
                string precoCliente = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor do pagamento", "Pagamento", "Insira o valor recebido");
                if (double.TryParse(precoCliente, out double valorRecebido))
                {
                    if (valorRecebido > totalPedido)
                    {
                        double troco = valorRecebido - totalPedido;
                        MessageBox.Show($"Pagamento recebido com sucesso! \nTroco: R$ {troco:F2}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Pagamento recebido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (pagDebito.Checked)
            {
                MessageBox.Show("Pagamento recebido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (pagPix.Checked)
            {
                MessageBox.Show("Pagamento recebido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um método de pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pagDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
