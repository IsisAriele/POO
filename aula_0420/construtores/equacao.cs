using System;
class Program {
    public static void Main(){
        Console.WriteLine("Informe os três coeficientes: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Equacao x = new Equacao(a, b, c);
        Console.WriteLine($"{x.RaizesReais} | {x.Delta}");
        Console.WriteLine(x);
    }
}

class Equacao {
    private double a, b, c;
    public Equacao(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void SetABC(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void GetABC(out double a, out double b, out double c){ //out --> valor definido no método.
        a = this.a;
        b = this.b;
        c = this.c;
    }
    public double Delta(){

        }
    public bool RaizesReais(out double x1, out double x2){

    }

    public override string ToString(){
        return $"A = {a}, B = {b}, C = {c}";
    }
}