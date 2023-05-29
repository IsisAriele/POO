using System;
class Colecao{
    private object[] itens;
    private int max, numItens;
    public Colecao(int max){
        this.max = max;
        this.itens = new object[max];
        this.numItens = 0;
    }

    public void Inserir(object item){
        if (numItens < max){
            this.itens[numItens] = item;
            numItens++;
        } else {
            Console.WriteLine("A coleção atingiu o número máximo de elementos.");
        }
    }

    public object[] Listar(){
        object[] lista = new object[numItens];
        Array.Copy(itens, lista, numItens); //copia os elementos do vetor "itens" para o vetor lista + número de elementos a serem copiados (numItens pode ser substituido por lista.Length) 
        return lista;
    }

    public int NumItens(){
        return numItens; //número de elementos inseridos até o momento
    }
}

class Program {
    public static void Main(){
        Colecao colecao = new Colecao(5);

        colecao.Inserir("Item 1");
        colecao.Inserir(42);
        colecao.Inserir(new DateTime(2023, 5, 28));

        object[] lista = colecao.Listar();
        Console.WriteLine("Itens na coleção:");
        foreach (object item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Número de itens na coleção: " + colecao.NumItens());
    }
}