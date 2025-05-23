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
        public Produto(int id, string nome, double preco,int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public override string ToString()
        {
            return $"{Nome} - Qtd: {Quantidade} - R$ {Preco:F2}";
        }
    }
}
