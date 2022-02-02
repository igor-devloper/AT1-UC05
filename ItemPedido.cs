using System;

namespace AT1_UC05
{
  public class ItemPedido
  {
    public string descricao { get;set; }
    public float valor_unitario { get;set; } 
    public int quantidade { get;set; }


    public void RealizarPedido()
    {
      Console.WriteLine("Qual o Produto deseja?");
      descricao = Console.ReadLine();
      Console.WriteLine("Quantos você itens vc deseja?");
      quantidade = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual o valor do Produto?");
      valor_unitario = float.Parse(Console.ReadLine());
    }
  }
  
}