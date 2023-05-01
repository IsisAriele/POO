using System;
class Program {
    public static void Main(string[] args) {
        Cinema x = new Cinema();
        Console.WriteLine("Informe o dia da sessão:");
        x.SetDia(Console.ReadLine());
        Console.WriteLine("Informe o horário da sessão:");
        x.SetHorario(Console.ReadLine());

        Console.WriteLine("Você paga meia? (s ou n)");
        string tipoEntrada = Console.ReadLine();
        double precoIngresso;
        if(tipoEntrada == "s") {
            precoIngresso = x.valorEntradaMeia();
        } else {
            precoIngresso = x.valorEntrada();
        }
        Console.WriteLine($"O valor do seu ingresso fica: {precoIngresso}");
    } 
}

class Cinema {
    private string dia;
    private string horario;
    private int hora, minuto;

    public void SetDia(string dia){
        if(!string.IsNullOrEmpty(dia)) this.dia = dia;
        else throw new ArgumentOutOfRangeException();
    }
    public void SetHorario(string horario) {
        if(!string.IsNullOrEmpty(horario)) this.horario = horario;
        else throw new ArgumentOutOfRangeException();

        string[] horarioQuebrado = this.horario.Split(":");
        this.hora = int.Parse(horarioQuebrado[0]);
        this.minuto = int.Parse(horarioQuebrado[1]);
    }
    public double valorEntrada(){
        double valorBase;
        if(dia == "quarta"){
            valorBase = 8.0;
        }
        else if(dia == "segunda" || dia == "terça" || dia == "quinta") {
            valorBase = 16.0;
        } 
        else {
            valorBase = 20.0;
        }

        if(((this.hora >= 17 && (this.hora <= 23 && this.minuto <= 59)) || (this.hora == 0 && this.minuto == 0)) && (dia != "quarta")){
            valorBase *= 1.5;
        }
        return valorBase;
    }

    public double valorEntradaMeia() {
        if(dia == "quarta"){
            return 8.0;
        } else {
            return this.valorEntrada() / 2;
        }
    }

    public string GetDia(){
        return dia;
    }

    public string GetHorario() {
        return horario;
    }
}