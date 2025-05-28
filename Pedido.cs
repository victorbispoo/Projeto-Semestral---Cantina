using System;
using System.Collections.Generic;

namespace Projeto_Semestral___Cantina
{
    internal class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public List<Produto> ProdutosPedido { get; set; }
        public string Status { get; set; } = "";
        public DateTime DataHora { get; set; }
        public bool IsChapa { get; set; } = false;
        public string TipoPedido { get; set; } = "";
        public Pedido(int id, string nomeCliente, string status, List<Produto> produtos,DateTime dataHora,bool isChapa,string tipoPedido)
        {
            Id = id;
            NomeCliente = nomeCliente;
            Status = status;
            ProdutosPedido = produtos ?? new List<Produto>();
            DataHora = dataHora;
            IsChapa = isChapa;
            TipoPedido = tipoPedido;
        }

        public override string ToString()
        {
            return $"Pedido ID: {Id} - Cliente: {NomeCliente} - Status: {Status} - {DataHora:HH:mm:ss}";
        }
    }
}
