using System;

class programa {
    public static void Main(string[] args) {
        string[] x = Console.ReadLine().Split();
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);
        int c = int.Parse(x[2]);
        int d = int.Parse(x[3]);
        int e = int.Parse(x[4]);
 
        if (a > b && b > c && c > d && d > e) {
            Console.WriteLine("D");
        } else if (a < b && b < c && c < d && d < e) {
            Console.WriteLine("C");
        } else {
            Console.WriteLine("N");
        }

    }
}