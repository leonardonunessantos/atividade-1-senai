namespace Atividade1

{

    public class Clientes
    {
        public string nome {get; set;}
        public string endereco {get; set;}

        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        // Criando o método
        // virtual: quer dizer que o método pode ser reescrito por uma subclasse. PS. Abstract não permite.
        // void: quer dizer que o retorno é indeterminado, não possui retorno.
        public virtual void Pagar_Imposto(float v)
        {
            // this. serve para acessar um atributo da classe
            this.valor = v;
            this.valor_imposto = this.valor * 10/100;
            this.total = this.valor + this.valor_imposto;
        }
    }

}
