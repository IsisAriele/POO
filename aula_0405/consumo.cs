using System; 

class URI {
    public static void Main(string[] args) { 

        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());
        double consumoMedio = distancia / combustivel;
        Console.WriteLine ($"{consumoMedio:f3} km/l");

    }
}