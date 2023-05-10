using System;

class Program {
    public static void Main(){
        Pais[] pais = new Pais[3];
        double paisMaiorDensidade = 0;
        int indicePaisMaiorDensidade = 0;

        for(int i = 0; i < 3; i++){
            Console.WriteLine("Infome o nome do país:");
            string nome = Console.ReadLine();
            Console.WriteLine("Infome a população deste país:");
            int populacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome a área deste país");
            double area = double.Parse(Console.ReadLine());

            pais[i] = new Pais(nome, populacao, area);
            if(pais[i].Densidade() >= paisMaiorDensidade){
                paisMaiorDensidade = pais[i].Densidade();
                indicePaisMaiorDensidade = i;
            }
        }
        Console.WriteLine(pais[indicePaisMaiorDensidade]);

    }
}

class Pais {
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
         if(this.populacao > 0){
            this.populacao = populacao;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetArea(double area){
        if(this.area > 0){
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