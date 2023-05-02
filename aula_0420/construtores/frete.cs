using System;
class Program {
    public static void Main(string[] args){
        Console.WriteLine("Informe a distancia do ponto de origem até o destino:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da carga:");
        double p = double.Parse(Console.ReadLine());
        Frete valor = new Frete(d, p);
        Console.WriteLine($"O valor do frete fica R$ {valor.CalcFrete():f2}.");
        Console.WriteLine(valor);
    }
}

class Frete{
    private double distancia, peso;
    public Frete(double d, double p){
        if(d > 0) {
            distancia = d;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        if(p > 0){
            peso = p;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetDistancia(double d){
        if(d > 0) {
            distancia = d;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }
    public void SetPeso(double p){
        if(p > 0){
            peso = p;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }
    public double GetDistancia(){
        return distancia;
    }

    public double GetPeso(){
        return peso;
    }

    public double CalcFrete(){
        return (peso * distancia) / 100; //divisão para passar conversão cent -> real;
    }
    
    public override string ToString(){
        return $"Distância = {distancia} | Peso = {peso}";
    }
}