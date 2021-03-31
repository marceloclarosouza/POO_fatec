using System;

namespace aula30_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia a classe (cria o objeto cachorro)
            Animal o_Cachorro = new Animal();

            //informa os valores dos atributos
            o_Cachorro.nome = "Luffy";
            o_Cachorro.idade = 2;

            //Obtem os valores dos atributos
            Console.WriteLine("Nome: " + o_Cachorro.nome);
            Console.WriteLine("Idade: " + o_Cachorro.idade);
            Console.WriteLine("\n");

            //Instancia a classe (cria o objeto gato)
            Animal o_Gato = new Animal();

            //informa os valores dos atributos
            o_Gato.nome = "Pacato";
            o_Gato.idade = 10;

            //Obtem os valores dos atributos
            Console.WriteLine("Nome: " + o_Gato.nome);
            Console.WriteLine("Idade: " + o_Gato.idade);
            Console.WriteLine("\n");

            Bebe o_Bebe1 = new Bebe();
            o_Bebe1.nome = "Luffy";
            o_Bebe1.data_nascimento = "16/09/2018";
            o_Bebe1.peso = 2.5f;
            o_Bebe1.altura = 0.45f;
            o_Bebe1.nome_mae = "Panceta";
            o_Bebe1.medico = "Elaine";

            Console.WriteLine("Nome: "+o_Bebe1.nome);
            Console.WriteLine("Nascimento: "+o_Bebe1.data_nascimento);
            Console.WriteLine("Peso: "+o_Bebe1.peso);
            Console.WriteLine("Altura: "+o_Bebe1.altura);
            Console.WriteLine("Mae: "+o_Bebe1.nome_mae);
            Console.WriteLine("Medico: "+o_Bebe1.medico);
            Console.WriteLine("\n");

            Mae o_Mae1 = new Mae();
            o_Mae1.nome = "Panceta" ;
            o_Mae1.endereco = "Rua Joao Perone";
            o_Mae1.telefone = "16999999999";
            o_Mae1.data_nascimento = "25/05/2016";

            Console.WriteLine("Nome: "+o_Mae1.nome);
            Console.WriteLine("Enereço: "+o_Mae1.endereco);
            Console.WriteLine("Telefone: "+o_Mae1.telefone);
            Console.WriteLine("Nascimento: "+o_Mae1.data_nascimento);
            Console.WriteLine("\n");

            Medico o_Medico1 = new Medico();
            o_Medico1.nome = "Elaine";
            o_Medico1.CRM = 132165465465464;
            o_Medico1.telefone = "126565656565";
            o_Medico1.especialidade = "Veterinario";

            Console.WriteLine("Nome: "+o_Medico1.nome);
            Console.WriteLine("CRM: "+o_Medico1.CRM);
            Console.WriteLine("Telefone: "+o_Medico1.telefone);
            Console.WriteLine("Especialidade: "+o_Medico1.especialidade);
            Console.WriteLine("\n");

            //Encapsulamento
            try
            {
                Usuario o_Ususario1 = new Usuario();

                o_Ususario1.Nome = "Maria";
                o_Ususario1.AnoNasc = 1980;
                o_Ususario1.Senha = "123456";

                Console.WriteLine("Nome: "+ o_Ususario1.Nome);
                Console.WriteLine("Data Nasc: "+ o_Ususario1.AnoNasc);
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Nasc: "+ ex.Message, "Tratamento de Erro");
                Console.WriteLine("\n");
            }

            Criptografia o_Senha = new Criptografia();
            o_Senha.Dado = 100;
            Console.WriteLine("Dado: " + o_Senha.Dado);
            Console.WriteLine("Dado Criptografado: " + o_Senha.dado);
            Console.WriteLine("\n");


            //Exercicio Notas Alunos
            try
            {
                Aluno o_Aluno1 = new Aluno();

                o_Aluno1.Nome = "Nota p1 inválida";
                o_Aluno1.Codigo = 134654549;
                o_Aluno1.P1 = 2.5f;
                o_Aluno1.P2 = 7.4f;

                Console.WriteLine("Nome: "+ o_Aluno1.Nome);
                Console.WriteLine("Codigo: "+ o_Aluno1.Codigo);
                Console.WriteLine("P1: "+ o_Aluno1.P1);
                Console.WriteLine("P2: "+ o_Aluno1.P2);
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nome: "+ ex.Message, "Nome inválido");
                Console.WriteLine("Codigo: "+ ex.Message, "Codigo invalido");
                Console.WriteLine("P1: "+ ex.Message, "Nota p1 inválida");
                Console.WriteLine("P2: "+ ex.Message, "Nota p2 inválida");
                Console.WriteLine("\n");
            }

        }
    }
}
