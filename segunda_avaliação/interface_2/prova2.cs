//A classe deve implementar a interface IComparable para que a ordenação de objetos da classe mostre os
//jogadores ordenados pelo nome em ordem alfabética

using System;
using System.Collections;

class Equipe{
    private string pais;
    private Jogador[] jogs;
    private int quantidadeJogadores;
    private int count = 0;

    public Equipe(string p, int q){
        this.quantidadeJogadores = q;
        jogs = new Jogador[quantidadeJogadores];

        this.pais = p;
    }
    public void Inserir(Jogador j){
        if(count<quantidadeJogadores){
            jogs[count] = j;
            count++;
        } else{
            Console.WriteLine("Capacidade máxima de jogadores atingida.");
        }
    }
    public Jogador[] Listar(){
        //Array.Sort(jogs, 0, count); //ordena o array jogs a partir do índice 0 até o índice count
        return jogs;
    }

    public override string ToString(){

        return $"{pais}";
    }
}

class Jogador : IComparable{
    private string nome;
    private int camisa, numGols;

    public Jogador(string nome, int camisa, int numGols){
        this.nome = nome;
        this.camisa = camisa;
        this.numGols = numGols;
    }

    public string Nome{
        set{if(!string.IsNullOrEmpty(value)) this.nome = value;}
        get{return nome;}  
    }

    public int Camisa{
        set{if(value > 0 && value < 1000) this.camisa = value; }
        get{ return camisa;}
    }

    public int NumGols{
        set{if(value >= 0) this.numGols = value;}
        get{ return numGols;}
    }
    public int CompareTo(object obj){
        Jogador outroJogador = (Jogador)obj;
        return nome.CompareTo(outroJogador.nome);
    }

    public override string ToString(){
        return $"{nome} | {camisa} | {numGols}";
    }
}

class CamisaComparator :IComparer {
    public int Compare(object obj1, object obj2){
        Jogador x = (Jogador)obj1;
        Jogador y = (Jogador)obj2;
        return x.Camisa.CompareTo(y.Camisa);
    }
}

class GolComparator : IComparer {
    public int Compare(object obj1, object obj2){
        Jogador x = (Jogador)obj1;
        Jogador y = (Jogador)obj2;
        return -x.NumGols.CompareTo(y.NumGols);
    }
}

class Program {
    public static void Main(){
        Jogador a = new Jogador("sócrates", 8, 200);
        Jogador b = new Jogador("Zico", 10, 700);
        Jogador c = new Jogador("Ronaldo", 1, 10);
        
        Equipe selecao = new Equipe("Brasil", 3);
        selecao.Inserir(a);
        selecao.Inserir(b);
        selecao.Inserir(c);
        Console.WriteLine($"Os jogadores da equipe do {selecao} são:");
        Jogador[] jogadores = selecao.Listar();
        foreach(Jogador i in jogadores){
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine($"Ordem dos melhores artilheiros do {selecao}:");
        Jogador[] v = {a, b, c};
        Array.Sort(v, new GolComparator());
        foreach(Jogador i in v){
            Console.WriteLine(i);
        }
    }
}