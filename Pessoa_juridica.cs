namespace Atividade1
{

    public class PessoaJuridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        // Override: Quer dizer que está sendo reescrito da classe mãe
        public override void Pagar_Imposto(float v)
        {
            // this. serve para acessar um atributo da classe
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }

    }

}