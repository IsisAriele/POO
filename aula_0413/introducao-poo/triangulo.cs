using System;

class Triangulo{
    public double b, h;
    public double CalcArea(){
        return (b * h) / 2;
    }
}

class Program {
    public static void Main(string[] args) {
        Triangulo x; // variável da classe, referência. Tipo.
        x = new Triangulo(); // instancia; objeto criado; objeto existe aqui com base e altura 0;
        x.b = 10; //valores nos campos da classe;
        x.h = 20;
        Console.WriteLine(x.CalcArea());
    }
}