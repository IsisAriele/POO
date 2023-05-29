using System;
class Program {
    public static void Main(){
        Console.WriteLine("Digite seu nome:");
        string cliente = Console.ReadLine();
        Console.WriteLine("Digite a data de premiação:");
        DateTime data = DateTime.Parse(Console.ReadLine());
        Premio p = new Premio(cliente, data);
        object premio;
        Console.WriteLine("Digite 1 para escolher o vale compras e 2 para escolher o produto");
        string escolha = Console.ReadLine();
        if(escolha == "1"){
            premio = new ValeCompras(DateTime.Now.AddDays(30), 1000.0m); //30 dias a validade e o vale compras no valor de 200 reais;
            p.SetPremio(premio);
        } else if(escolha == "2"){
            premio = new Produto("celular", 1000.0m);
            p.SetPremio(premio);
        }
        Console.WriteLine(p.GetPremio());
    } 
}
class Premio{
    private string cliente;
    private DateTime data;
    private object premio;

    public Premio(string c, DateTime d){ //nome do cliente e data de premiação
        if(!string.IsNullOrEmpty(c)){
            cliente = c;
        } else {
            throw new ArgumentOutOfRangeException();
        }
        if(d <= DateTime.Now) {
            data = d;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void SetPremio(object p){
        premio = p;
    }

    public object GetPremio(){
        return premio;
    }

    public override string ToString()
    {
        return $"{cliente} | {data} | {premio}";
    }
}

class ValeCompras{
    private DateTime dataValidade;
    private decimal valor;

    public ValeCompras(DateTime d, decimal v){
        dataValidade = d;
        valor = v;
    }
     public override string ToString()
    {
        return $"{dataValidade} | {valor}";
    }
}

class Produto{
    private string descricao;
    private decimal valor;

    public Produto(string d, decimal v){
        descricao = d;
        valor = v;
    }
    
    public override string ToString()
    {
        return $"{descricao} | {valor}";
    }
}

