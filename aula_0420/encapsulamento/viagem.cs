using System;
class Program {
    public static void Main(string[] args) {
        Viagem velocidadeMedia = new Viagem();
        Console.WriteLine("Informe a distância da viagem:");
        velocidadeMedia.SetDistancia(double.Parse(Console.ReadLine()));
        Console.WriteLine("Informe o tempo da viagem:");
        velocidadeMedia.SetTempo(double.Parse(Console.ReadLine()));

        Console.WriteLine($"A velocidade média da sua viagem foi de {velocidadeMedia.VelocidadeMedia():f1} km/h.");
    }
}

class Viagem {
    private double distancia, tempo;
    public void SetDistancia(double d){
        this.distancia = d;
    }
    public void SetTempo(double t){
        this.tempo = t;
    }

    public double GetDistancia(){
        return distancia;
    }
    public double GetTempo(){
        return tempo;
    }

    public double VelocidadeMedia(){
        return this.distancia / this.tempo;
    }
}