using System;
class Disciplina {
    public string nome;
    public double nota1, nota2, nota3, nota4;
    public double notaFinal;

    public double mediaParcial(double n1, double n2, double n3, double n4){
        return ((n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3)) / 10; 
    }
    public double mediaFinal(double n, double nf) {
        return (n + nf) / 2;
    }
}
class Program {
    public static void Main(string[] args) {
        Disciplina notaAluno;
        notaAluno = new Disciplina();
        Console.WriteLine("Digite o nome da disciplina para visualização da média:");
        notaAluno.nome = Console.ReadLine();
        Console.WriteLine("Digite as 4 notas do semestre:");
        notaAluno.nota1 = double.Parse(Console.ReadLine());
        notaAluno.nota2 = double.Parse(Console.ReadLine());
        notaAluno.nota3 = double.Parse(Console.ReadLine());
        notaAluno.nota4 = double.Parse(Console.ReadLine());
        

        double mediaParcialDoAluno = notaAluno.mediaParcial(notaAluno.nota1, notaAluno.nota2, notaAluno.nota3, notaAluno.nota4);
        if(mediaParcialDoAluno >= 60){
            Console.WriteLine($"Você foi aprovado na disciplina {notaAluno.nome} com a média {mediaParcialDoAluno}.");
        } else {
            Console.WriteLine("Você foi para recuperação, digite a nota da prova final:");
            notaAluno.notaFinal = double.Parse(Console.ReadLine());
            double mediaFinalDoAluno = notaAluno.mediaFinal(mediaParcialDoAluno, notaAluno.notaFinal);
            if(mediaFinalDoAluno >= 60) {
                Console.WriteLine($"Você foi aprovado! Sua média final foi {mediaFinalDoAluno}.");
            } else {
                Console.WriteLine($"Você foi reprovado! Sua média final foi {mediaFinalDoAluno}.");
            }
        }
    }
}