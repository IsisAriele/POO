using System;
class Program {
    public static void Main(){
        Console.WriteLine("Informe o número em decimal que você deseja converter:");
        int n = int.Parse(Console.ReadLine());
        Conversor numero = new Conversor(n);
        Console.WriteLine($"O número {numero.GetNum()} em base binária é: {numero.Binario()}");
    }
}

class Conversor{
    private int num;
    public Conversor(int num){
        if(num >= 0){
            this.num = num;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetNum(int num){
        if(num >= 0){
            this.num = num;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int GetNum(){
        return num;
    }

    public string Binario(){
        string numBinario = "";
        int resto;
        while(num > 0){
            resto = num % 2;
            num = num / 2;
            numBinario = Convert.ToString(resto) + numBinario;
        }
        return numBinario;
    }

    public override string ToString(){
        return $"Decimal = {num} | Binário = {this.Binario()}";
    }
}