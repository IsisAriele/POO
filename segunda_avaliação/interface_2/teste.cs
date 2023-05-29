using System;
using System.Collections;

class Equipe{
    private string pais;
    private Jogador[] jogs;
    private int quantidadeJogadores;
    private int count = 0;
    public Equipe(string p, int q){
        if(q > 0){
            this.quantidadeJogadores = q;
            jogs = new Jogador[q]; //Inicializa o array jogs com tamanho correto
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(!string.IsNullOrEmpty(p)){
            this.pais = p;
        } else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public void Inserir(Jogador j){
        if(count<quantidadeJogadores){
            jogs[count] = j;
            count++;
        } else{
            Console.WriteLine("O limite de jogadores foi excedido!");
        }
    }

    public Jogador[] Listar(){
        return jogs;
    }

    public override string ToString(){
        return $"{pais}";
    }
}

class Jogador : IComparable{
    private string nome;
    private int camisa, numGols;
    public Jogador(string n, int c, int g){
        this.nome = n;
        this.camisa = c;
        this.numGols = g;    
    }

    public int CompareTo(object obj){
        Jogador outroJogador = (Jogador)obj;
        return this.nome.CompareTo(outroJogador.nome);
    }

    public string Nome{
        set{if(!string.IsNullOrEmpty(value)) this.nome = value;}
        get{return nome;}
    }

    public int Camisa{
        set{if(value > 0) this.camisa = value;}
        get{return camisa;}
    }
    public int NumGols{
        set{if(value > 0) this.numGols = value;}
        get{return numGols;}
    }
    

    public override string ToString(){
        return $"{nome} | {camisa} | {numGols}";
    }
}

class CamisaComparator: IComparer{
    public int Compare(object x, object y){
        Jogador a = (Jogador)x;
        Jogador b = (Jogador)y;
        return a.Camisa.CompareTo(b.Camisa);
    }
}

class GolComparator: IComparer {
    public int Compare(object x, object y){
        Jogador a = (Jogador)x;
        Jogador b = (Jogador)y;
        return -a.NumGols.CompareTo(b.NumGols);
    }
}

class Program{
    public static void Main(){
        Jogador a = new Jogador("Neymar", 11, 500);
        Jogador b = new Jogador("zico", 10, 700);
        Jogador c = new Jogador("ronaldo", 8, 100);

        Equipe selecao = new Equipe("Brasil", 3);
        selecao.Inserir(a);
        selecao.Inserir(b);
        selecao.Inserir(c);
        Jogador[] jogadores = selecao.Listar();
        Console.WriteLine($"Os jogadores do {selecao} são:");
        foreach(Jogador i in jogadores){
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("Ordem dos artilheiros da seleção:");
        Jogador[] artilheiros = {a, b, c};
        Array.Sort(artilheiros, new GolComparator());
        foreach(Jogador i in artilheiros){
            Console.WriteLine(i);
        }
    }
}