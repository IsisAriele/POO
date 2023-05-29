using System;
using System.Collections;

class Aluno : IComparable{
    private string nome;
    private DateTime nasc;
    public Aluno(string n, DateTime d){
        if(!string.IsNullOrEmpty(n)){
            nome = n;
        } else{
            throw new ArgumentOutOfRangeException();
        }
        nasc = d;
    }

    public int CompareTo(object obj){
        Aluno outroAluno = (Aluno)obj;
        return nome.CompareTo(outroAluno.nome);
    }

    public string GetNome(){
        return nome;
    }

    public DateTime GetNascimento(){
        return nasc;
    }

    public override string ToString()
    {
        return $"{nome} | {nasc}";
    }
}

class AlunoNacComp: IComparer{
    public int Compare(object x, object y){
        Aluno a = (Aluno)x;
        Aluno b = (Aluno)y;
        return a.GetNascimento().CompareTo(b.GetNascimento());
    }
}

class Program {
    public static void Main(){
        Aluno a = new Aluno("Pedro", DateTime.Parse("1992-01-01"));
        Aluno b = new Aluno("Maria", DateTime.Parse("1993-01-01"));
        Aluno c = new Aluno("Paulo", DateTime.Parse("1991-01-01"));
        Aluno[] v = { a, b, c };
        Array.Sort(v, new AlunoNacComp());
        foreach(Aluno i in v){
            Console.WriteLine(i);
        }
    }
}