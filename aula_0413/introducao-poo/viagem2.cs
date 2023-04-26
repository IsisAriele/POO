using System;
class Viagem {
    public double distancia;
    public string[] tempo;
    public Viagem(double d, string[] t) {
        this.distancia = d;
        this.tempo = t;
    }
    public double velocidadeMedia() {
        double horas = double.Parse(this.tempo[0]);
        double minutos = double.Parse(this.tempo[1]);
        double horasTotais = (minutos / 60) + horas;
        return this.distancia / horasTotais;
    }
}
class Program {
    public static void Main(string[] args) {
        double distancia = double.Parse(Console.ReadLine());
        string[] tempo = Console.ReadLine().Split(":");
        Viagem calcViagem;
        calcViagem = new Viagem(distancia, tempo);
        // metodo velocidadeMedia é um metodo de instância da classe viagem.
        Console.WriteLine($"{calcViagem.velocidadeMedia()}");
    }
}
