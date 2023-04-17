using System;
class Program {
  public static void Main (string[] args) {
    
    int tempo = int.Parse(Console.ReadLine());
    int velocidade = int.Parse(Console.ReadLine());
    double velocidadeGasta = tempo * velocidade;
    double litros = velocidadeGasta / 12;

    Console.WriteLine ($"{litros:f3}");
  }
}