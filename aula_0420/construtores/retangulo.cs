using System;
class Program {
    public static void Main(string[] args){
        Console.WriteLine("Digite o valor da base do retangulo: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do retangulo: ");
        double h = double.Parse(Console.ReadLine());
        Retangulo x = new Retangulo(b, h);
        Console.WriteLine($"Área do retângulo = {x.CalcArea():f1} | Diagonal do retângulo = {x.CalcDiagonal():f1}");
        Console.WriteLine(x);
    }
}

class Retangulo {
    private double b, h;

    public Retangulo(double b, double h){
        if(b > 0) {
            this.b = b;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(h > 0) {
            this.h = h;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetBase(double b){
        if(b > 0) {
            this.b = b;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }
    public void SetAltura(double h){
        if(h > 0) {
            this.h = h;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public double GetBase(){
        return b;
    }

    public double GetAltura(){
        return h;
    }

    public double CalcArea(){
        return b * h;
    }

    public double CalcDiagonal(){
        return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2)); //Raiz quadrada da soma dos quadrados dos lados (b e h);
    }
    public override string ToString(){
        return $"Base = {b}, Altura = {h}";
    }
}