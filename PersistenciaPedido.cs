using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Semestral___Cantina
{
    internal class PersistenciaPedido
    {
        public static List<Pedido> pedidos = new List<Pedido>();
        public static List<Pedido> pedidosProntos = new List<Pedido>();
        public static List<Pedido> pedidosEntregues = new List<Pedido>();
    }
}
