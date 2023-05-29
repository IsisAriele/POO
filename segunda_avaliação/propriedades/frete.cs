using System;

namespace Frete
{
    class Frete{
        private double distancia, peso;

        public double Distancia{
            get => distancia;
            set { if(value > 0) distancia = value; } 
        }
        public double Peso{
            get => peso;
            set { if(value > 0) peso = value; }
        }
        public double ValorFrete{
            get {
                return (peso * distancia) / 100;
            }
        }

        public override string ToString(){
            return $"Distancia: {distancia} Peso: {peso} Valor do Frete: {ValorFrete}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Frete frete1 = new Frete{Distancia = 5, Peso = 1};
            Frete frete2 = new Frete{Distancia = 5000, Peso = 70};
            Frete frete3 = new Frete{Distancia = 45, Peso = 95};

            Console.WriteLine(frete1);
            Console.WriteLine(frete2);
            Console.WriteLine(frete3);
        }
    }
}