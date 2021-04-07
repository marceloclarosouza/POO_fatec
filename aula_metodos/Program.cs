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

            
        }
    }
}
