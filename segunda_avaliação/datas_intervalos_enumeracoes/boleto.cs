using System;

    enum Pagamento{EmAberto, PagoParcial, Pago}

    class Boleto{
        private string codBarras;
        private DateTime dataEmissao, dataVencimento, dataPagto;
        private decimal valorBoleto, valorPago;
        private Pagamento situacaoPagamento;

        public Boleto(string cod, DateTime emissao, DateTime venc, decimal valor){
            if(!string.IsNullOrEmpty(cod)){
                codBarras = cod;
            } else {
                throw new ArgumentOutOfRangeException();
            }

            if(emissao <= DateTime.Now){
                dataEmissao = emissao;
            } else {
                throw new ArgumentOutOfRangeException();
            }

            dataVencimento = venc;
            valorBoleto = valor;

        }

        public void Pagar(decimal valorPago){
            if(valorPago == 0){
                this.situacaoPagamento = Pagamento.EmAberto;
                this.valorPago = valorPago;
            } else if(valorPago != 0 && valorPago < valorBoleto){
                this.situacaoPagamento = Pagamento.PagoParcial;
                this.valorPago = valorPago;
            } else if(valorPago == valorBoleto){
                this.situacaoPagamento = Pagamento.Pago;
                this.valorPago = valorPago;
            } else{
                throw new ArgumentOutOfRangeException();
            }
        }

        public Pagamento Situacao(){
            return this.situacaoPagamento;
        }

        public override string ToString()
        {
            return $"Código de barras: {codBarras} | Data da emissão: {dataEmissao} | Data de vencimento: {dataVencimento} | Data de pagamento:  {dataPagto} | Valor do boleto: {valorBoleto} | Valor pago: {valorPago} | Situação de pagamento: {situacaoPagamento}";
        }

    }
    class Program{
        public static void Main(){
            Boleto b = new Boleto("524214", DateTime.Now, DateTime.Now.AddDays(15), 200.0m);
            Console.WriteLine("Digite o valor do seu pagamento e acompanhe a situação do seu boleto:");
            decimal v = decimal.Parse(Console.ReadLine());
            b.Pagar(v);
            Console.WriteLine(b.Situacao());
            Console.WriteLine(b);
        }
    }