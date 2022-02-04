using System;
using System.Collections.Generic;
namespace AT1_UC05
{
  internal class Program
  {
    
    static void Main(string[] args)
    {
      ItemPedido pedido = new ItemPedido();
      pedido.RealizarPedido();
      Pedido pedidos = new Pedido();
      pedidos.InfosPedidos();
    }
  }
}


