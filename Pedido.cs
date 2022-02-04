using System;
using System.Collections.Generic;

namespace AT1_UC05
{
  class Pedido
  {
    public List<ItemPedido> listaDePedido = new List<ItemPedido>();
    public void AddPedido(ItemPedido c)
    {
        listaDePedido.Add(c);
    }
    public void InfosPedidos()
    {
       foreach(ItemPedido c in listaDePedido)
      {
        Console.WriteLine("Produto" +c  + "valor R$" +c.valor_unitario + ".");
      }
    }
  
  }

}