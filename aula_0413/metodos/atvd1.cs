using System;

class programa {
    public static double Maior(double x, double y) {
        double maior;
        if(x >= y) {
            maior = x;
        } else {
            maior = y;
        }
        return maior;
    }


    public static void Main(string[] args) {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine($"{Maior(x, y)}");


    }
}