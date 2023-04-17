using System;
class Program {
  public static void Main (string[] args) {
    
    string[] t =   Console.ReadLine().Split(' ');
    int l = int.Parse(t[0]);
    int d = int.Parse(t[1]);
     string[] v =   Console.ReadLine().Split(' ');
    int k = int.Parse(v[0]);
    int p = int.Parse(v[1]);

    int quantidadeDePedagios = l / d;
    int custoFinal = (l * k) + (quantidadeDePedagios * p);

    Console.WriteLine ($"{custoFinal}");
  }
}