using System;
class Viagem {
    public double distancia;
    public string[] tempo;
    public double velocidadeMedia(double distancia, string[] tempo) {
        double horas = double.Parse(tempo[0]);
        double minutos = double.Parse(tempo[1]);
        double horasTotais = (minutos / 60) + horas;
        return distancia / horasTotais;
    }
}
class Program {
    public static void Main(string[] args) {
        Viagem calcViagem;
        calcViagem = new Viagem();
        // calcViagem é uma instância do objeto Viagem criada usando o operador new Viagem().
        calcViagem.distancia = double.Parse(Console.ReadLine());
        calcViagem.tempo = Console.ReadLine().Split(":");
        // calcViagem.distancia e calcViagem.tempo são membros de instância da classe Viagem que são acessados através de uma instância do objeto calcViagem.
        // metodo velocidadeMedia é um metodo de instância da classe viagem.
        Console.WriteLine($"{calcViagem.velocidadeMedia(calcViagem.distancia, calcViagem.tempo)}");
    }
}
