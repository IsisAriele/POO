using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”\n");
    string[] t = Console.ReadLine().Split(':');
    int h = int.Parse(t[0]);
    int m = int.Parse(t[1]);
    int s = int.Parse(t[2]);

    long totalSegundos = s + m * 60 + h * 3600;
    long distancia = totalSegundos * 300000;
    // long - pois dá um valor inteiro que passa de 2 milhões.
    // Velocidade da luz: 300mil km/s
    
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo\n");

  } 
}