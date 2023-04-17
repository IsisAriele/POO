using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Digite a base a altura do retângulo\n");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());

    double area = b * h;
    double perimetro = (b * 2) + (h * 2);
    double diagonal = Math.Sqrt(b * b + h * h);

    Console.WriteLine($"Área = {area:f2} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:f2}\n");
    
  } 
}
