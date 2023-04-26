using System;

class Circulo {
    public double raio; 
    public double CalcArea() {
        return Math.PI * Math.Pow(raio, 2);
    }

    public double CalcCirc() {
        return 2 * Math.PI * raio;
    }
}

class Program {
    public static void Main(string[] args) {
        Circulo x; // referencia
        x = new Circulo(); // isntância criada; objeto criado;
        x.raio = double.Parse(Console.ReadLine());

        Console.WriteLine(x.CalcArea());
        Console.WriteLine(x.CalcCirc());
        //Essa sintaxe permite que você acesse os métodos da instância x e execute as operações 
    }
}