using System; 

class programa {

    public static int MMC(int x, int y){
        int menor= 0;
        for(int i = 1; i <= x * y; i++){
            if(i % x == 0 && i % y == 0) {
                menor = i;
                break;
            }
        }
        return menor;
    }
    public static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"{MMC(x, y)}");
    }
}