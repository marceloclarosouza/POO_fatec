using System;

namespace aula_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            classes.Livro o_ArteGuerra = new classes.Livro();

            float desconto;

            o_ArteGuerra.Titulo = "A arte da Guerra";
            o_ArteGuerra.Preco = 100.00f;

            o_ArteGuerra.imprimirDados();

            desconto = o_ArteGuerra.efetuarDesconto(10);
            Console.WriteLine("Valor com desconto: "+desconto);

            o_ArteGuerra.efetuarVenda(5);
            o_ArteGuerra.imprimirDados();  
            
            //=========================================================      

            
            classes.Produto o_Prod1 = new classes.Produto();

            float vlrImposto;


            o_Prod1.CodProduto = 100;
            o_Prod1.Descricao = "TV 4k";
            o_Prod1.Preco = 1000.00f;

            Console.WriteLine("Código: " + o_Prod1.CodProduto);
            Console.WriteLine("Descrição: " + o_Prod1.Descricao);
            Console.WriteLine("Preço: " + o_Prod1.Preco.ToString("N2"));

            o_Prod1.aumentarPreco(10);
            vlrImposto = o_Prod1.calcularImposto(10);

            Console.WriteLine("Novo Preço: " + o_Prod1.Preco.ToString("N2"));
            Console.WriteLine("Imposto: " + vlrImposto.ToString("N2"));


        }
    }
}
