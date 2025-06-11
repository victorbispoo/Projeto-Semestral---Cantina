using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projeto_Semestral___Cantina
{
    internal static class PersistenciaPedido
    {
        public static List<Produto> produtosEstoque = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();
        public static List<Pedido> pedidosProntos = new List<Pedido>();
        public static List<Pedido> pedidosEntregues = new List<Pedido>();
        public static List<Logins> usuarios = new List<Logins>();

        public static string caminhoProdutos = "produtos.json";
        public static string caminhoPedidos = "pedidos.json";
        public static string caminhoLogins = "logins.json";

        public static void SalvarProdutosEstoque(string caminhoProdutos)
        {
            var json = JsonSerializer.Serialize(produtosEstoque, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoProdutos, json);
        }

        public static void CarregarProdutosEstoque(string caminhoProdutos)
        {
            if (File.Exists(caminhoProdutos))
            {
                var json = File.ReadAllText(caminhoProdutos);
                var lista = JsonSerializer.Deserialize<List<Produto>>(json);
                if (lista != null)
                    produtosEstoque = lista;
            }
        }

        public static void SalvarPedidosEntregues(string caminhoPedidos)
        {
            var json = JsonSerializer.Serialize(pedidosEntregues, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoPedidos, json);
        }
        public static void CarregarPedidosEntregues(string caminhoPedidos)
        {
            if (File.Exists(caminhoPedidos))
            {
                var json = File.ReadAllText(caminhoPedidos);
                var lista = JsonSerializer.Deserialize<List<Pedido>>(json);
                if (lista != null)
                    pedidosEntregues = lista;
            }
        }
        public static void SalvarLogins(string caminhoLogins)
        {
            var json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoLogins, json);
        }
        public static void CarregarLogins(string caminhoLogins)
        {
            if (File.Exists(caminhoLogins))
            {
                var json = File.ReadAllText(caminhoLogins);
                var lista = JsonSerializer.Deserialize<List<Logins>>(json);
                if (lista != null)
                    usuarios = lista;
            }
        }
    }
}
