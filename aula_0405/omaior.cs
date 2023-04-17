using System; 

class URI {

    public static void Main(string[] args) { 

        string[] x = Console.ReadLine().Split(' ');
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);
        int c = int.Parse(x[2]);
    
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
    
        Console.WriteLine(maiorABC + " eh o maior");

    }
}