using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Semestral___Cantina
{
    internal class Pedido
    {
        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public string Status { get; set; } = "";
        public Pedido(int idPedido, string nomeCliente,string status)
        {
            IdPedido = idPedido;
            NomeCliente = nomeCliente;
            Status = status;
        }

        public override string ToString()
        {
            return $"Pedido ID: {IdPedido} - Cliente: {NomeCliente} - Status: {Status}";
        }
    }
}
