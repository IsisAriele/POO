using System;

class Paciente{
    private string nome, cpf, telefone;
    private DateTime nascimento;

    public Paciente(string n, string c, string t, DateTime nasc){
        if(!string.IsNullOrEmpty(n)) {
            nome = n;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(!string.IsNullOrEmpty(c)) {
            cpf = c;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(!string.IsNullOrEmpty(t)) {
            telefone = t;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(nasc < DateTime.Now) {
            nascimento = nasc;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    
    }

    public void SetNome(string n){
         if(!string.IsNullOrEmpty(n)) {
            nome = n;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public string GetNome(){
        return nome;
    }

    public void SetCPF(string c){
        if(!string.IsNullOrEmpty(c)) {
            cpf = c;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public string GetCPF(){
        return cpf;
    }

    public void SetTelefone(string t){
        if(!string.IsNullOrEmpty(t)) {
            telefone = t;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public string GetTelefone(){
        return telefone;
    }

    public void SetNascimento(DateTime nasc){
        if(nasc < DateTime.Now) {
            nascimento = nasc;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public DateTime GetNascimento(){
        return nascimento;
    }

    public string Idade(){
        int anos = DateTime.Now.Year - nascimento.Year;
        int meses = DateTime.Now.Month - nascimento.Month;
        if (meses < 0) {
            meses += 12;
            anos--;
        }
        return $"{anos} ano(s) e {meses} mes(es)";
    }

    public override string ToString(){
        return $"Nome: {nome} | CPF: {cpf} | Telefone: {telefone} | Nascimento: {nascimento}";
    }
}

class Program{
    public static void Main(){
        string nome = Console.ReadLine();
        string cpf = Console.ReadLine();
        string telefone = Console.ReadLine();
        DateTime nascimento = DateTime.Parse(Console.ReadLine());
        Paciente x = new Paciente(nome, cpf, telefone, nascimento);
        Console.WriteLine($"{x.GetNome()} {x.Idade()}");
    }
}