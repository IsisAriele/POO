class MainClass
{
    public static void Main()
    {
        Pessoa a = new Pessoa("a", 20);
        Pessoa b = new Pessoa("b", 45);
        Pessoa c = new Pessoa("c", 45);
        a.SetFiliacao(b, c);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
class Pessoa
{
    private string nome;
    private int idade;
    private Pessoa pai;
    private Pessoa mae;
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
    public void SetFiliacao(Pessoa pai, Pessoa mae)
    {
        this.pai = pai;
        this.mae = mae;
    }
    public override string ToString()
    {
        return $"{nome} {idade} {pai} {mae}";
    }
}


// a) Mostrar as variáveis nas memórias Stack do método Main e Heap após a execução das quatro primeiras linhas
// do método Main.

// stack do método Main
// |----------------|
// |      a         |
// |----------------|
// |      b         |
// |----------------|
// |      c         |
// |----------------|

//heap
// Pessoa a:
// |------------------------|
// |        nome = "a"      |
// |------------------------|
// |        idade = 20      |
// |------------------------|
// |        pai = null      |
// |------------------------|
// |        mae = null      |
// |------------------------|

// Pessoa b:
// |------------------------|
// |        nome = "b"      |
// |------------------------|
// |        idade = 45      |
// |------------------------|
// |        pai = null      |
// |------------------------|
// |        mae = null      |
// |------------------------|

// Pessoa c:
// |------------------------|
// |        nome = "c"      |
// |------------------------|
// |        idade = 45      |
// |------------------------|
// |        pai = null      |
// |------------------------|
// |        mae = null      |
// |------------------------|