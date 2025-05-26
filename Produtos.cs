using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Semestral___Cantina
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; } = 0;
        public bool IsChapa { get; set; } = false;
        public Produto(int id, string nome, double preco,int quantidade,bool isChapa)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            IsChapa = isChapa;
        }
        public override string ToString()
        {
            return $"{Id} - {Nome} - Qtd: {Quantidade} - R$ {Preco:F2}";
        }
    }
}
