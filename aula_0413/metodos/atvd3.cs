using System;

class program {
    public static void Intervalo(double x, out int inicio, out int fim){
        inicio = (int)x; // Obtém a parte inteira de x
        fim = (int)x; // Obtém a parte inteira de x

        if (x < 0) {
            // Se x for negativo, decrementa o valor de início
            inicio--;
        } else {
            // Se x for positivo, incrementa o valor de fim
            fim++;
        }
    }

    public static void Main(string[] args) {
        double x = double.Parse(Console.ReadLine());
        int inicio, fim;
        Intervalo(x, out inicio, out fim);

        Console.WriteLine($"[{inicio},{fim}]");
    }
}