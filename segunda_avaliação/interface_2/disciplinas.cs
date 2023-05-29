using System;
using System.Collections;
interface IDisciplina{
    string GetNome();
    int CalcMediaParcial();
    int CalcMediaFinal();
}

class DisciplinaAnual : IDisciplina{
    private string nome;
    private int nota1, nota2, nota3, nota4, notaFinal;

    public DisciplinaAnual(string nome, int n1, int n2, int n3, int n4, int nf){
        this.nome = nome;
        nota1 = n1;
        nota2 = n2;
        nota3 = n3;
        nota4 = n4;
        notaFinal = nf;
    }
    public string GetNome(){
        return nome;
    }
    public int CalcMediaParcial(){
        return ((this.nota1 * 2) + (this.nota2 * 2) + (this.nota3 * 3) + (this.nota4 * 3)) / 10; 
    }
    public int CalcMediaFinal(){
        return (this.CalcMediaParcial() + this.notaFinal) / 2;
    }
}

class DisciplinaSemestral: IDisciplina {
    private string nome;
    private int nota1, nota2, notaFinal;

    public DisciplinaSemestral(string nome, int n1, int n2, int nf){
        this.nome = nome;
        nota1 = n1;
        nota2 = n2;
        notaFinal = nf;
    }
    public string GetNome(){
        return nome;
    }
    public int CalcMediaParcial(){
        return ((this.nota1 * 2) + (this.nota2 * 3)) / 5; 
    }
    public int CalcMediaFinal(){
        return (this.CalcMediaParcial() + this.notaFinal) / 2;
    }
}

class Program{
    public static void Main(){
        IDisciplina disciplina1 = new DisciplinaAnual("Matematica", 7, 8, 9, 10, 6);
        IDisciplina disciplina2 = new DisciplinaSemestral("Portugues", 7, 8, 9);
        
        Console.WriteLine("Disciplina Anual: " + disciplina1.GetNome());
        Console.WriteLine("Média Parcial: " + disciplina1.CalcMediaParcial());
        Console.WriteLine("Média Final: " + disciplina1.CalcMediaFinal());
        Console.WriteLine();

        Console.WriteLine("Disciplina Semestral: " + disciplina2.GetNome());
        Console.WriteLine("Média Parcial: " + disciplina2.CalcMediaParcial());
        Console.WriteLine("Média Final: " + disciplina2.CalcMediaFinal());
    }
}