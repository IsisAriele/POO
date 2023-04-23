using System;

class Program {
    static bool primo(int n) {
        int contador = 0;
        for(int i = 1; i <= n; i++){
            if(n % i == 0){
                contador++;
            } 
        }
        if(contador == 2) {
            return true;
        } else {
            return false;
        }
        
        
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