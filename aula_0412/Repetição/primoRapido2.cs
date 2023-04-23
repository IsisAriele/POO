using System;

class Program {
    static bool primo(int n) {
        if (n == 1){
            return false;
        }
        int antecessores = n - 1;
        while(n % antecessores != 0){
            antecessores--;
        }
        return antecessores == 1; //Compara com 1, se true então é primo.
        
        
    }
    static void Main(string[] args) {
        int input = int.Parse(Console.ReadLine());

        for(int i = 0; i < input; i ++) {
            int numero = int.Parse(Console.ReadLine());
            if(primo(numero)) {
                Console.WriteLine("Prime");
            } else {
                Console.WriteLine("Not Prime");
            }
        }
    }
}