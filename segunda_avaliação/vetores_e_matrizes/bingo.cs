using System;
class Bingo{
    public int numBolas;
    private int[] bolasSorteadas;
    public int posicaoBolas;

    public void Iniciar(int numBolas){
        if(numBolas > 1){
            this.numBolas = numBolas;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        bolasSorteadas = new int[numBolas];
        posicaoBolas = 0;
    }
    public int Proximo(){
        bool bolaJaSorteada = false;
        Random random = new Random();
        int bolaSorteada = random.Next(1, this.numBolas);

        for (int i = 0; i < bolasSorteadas.Length; i++){
            if(bolasSorteadas[i] == bolaSorteada){
                bolaJaSorteada = true;
                break;
            }
        }

        if (!bolaJaSorteada) {
            bolasSorteadas[posicaoBolas] = bolaSorteada;
            posicaoBolas+= 1;
            return bolaSorteada;
        } else {
            Console.WriteLine($"Número já sorteado: {bolaSorteada}!");
            return -1;
        }
    }
    public int[] Sorteados(){
        return bolasSorteadas;
    }

    public override string ToString()
    {
        return $"{bolasSorteadas}";
    }
}
class Program{
    public static void Main(){
        Bingo x = new Bingo();
        x.Iniciar(5);
        x.Proximo();
        while(x.posicaoBolas < x.numBolas){
            x.Proximo();
        }
        int[] bolasSorteadas = x.Sorteados();
        Console.WriteLine("Números sorteados:");
        foreach (int bola in bolasSorteadas)
        {
            Console.WriteLine(bola);
        }
    }
}