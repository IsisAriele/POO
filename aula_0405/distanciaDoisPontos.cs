using System;
class Program {
  public static void Main (string[] args) {
    
    string[] x = Console.ReadLine().Split(' ');
    double x1 = double.Parse(x[0]);
    double y1 = double.Parse(x[1]);
    string[] y = Console.ReadLine().Split(' ');
    double x2 = double.Parse(y[0]);
    double y2 = double.Parse(y[1]);

    double distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

    Console.WriteLine ($"{distancia:f4}");
  }
}