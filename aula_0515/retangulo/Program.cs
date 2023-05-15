using System;

namespace retangulo
{
    class Retangulo{
        private double b;
        private double h;

        public double B{
            get => b;
            set => b = value;
        }
        public double H{
            get => h;
            set => h = value;
        }
        public double Area{
            get{
                return b*h;
            }
        }
        public double Diagonal{
            get{
                return Math.Sqrt(Math.Pow(h, 2) +Math.Pow(b, 2));
            }
        }
        public override string ToString(){
            return $"Base: {b} altura: {h} Area: {Area} Diagonal: {Diagonal:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo{B = 10, H = 10};
            Retangulo ret2 = new Retangulo{B = 5, H = 7};
            Retangulo ret3 = new Retangulo{B = 13, H = 8};

            Console.WriteLine(ret1);
            Console.WriteLine(ret2);
            Console.WriteLine(ret3);
        }
    }
}
