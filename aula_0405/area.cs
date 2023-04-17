using System;

class programa {
    public static void Main (string[] args) {
       string[] area = Console.ReadLine().Split(); 
        double a = double.Parse(area[0]);
        double b = double.Parse(area[1]);
        double c = double.Parse(area[2]);

        double triangulo = (a*c) / 2;
        double circulo = 3.14159 * Math.Pow(c, 2);
        double trapezio = ((a + b) * c) / 2;
        double quadrado = b * b;
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo:f3}");
        Console.WriteLine($"CIRCULO: {circulo:f3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:f3}");
        Console.WriteLine($"QUADRADO: {quadrado:f3}");
        Console.WriteLine($"RETANGULO: {retangulo:f3}");
    }
}


