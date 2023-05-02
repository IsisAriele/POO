using System;
class Program {
    public static void Main(){
        Console.WriteLine("Digite o dia, mês e ano");
        int dia = int.Parse(Console.ReadLine());
        int mes = int.Parse(Console.ReadLine());
        int ano = int.Parse(Console.ReadLine());
        Data x = new Data(dia, mes, ano);
        Console.WriteLine(x);

        Console.WriteLine("Agora digite a data no formato dd/mm/aaaa");
        string data2 = Console.ReadLine();
        Data y = new Data(data2);
        Console.WriteLine(y);
    }
}

class Data {
    private int dia, mes, ano;
    public Data(int dia, int mes, int ano){
        //Não foi considerada diferneciação de anos bissextos;
        if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12){
            if((dia > 0 && dia <= 31) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        }
        else if(mes == 4 || mes == 6 || mes == 9 || mes == 11){
            if((dia > 0 && dia <= 30) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        } else {
            if((dia > 0 && dia <= 29) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        }
    }
    public Data(string data){
        string[] valores = data.Split("/");
        int dia = int.Parse(valores[0]);
        int mes = int.Parse(valores[1]);
        int ano = int.Parse(valores[2]);
        this.SetData(dia, mes, ano); //envia para validação dos parâmetros.
    }

    public void SetData(int dia, int mes, int ano){
        if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12){
            if((dia > 0 && dia <= 31) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        }
        else if(mes == 4 || mes == 6 || mes == 9 || mes == 11){
            if((dia > 0 && dia <= 30) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        } 
        else if(mes == 2) {
            if((dia > 0 && dia <= 29) && ano > 1000){
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }
        }
        else{
            throw new ArgumentOutOfRangeException();
        }
    }

    public int GetDia(){
        return dia;
    }
    public int GetMes(){
        return mes;
    }
    public int GetAno(){
        return ano;
    }
    public override string ToString(){
        return $"{dia:00}/{mes:00}/{ano}";
    }
}