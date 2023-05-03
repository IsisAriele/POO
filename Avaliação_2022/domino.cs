using System;
class Program {
    public static void Main(){
        Console.WriteLine("Escreva o valor do lado 1 da peça 1");
        int lado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o valor do lado 2 da peça 1");
        int lado2 = int.Parse(Console.ReadLine());
        Domino peca1 = new Domino(lado1, lado2);
        Console.WriteLine(peca1);

        Console.WriteLine("Escreva o valor do lado 1 da peça 2");
        lado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o valor do lado 2 da peça 2");
        lado2 = int.Parse(Console.ReadLine());
        Domino peca2 = new Domino(lado1, lado2);
        Console.WriteLine(peca2);

        if(peca1.Combinar(peca2)){
            Console.WriteLine("Combináveis");
        } else {
            Console.WriteLine("Não são combináveis");
        }
        
    }
}

class Domino{
    int lado1, lado2;

    public Domino(int lado1, int lado2){
        if(lado1 >=0 && lado1 < 7){
            this.lado1 = lado1;
        } else {
            throw new ArgumentOutOfRangeException();
        }
        if(lado2 >=0 && lado2 < 7){
            this.lado2 = lado2;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetLado1(int lado1){
        if(lado1 >=0 && lado1 < 7){
            this.lado1 = lado1;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetLado2(int lado2){
        if(lado2 >=0 && lado2 < 7){
            this.lado2 = lado2;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int GetLado1(){
        return lado1;
    }
    public int GetLado2(){
        return lado2;
    }

    public bool Combinar(Domino p){
        if(p.GetLado1() == this.lado1 || p.GetLado1() == this.lado2 || p.GetLado2() == this.lado1 || p.GetLado2() == this.lado2){
            return true;
        } else {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Lado 1 = {lado1} | Lado 2 = {lado2}";
    }
}