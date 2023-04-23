using System;

class Program {
    static void Main(string[] args) {

        double NotaValida1;
        double NotaValida2;
        double media;


        while(true) {
            double nota1Lida = double.Parse(Console.ReadLine());
            if(nota1Lida < 0 || nota1Lida > 10){
                Console.WriteLine("nota invalida");
            } else {
                NotaValida1 = nota1Lida;
                break;
            }
        }

        while(true) {
            double nota2Lida = double.Parse(Console.ReadLine());
            if(nota2Lida < 0 || nota2Lida > 10){
                Console.WriteLine("nota invalida");
            } else {
                NotaValida2 = nota2Lida;
                break;
            }
        }

        media = (NotaValida1 + NotaValida2) / 2;

        Console.WriteLine($"media = {media:f2}");
    }
}
