using System;

class programa {
    static void Main(string[] args) {
        string[] apostas = Console.ReadLine().Split();

        string[] sorteados = Console.ReadLine().Split();

        int size = apostas.Length;
        int soma = 0;

        for(int i = 0; i < size; i++) {
            for(int j = 0; j < size; j++) {
                if(apostas[i] == sorteados[j]) {
                    soma += 1;
                }
            }   
        }

        if(soma == 3) {
            Console.WriteLine("terno");
        } 
        else if(soma == 4) {
            Console.WriteLine("quadra");
        }
        else if(soma == 5) {
            Console.WriteLine("quina");
        }
        else if(soma == 6) {
            Console.WriteLine("sena");
        } else {
            Console.WriteLine("azar");
        }
    }
}