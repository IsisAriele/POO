using System;

class programa {

    public static void Ordenar(ref int x, ref int y, ref int z) {
        int maior, meio, menor;
        maior = Math.Max(x, Math.Max(y, z));
        menor = Math.Min(x, Math.Min(y, z));
        meio = x + y + z - maior - menor;
        x = menor;
        y = meio;
        z = maior;
    }


    public static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        Ordenar(ref x, ref y, ref z);
        Console.WriteLine($"{x}, {y}, {z}");
    }
}