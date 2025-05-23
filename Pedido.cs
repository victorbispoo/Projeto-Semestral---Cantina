using System;
using System.Collections.Generic;

namespace Projeto_Semestral___Cantina
{
    internal class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public List<Produto> ProdutosPedido { get; set; } = new List<Produto>();
        public string Status { get; set; } = "";
        public DateTime DataHora { get; set; }

        public Pedido(int id, string nomeCliente, string status, List<Produto> produtos,DateTime dataHora)
        {
            Id = id;
            NomeCliente = nomeCliente;
            Status = status;
            ProdutosPedido = produtos ?? new List<Produto>();
            DataHora = dataHora;
        }

        public override string ToString()
        {
            return $"Pedido ID: {Id} - Cliente: {NomeCliente} - Status: {Status}";
        }
    }
}
