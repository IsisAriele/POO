using System;
class Program {
    public static void Main(){
        Console.WriteLine("Informe os três coeficientes: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Equacao x = new Equacao(a, b, c);
        Console.WriteLine(x);

        double x1, x2;
        if(x.RaizesReais(out x1, out x2)){
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        } else {
            Console.WriteLine("A equação não possui raízes reais.");
        }
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
        double delta;
        delta = Math.Pow(b, 2) - 4 * a * c;
        return delta;
        }
    public bool RaizesReais(out double x1, out double x2){
        
        if(this.Delta() >= 0){
            x1 = (- b + Math.Sqrt(this.Delta())) / 2 * a;
            x2 = (- b - Math.Sqrt(this.Delta())) / 2 * a;
            return true;
        } else {
            x1 = x2 = 0;
            return false;
        }
        
    }

    public override string ToString(){
        return $"A = {a}, B = {b}, C = {c}";
    }
}