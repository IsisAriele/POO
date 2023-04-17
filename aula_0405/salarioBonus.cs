using System;
class Program {
  public static void Main (string[] args) {

    //string name = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double comissao = vendas * 0.15;
    double salarioFinal = comissao + salario;

    Console.WriteLine ($"TOTAL = R$ {salarioFinal:f2}\n");

  }
}