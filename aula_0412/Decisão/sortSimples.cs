using System;

class programa {
    public static void Main(string[] args) {
        string[] x = Console.ReadLine().Split();
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);
        int c = int.Parse(x[2]);

        // Ordenação dos valores em ordem crescente

        int[] valoresOrdenados = {a, b, c};
        Array.Sort(valoresOrdenados);

        Console.WriteLine($"{valoresOrdenados[0]}");
        Console.WriteLine($"{valoresOrdenados[1]}");
        Console.WriteLine($"{valoresOrdenados[2]}\n");

        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Console.WriteLine($"{c}");

    }
}