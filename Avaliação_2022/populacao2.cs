using System;
class Program {
    public static void Main(){
        Populacao[] pais = new Populacao[3];
        int maiorPopulacao = 0;
        int indiceMaiorPopulacao = 0;
        for(int i = 0; i < 3; i++){
            Console.WriteLine("Informe o nome do país e a população:");
            //Criamos um novo objeto Populacao, utilizando o construtor que recebe o nome e a população do país, e armazenamos esse objeto na posição i do array pais.
            pais[i] = new Populacao(Console.ReadLine(), int.Parse(Console.ReadLine()));
            if(pais[i].GetPopulacao() > maiorPopulacao){
                maiorPopulacao = pais[i].GetPopulacao(); //Guarda o número da população para proximas comparações
                indiceMaiorPopulacao = i; //armazena indice para saída
            }
        }

        Console.WriteLine(pais[indiceMaiorPopulacao]);
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

        if(p>0){
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

    public override string ToString(){
        return $"Nome = {nome} | População = {populacao}";
    }
}