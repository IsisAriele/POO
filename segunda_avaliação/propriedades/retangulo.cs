using System;

class Retangulo{
    private double b, h;
    public double Base{
        get {return b;}
        set {if( value > 0) b = value;}
    }

    public double Altura{
        get{return h;}
        set{if(value>0) h = value;}
    }

    public double Area {
        get {
            return b * h;
        }
    }

    public double Diagonal {
        get{
            return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }
    }

    public override string ToString()
    {
        return $"A base é : {b} | A altura é: {h}";
    }
}

class Program {
    public static void Main(){
        Retangulo x = new Retangulo();
        x.Base = 10;
        x.Altura = 20;
        Console.WriteLine(x.Area);
        Console.WriteLine(x.Diagonal);
        Console.WriteLine(x);
    }
}