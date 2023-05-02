using System;
class Program{
    public static void Main(){
        int count = 0;
        Pais paisComMaiorDensidade = new Pais("Inicial", 1, 1);

        while(count != 10){
            Console.WriteLine("Informe o nome do país:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a população:");
            int populacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a área:");
            double area = double.Parse(Console.ReadLine());
            Pais pais = new Pais(nome, populacao, area);

            if (pais.Densidade() >= paisComMaiorDensidade.Densidade()) {
                paisComMaiorDensidade = pais;
            }
            count++;
        }

        Console.WriteLine(paisComMaiorDensidade);
    }
}
class Pais{
    private string nome;
    private int populacao;
    private double area;

    public Pais(string n, int p, double a){
        if(!string.IsNullOrEmpty(n)){
            nome = n;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(p > 0){
            populacao = p;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(a > 0){
            area = a;
        } else {
            throw new ArgumentOutOfRangeException();
        }

    }
    public void SetNome(string nome){
        if(!string.IsNullOrEmpty(nome)){
           this.nome = nome;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetPopulacao(int populacao){
        if(populacao > 0){
            this.populacao = populacao;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }
    
    public void SetArea(double area){
        if(area > 0){
            this.area = area;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public string GetNome(){
        return nome;
    }
    public int GetPopulacao(){
        return populacao;
    }
    public double GetArea(){
        return area;
    }

    public double Densidade(){
        return populacao / area;
    }

    public override string ToString(){
        return $"Nome: {nome} | População: {populacao} | Área: {area}";
    }
}