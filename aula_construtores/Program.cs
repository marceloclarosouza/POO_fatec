using System;

namespace aula_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Financeiro o_CtrlCaixa = new Financeiro();

            // o_CtrlCaixa.SaldoCaixa = 5000.00F;

            // //==========================================================
            // classes.Claculadora o_Calculadora = new classes.Claculadora();
            // int vInt1 = 100;
            // int vInt2 = 200;
            // float vFloat1 = 50.50f;
            // float somaRetorno;            

            // o_Calculadora.soma(10, 10);
            // o_Calculadora.soma(vInt1, vInt2);

            // o_Calculadora.soma(vFloat1, vInt1);
            // o_Calculadora.soma(vFloat1, vInt1, 100.4f);

            // somaRetorno = o_Calculadora.soma(vFloat1, vFloat1, vFloat1);
            // Console.WriteLine("Total: " + somaRetorno);



            //========================================================================
            // Carpete o_CarpIsrael = new Carpete();
            // Carpete o_CarpArabe = new Carpete(3);
            // Carpete o_CarpPersia = new Carpete(4, 4);

            // Console.WriteLine("Área Carpete Israel: " + o_CarpIsrael.Area + " m2");
            // Console.WriteLine("Área Carpete Árabe: " + o_CarpArabe.Area + " m2");
            // Console.WriteLine("Área Carpete Pérsia: " + o_CarpPersia.Area + " m2");

            // Carpete o_CarpRusso = new Carpete();

            // o_CarpRusso.encomendarCarpete(3.5F, 5.5F);

            // Carpete o_CarpJapones = new Carpete();

            // o_CarpJapones.encomendarCarpete(5, 10);

            // Console.WriteLine("Área Carpete Russo: " + o_CarpRusso.Area + " m2");
            // Console.WriteLine("Área Carpete Japonês: " + o_CarpJapones.Area + " m2");

            //======================================================================

            RepresentanteComercial o_Rep1 = new RepresentanteComercial();
            RepresentanteComercial o_Rep2 = new RepresentanteComercial("Marcelo", 1234323434, 10.5f);
         
            o_Rep1.imprimirDados();
            o_Rep2.imprimirDados();

            RepresentanteComercial o_MariaME = new RepresentanteComercial();

            o_MariaME.Nome = "Maria ME";
            o_MariaME.Cnpj = 7890007;
            o_MariaME.Comissao = 6000F;

            o_MariaME.calcularBonus(49.9F, 10);
            o_MariaME.imprimirDados();

            o_MariaME.calcularBonus(10F, 20, 5);
            o_MariaME.imprimirDados();



        
        }
    }
}
