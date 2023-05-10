using System;

class Program {
    public static void Main(){
        Console.WriteLine("Escreva, em linhas diferentes, o valor e naipe da primeira carta:");
        CartaBaralho carta1 = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());

        Console.WriteLine("Escreva, em linhas diferentes, o valor e naipe da segunda carta:");
        CartaBaralho carta2 = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());

        if(carta1.CompararCartas(carta2)){
            Console.WriteLine("As cartas são iguais!");
        }else{
            Console.WriteLine("As cartas são diferentes!");
        }

        Console.WriteLine(carta1);
        Console.WriteLine(carta2);
    }
}

class CartaBaralho{
    private int valor;
    private string naipe;

    public CartaBaralho(int valor, string naipe){
        if(valor > 0 && valor < 14){
            this.valor = valor;
        } else{
            throw new ArgumentOutOfRangeException();
        }

        if(!string.IsNullOrEmpty(naipe)){
            if(naipe == "espadas" || naipe == "paus" || naipe == "copas" || naipe == "ouros"){
                this.naipe = naipe;
            } else{
                throw new ArgumentOutOfRangeException();
            }
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetValor(int valor){
        if(valor > 0 && valor < 14){
            this.valor = valor;
        } else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetNaipe(string naipe){
        if(!string.IsNullOrEmpty(naipe)){
            if(naipe == "espadas" || naipe == "paus" || naipe == "copas" || naipe == "ouros"){
                this.naipe = naipe;
            } else{
                throw new ArgumentOutOfRangeException();
            }
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int GetValor(){
        return valor;
    }

    public string GetNaipe(){
        return naipe;
    }

    public bool CompararCartas(CartaBaralho c){
        if(this.valor == c.GetValor() && this.naipe == c.GetNaipe()){
            return true;
        } else{
            return false;
        }
    }

    public override string ToString(){
        return $"Valor = {valor} | Naipe = {naipe}";
    }
}