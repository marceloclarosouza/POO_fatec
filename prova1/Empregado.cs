using System;
namespace prova1
{
    public class Empregado
    {
        private string nome;
        private string sobrenome;
        private float salario;
        private float aumento;

        public Empregado (string nome, string sobrenome, float salario, float aumento)
        {

        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salario = salario;
        this.aumento = aumento;

        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public float Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (salario < 0)
                {
                    salario = 0.0f;
                }
                salario = value;
            }
        }

        public float Aumento
        {
            get
            {
                return aumento;
            }
            set
            {
                aumento = value;
            }
        }

        public float salarioAnual()
        {
            float salarioanual;
            salarioanual = this.salario*12;
            return salarioanual;

        }

        public float salarioAnual10pc()
        {
            float salarioaumento;
            salarioaumento = (this.salario + this.salario*(this.aumento/100))*12;
            return salarioaumento;      

        }

        public void imprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Salario mensal: " + salario);
            Console.WriteLine("Salario anual: " + salarioAnual());
            Console.WriteLine("Salario anual + 10%: " + salarioAnual10pc());
        }
    }
}