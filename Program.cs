using System;
using System.Collections.Generic;
namespace AT1_UC05
{
  internal class Program
  {


    static void Main(string[] args)
    {
        string produto;
        float valor;
        int quantidade;






      string fim = "s";
      Pedido pedido = new Pedido();
      while( fim == "s"){
        Console.Clear();
        Console.WriteLine("Digite seu produto");
        produto = Console.ReadLine();
        Console.WriteLine("Digite a quantidade que você deseja");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do produto");
        valor = float.Parse(Console.ReadLine());

        pedido.AddPedido(produto, valor, quantidade);

        Console.WriteLine("Deseja adicionar um novo produto? S/N");
        fim = Console.ReadLine();
      } 

      Console.WriteLine("O seu pedido deu um total de ->  R$" + pedido.TotalDoPedido());
    }
  }
  
}



