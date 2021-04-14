using System;

namespace aula_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Financeiro o_CtrlCaixa = new Financeiro();

            o_CtrlCaixa.SaldoCaixa = 5000.00F;

            //==========================================================
            classes.Claculadora o_Calculadora = new classes.Claculadora();
            int vInt1 = 100;
            int vInt2 = 200;
            float vFloat1 = 50.50f;
            float somaRetorno;            

            o_Calculadora.soma(10, 10);
            o_Calculadora.soma(vInt1, vInt2);

            o_Calculadora.soma(vFloat1, vInt1);
            o_Calculadora.soma(vFloat1, vInt1, 100.4f);

            somaRetorno = o_Calculadora.soma(vFloat1, vFloat1, vFloat1);
            Console.WriteLine("Total: " + somaRetorno);
        }
    }
}
