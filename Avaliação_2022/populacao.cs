using System;

class Program{
    public static void Main(){
        Populacao paisComMaiorPopulacao = new Populacao("Inicial", 1);
        int contador = 0;
        while(contador != 3){
            Console.WriteLine("Informe o nome do país:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o número de habitantes:");
            int populacao = int.Parse(Console.ReadLine());
            Populacao pais = new Populacao (nome, populacao);

            if(pais.GetPopulacao() >= paisComMaiorPopulacao.GetPopulacao()){
                paisComMaiorPopulacao = pais;
            }
            contador++;
        }

        Console.WriteLine(paisComMaiorPopulacao);
    }
}

class Populacao {
    private string nome;
    private int populacao;

    public Populacao(string n, int p){
        if(!string.IsNullOrEmpty(n)){
            nome = n;
        } else{
            throw new ArgumentOutOfRangeException();
        }

        if(p > 0){
            populacao = p;
        } else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetNome(string n){
        if(!string.IsNullOrEmpty(n)){
            nome = n;
        } else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetPopulacao(int p){
        if(p > 0){
            populacao = p;
        } else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public string GetNome(){
        return nome;
    }
    public int GetPopulacao(){
        return populacao;
    }
    public override string ToString()
    {
        return $"Nome = {nome} | População = {populacao}";
    }
}