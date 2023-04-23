using System;

class Program {
    static void Main(string[] args) {
        string[] palavras;

        while(true) {
            palavras = Console.ReadLine().Split(" ");
            if(palavras[0] == "*"){
                break;
            }

            char primeiraLetra = char.ToLower(palavras[0][0]); // Primera letra da primera palavra em minúscula para comparação.

            bool tautograma = true;

            for(int i = 1; i < palavras.Length; i++) {
                if(primeiraLetra != char.ToLower(palavras[i][0])){
                    tautograma = false;
                    break;
                }
            }

            if(tautograma) {
                Console.WriteLine("Y");
            } else {
                Console.WriteLine("N");
            }
            

        }

    }
}