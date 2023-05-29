using System;
using System.Collections;

class QuadroMedalhas
{
    private Pais[] paises;
    private int count;

    public QuadroMedalhas(int capacidade)
    {
        paises = new Pais[capacidade];
        count = 0;
    }

    public void Inserir(Pais p)
    {
        if (count < paises.Length)
        {
            paises[count] = p;
            count++;
        }
        else
        {
            Console.WriteLine("Capacidade máxima do quadro de medalhas atingida.");
        }
    }

    public Pais[] Listar()
    {
        Array.Sort(paises, 0, count); //ordena o array paises a partir do índice 0 até o índice count
        return paises;
    }
}

class Pais : IComparable
{
    private string nome;
    private int ouro, prata, bronze;

    public Pais(string nome, int ouro, int prata, int bronze)
    {
        this.nome = nome;
        this.ouro = ouro;
        this.prata = prata;
        this.bronze = bronze;
    }

    public int CompareTo(object obj)
    {
        Pais outroPais = (Pais)obj;

        if (ouro != outroPais.ouro)
        {
            return outroPais.ouro.CompareTo(ouro); // Ordena por número de medalhas de ouro (decrescente)
        }
        else if (prata != outroPais.prata)
        {
            return outroPais.prata.CompareTo(prata); // Ordena por número de medalhas de prata (decrescente)
        }
        else if (bronze != outroPais.bronze)
        {
            return outroPais.bronze.CompareTo(bronze); // Ordena por número de medalhas de bronze (decrescente)
        }
        else
        {
            return nome.CompareTo(outroPais.nome); // Ordena por ordem alfabética do nome (crescente)
        }
    }

    public override string ToString()
    {
        return $"{nome} - Ouro: {ouro}, Prata: {prata}, Bronze: {bronze}";
    }
}

class Program
{
    public static void Main()
    {
        QuadroMedalhas quadro = new QuadroMedalhas(10);

        // Inserir países
        quadro.Inserir(new Pais("Brasil", 10, 5, 2));
        quadro.Inserir(new Pais("Estados Unidos", 15, 10, 5));
        quadro.Inserir(new Pais("China", 12, 8, 6));
        quadro.Inserir(new Pais("Japão", 8, 10, 12));
        quadro.Inserir(new Pais("Rússia", 6, 10, 10));

        // Listar países do quadro de medalhas
        Pais[] paises = quadro.Listar();
        foreach (Pais pais in paises)
        {
            Console.WriteLine(pais);
        }
    }
}