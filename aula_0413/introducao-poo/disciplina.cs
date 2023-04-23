using System;
class Disciplina {
    public string nome;
    public double nota1, nota2, nota3, nota4;
    public double notaFinal;
    public double mediaAluno() {
        double mediaObtida = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / 10; 
        if(mediaObtida >= 60) {
            return mediaObtida;
        } else {
            return (mediaObtida + notaFinal) / 2;
        }
    }
}
class Program {
    public static void Main(string[] args) {
        Disciplina notaAluno;
        notaAluno = new Disciplina();
        notaAluno.nome = Console.ReadLine();
        notaAluno.nota1 = double.Parse(Console.ReadLine());
        notaAluno.nota2 = double.Parse(Console.ReadLine());
        notaAluno.nota3 = double.Parse(Console.ReadLine());
        notaAluno.nota4 = double.Parse(Console.ReadLine());
        notaAluno.notaFinal = double.Parse(Console.ReadLine());

        Console.WriteLine($"A media do aluno na disciplina de {notaAluno.nome} foi: {notaAluno.mediaAluno()}");
    }
}