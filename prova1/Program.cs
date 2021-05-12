using System;

namespace prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6
            Invoice o_Invoice = new Invoice(
                11189, "Produto nao perecivel", 20, 21.35f
            );

            o_Invoice.imprimirDados();

            Console.WriteLine("\n\n");


            //Exercicio7
            Empregado o_Empregado1 = new Empregado (
                "Karl", "Max", 1435.2f, 10.0f);

            Empregado o_Empregado2 = new Empregado (
                "Frederich", "Engels", 574.23f, 10.0f
            );

            o_Empregado1.imprimirDados();
            Console.WriteLine("\n");
            o_Empregado2.imprimirDados();

        }
    }
}