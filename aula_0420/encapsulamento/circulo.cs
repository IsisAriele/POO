using System;

class Program {
    public static void Main(string[] args){
        Circulo x = new Circulo();
        Console.WriteLine("Digite o valor do raio:");
        double r = double.Parse(Console.ReadLine());
        x.SetRaio(r);
        Console.WriteLine($"O círculo com raio {x.GetRaio()} tem a área de {x.CalcArea():f2} e circunferência de {x.CalcCircunferencia():f2}.");
    }
}

class Circulo{
    private double raio;
    public void SetRaio(double v){
        if(v > 0) this.raio = v;
    }
    public double GetRaio() {
        return raio;
    }

    public double CalcArea(){
        return Math.PI * Math.Pow(raio, 2);
    }
    public double CalcCircunferencia(){
        return 2 * Math.PI * raio;
    }
}