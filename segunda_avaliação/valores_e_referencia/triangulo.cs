using System;

class MainClass
{
    public static void Main()
    {
        Triangulo x = new Triangulo(10, 20, "Azul"); // Linha 1
        Triangulo y = x;
        Triangulo z;
        double bx, rx;
        string cx;
        y.GetBHC(out bx, out rx, out cx); // Linha 6
        Console.WriteLine($"{bx} {rx} {cx}");
    }
}
class Triangulo
{
    private double b, h;
    private string c;
    public Triangulo(double b, double h, string c)
    {
        this.b = b;
        this.h = h;
        this.c = c;
    }
    public void GetBHC(out double b, out double h, out string c)
    {
        b = this.b;
        h = this.h;
        c = this.c;
    }
}

// a) Mostrar as variáveis nas memórias Stack do método Main, Stack do construtor de Triângulo e Heap quando o
// construtor da classe Triângulo estiver em execução, após a chamada realizada na linha 1 do método Main.
// Stack do método Main:
// |----------------|
// |      x         |
// |----------------|
// |      y         |
// |----------------|
// |                |
// |      ...       |
// |                |
// |----------------|

// Stack do construtor de Triângulo:
// |----------------|
// |      b         |
// |----------------|
// |      h         |
// |----------------|
// |      c         |
// |----------------|

// Heap:
// |------------------------|
// |       Triangulo        |
// |------------------------|
// |        b = 10          |
// |------------------------|
// |        h = 20          |
// |------------------------|
// |    c = "Azul"          |
// |------------------------|
// b) Mostrar as variáveis nas memórias Stack do método Main, Stack do método GetBHC e Heap quando o método
// GetBHC estiver em execução, após a chamada realizada na linha 6 do método Main.
// Stack do método Main:
// |----------------|
// |      x         |
// |----------------|
// |      y         |
// |----------------|
// |      z         |
// |----------------|
// |      bx        |
// |----------------|
// |      rx        |
// |----------------|
// |      cx        |
// |----------------|
// |      ...       |
// |----------------|

// Stack do método GetBHC:
// |----------------|
// |      b         |
// |----------------|
// |      h         |
// |----------------|
// |      c         |
// |----------------|

// Heap:
// |------------------------|
// |       Triangulo        |
// |------------------------|
// |        b = 10          |
// |------------------------|
// |        h = 20          |
// |------------------------|
// |    c = "Azul"          |
// |------------------------|