using System;

class Program {
    public static void Main(string[] args){
        Disciplina nota = new Disciplina();
        Console.WriteLine("Digite o nome da disciplina para visualização da média:");
        nota.SetNome(Console.ReadLine());
        Console.WriteLine("Digite suas 4 notas desse semestre:");
        nota.SetNota1(int.Parse(Console.ReadLine()));
        nota.SetNota2(int.Parse(Console.ReadLine()));
        nota.SetNota3(int.Parse(Console.ReadLine()));
        nota.SetNota4(int.Parse(Console.ReadLine()));
        if(nota.CalcMediaParcial() >= 60){
            Console.WriteLine($"Você foi aprovado nesta disciplina com a média {nota.CalcMediaParcial()}");
        } else {
            Console.WriteLine("Você foi para recuperação. Informe a nota da prova final:");
            nota.SetNotaFinal(int.Parse(Console.ReadLine()));

            if(nota.CalcMediaFinal() >= 60){
                Console.WriteLine($"Você foi aprovado na disciplina com a média final de {nota.CalcMediaFinal()}");
            } else {
                Console.WriteLine($"Você foi reprovado nesta disciplina. Sua média final foi {nota.CalcMediaFinal()}.");
            }
        }
        

    }
}

class Disciplina {
    private string nome;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaFinal;

    public void SetNome(string s) {
        if(!string.IsNullOrEmpty(s)){
            this.nome = s;
        } else {
            throw new ArgumentOutOfRangeException("O nome da disciplina não pode ser nulo ou vazio.");
        }
    }
    public void SetNota1(int n) {
        if(n >=0) this.nota1 = n;
    }
    public void SetNota2(int n) {
        if(n >=0) this.nota2 = n;
    }
    public void SetNota3(int n) {
        if(n >=0) this.nota3 = n;
    }
    public void SetNota4(int n) {
        if(n >=0) this.nota4 = n;
    }
    public void SetNotaFinal(int n) {
        if(n >=0) this.notaFinal = n;
    }
    public string GetNome() {
        return nome;
    }
    public int GetNota1() {
        return nota1;
    }
    public int GetNota2() {
        return nota2;
    }
    public int GetNota3() {
        return nota3;
    }
    public int GetNota4() {
        return nota4;
    }
    public int GetNotaFinal() {
        return notaFinal;
    }
// ======================================
    public int CalcMediaParcial() {
        return ((this.nota1 * 2) + (this.nota2 * 2) + (this.nota3 * 3) + (this.nota4 * 3)) / 10; 
    }

    public int CalcMediaFinal() {
        return (this.CalcMediaParcial() + this.notaFinal) / 2;
    }
}