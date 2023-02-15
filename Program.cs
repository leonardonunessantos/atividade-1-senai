using System; // Biblioteca para entrada e saída de dados
namespace Atividade1
{
    // Sempre precisamos utilizar a estrutura abaixo: Procura o Main para executar
    class Program
    {

        static void Main(string[] args)
        {

            float val_pag;
            Console.WriteLine("Informe o Nome:");
            string var_nome = Console.ReadLine();
            // ReadLine sempre salva como string, então precisa da conversão em caso de dados numéricos
            Console.WriteLine("Informe o Endereço:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Informe o tipo: F (Pessoa Física) ou J (Pessoa Jurídica)");
            string var_tipo = Console.ReadLine();
            var_tipo = var_tipo.ToUpper();

            // Tratando entradas incorretas
            while (var_tipo != "F" & var_tipo != "J" & var_tipo != "C")
            {

                Console.WriteLine("Tipo incorreto, favor inserir apenas: F (Pessoa Física), J (Pessoa Jurídica) ou C para Cancelar");
                var_tipo = Console.ReadLine().ToUpper();

            }

            if(var_tipo == "F")
            {

                // Pessoa Física
                // Tipo           Com base na classe
                PessoaFisica pf = new PessoaFisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                // Como vamos receber um número, precisamos converter
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa Física -----");
                Console.WriteLine("Nome ........: " + pf.nome);
                Console.WriteLine("Endereço ....: " + pf.endereco);
                Console.WriteLine("CPF .........: " + pf.cpf);
                Console.WriteLine("RG ..........: " + pf.rg);
                Console.WriteLine("Valor Compra : " + pf.valor.ToString("C")); // Formatando como moeda
                Console.WriteLine("Imposto: ....: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));

            }

            if(var_tipo == "J")
            {

                // Pessoa Física
                // Tipo           Com base na classe
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                // Como vamos receber um número, precisamos converter
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa Jurídica -----");
                Console.WriteLine("Nome ........: " + pj.nome);
                Console.WriteLine("Endereço ....: " + pj.endereco);
                Console.WriteLine("CNPJ ........: " + pj.cnpj);
                Console.WriteLine("IE ..........: " + pj.ie);
                Console.WriteLine("Valor Compra : " + pj.valor.ToString("C")); // Formatando como moeda
                Console.WriteLine("Imposto: ....: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));

            }

            if(var_tipo == "C")
            {
                Console.WriteLine("----- Operação Cancelada -----");
            }


        }

    }

}
