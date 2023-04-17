using System; 

class URI {

    static void Main(string[] args) { 

        string[] t = Console.ReadLine().Split(' ');
        int a = int.Parse(t[0]);
        int b = int.Parse(t[1]);
        int c = int.Parse(t[2]);
        int d = int.Parse(t[3]);
        
        if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0) Console.WriteLine("Valores aceitos");
        else Console.WriteLine("Valores nao aceitos");
    }
}