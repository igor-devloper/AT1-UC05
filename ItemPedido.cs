using System;
using System.Collections.Generic;
namespace AT1_UC05
{
  public class ItemPedido
  {
    public string descricao { get; set; }
    public float valor_unitario { get; set; }
    public int quantidade {get; set;}
    public ItemPedido (string produto, float valor, int quant){
       descricao = produto;
        valor_unitario = valor;
        quantidade = quant;
    }
  }
  
  
}