using System;
class Program {
    public static void Main(string[] args){
        Banco conta = new Banco();
        Console.WriteLine("Informe seu nome:");
        conta.SetNomeConta(Console.ReadLine());
        Console.WriteLine("Informe o número da sua conta");
        conta.SetNumeroConta(Console.ReadLine());
        
        Console.WriteLine($"Olá, {conta.GetNomeConta()}, seu saldo atual é: R$ {conta.GetSaldo():f2}");

        Console.WriteLine("Digite o valor que deseja depositar:");
        if(conta.Depositar(double.Parse(Console.ReadLine()))){
            Console.WriteLine("Operação realizada com sucesso!");
        } else {
            Console.WriteLine("Valor inválido.");
        }
    
        Console.WriteLine($"Seu saldo atual é: R$ {conta.GetSaldo():f2}");

        Console.WriteLine("Digite o valor que deseja sacar:");
        if(conta.Sacar(double.Parse(Console.ReadLine()))){
            Console.WriteLine("Operação realizada com sucesso!");
        } else {
            Console.WriteLine("Valor inválido.");
        }

        Console.WriteLine($"Seu saldo atual é: R$ {conta.GetSaldo():f2}");
    }
}

class Banco {
    private string nomeConta, numeroConta;
    private double saldo;
    public void SetNomeConta(string n){
        if(!string.IsNullOrEmpty(n)) {
            this.nomeConta = n;
        } else {
            throw new ArgumentOutOfRangeException("Escreva um nome válido!");
        }
    }

    public void SetNumeroConta(string n){
        if(!string.IsNullOrEmpty(n)){
            this.numeroConta = n;
        } else {
            throw new ArgumentOutOfRangeException("Escreva um número da conta válido!");
        }
    }

    public string GetNomeConta(){
        return nomeConta;
    }
    public string GetNumeroConta(){
        return numeroConta;
    }
    public double GetSaldo(){
        return saldo;
    }

    public bool Depositar(double v){
        if(v > 0){
            saldo += v;
            return true;
        } else {
            throw new ArgumentOutOfRangeException();
            return false;
        }
    }

    public bool Sacar(double v){
        if(v > 0 && v <= saldo){
            saldo -= v;
            return true;
        } else {
            throw new ArgumentOutOfRangeException();
            return false;
        }
    }
}