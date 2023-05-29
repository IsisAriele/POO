using System;
class Triangulo{
    private double b, h;
    public double Base {
        get { return b; }
        set {
            if (value > 0) b = value;
        }
    }
    public double Altura {
        get { return h; }
        set {
            if (value > 0) h = value;
        }
    }
    public double Area {
        get {
            return b * h / 2;
        }
    }
}

class MainClass {
    public static void Main () {
        Triangulo x = new Triangulo();
        x.Base = 10;
        x.Altura = 20;
        Console.WriteLine(x.Base);
        Console.WriteLine(x.Altura);
        Console.WriteLine(x.Area);
    }
}