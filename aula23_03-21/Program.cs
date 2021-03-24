using System;
using System.Collections;
using System.Collections.Generic;
//-----------------------------------
// Array
//-----------------------------------

// namespace aula23_03_21
// {
//     class Program
//     {
//      static void Main(string[] args)
//         {
//             ArrayList o_ArlGeral = new ArrayList();

//             o_ArlGeral.Add(3);
//             o_ArlGeral.Add("Joao");
//             o_ArlGeral.Add(DateTime.Now);
//             o_ArlGeral.Add("Joao");
//             o_ArlGeral.Add("Joao");


//             foreach(Object Item in o_ArlGeral)
//             {

//                 Console.WriteLine("Item: " + Item.ToString());

//             }

//             if (o_ArlGeral.Contains("Joao"))
//             {
//                 Console.WriteLine("O Array contem o nome Joao");

//             }
//             else
//             {
//                 Console.WriteLine("O Array nao contem o nome Joao");

//             }

//             o_ArlGeral.Remove("Joao");

//             Console.WriteLine("O pŕimeiro Joao foi removido");


//             foreach (Object Item in o_ArlGeral)
//             {
//                 Console.WriteLine("Item: " + Item.ToString());
//             }

//             o_ArlGeral.Clear();

//             Console.WriteLine("Todos os itens foram removidos");



//         }
//     }
// }

//-------------------------------
//Lista
//-------------------------------

// namespace aula23_03_21
// {
//     class Program
//     {
//      static void Main(string[] args)
//         {
//             List<String> lstStarWars = new List<String>();

//             lstStarWars.Add("Dart Vader");
//             lstStarWars.Add("Hans Solo");
//             lstStarWars.Add("Chewbacca");

//             foreach (string Item in lstStarWars)
//             {
//                 Console.WriteLine("Nomes: " + Item.ToString());
//             }

//                     // Adiciona itens na lista
//             lstStarWars.Add("Leia Organa");
//             lstStarWars.Add("R2D2");
//             lstStarWars.Add("C3PO");
//             lstStarWars.Add("BB8");

//             // Verifica se um elemento se encontra na lista
//             if (lstStarWars.Contains("Han Solo"))
//             {
//                 Console.WriteLine("Han Solo – Positivo Operante");
//             }
//             else
//             {
//                 Console.WriteLine("Han Solo – Inativo");
//             }

//             Console.WriteLine("\n\n\n");

//             // Exibe todos os elementos da lista
//             foreach (Object Item in lstStarWars)
//             {
//             Console.WriteLine("Novos Itens: " + Item.ToString());
//             }


//         }
//     }
// }


// namespace aula23_03_21
// {
//     class Program
//     {
//      static void Main(string[] args)
//         {
//           Hashtable o_hstEmailAluno = new Hashtable();

//           o_hstEmailAluno.Add("jose@a.com.br", "jose");
//           o_hstEmailAluno.Add("luis@a.com.br", "luis");
//           o_hstEmailAluno.Add("pedro@a.com.br", "pedro");

//           foreach (Object Item in o_hstEmailAluno.Keys)
//           {
//               Console.WriteLine("Item.Chave: " + Item.ToString());

//           }

//           o_hstEmailAluno.Remove("jose@a.com.br");

//           foreach (Object Item in o_hstEmailAluno.Keys)
//           {
//               Console.WriteLine("Item.Chave: " + Item.ToString());

//           }

//           if (o_hstEmailAluno.Contains(" luis@a.com.br"))
//           {
//               Console.WriteLine("Contem Luisa");
//           }
//           else
//           {
//              Console.WriteLine("Nao Contem Luisa");
//           }

//           o_hstEmailAluno.Clear();

//             Console.WriteLine("Lista limpa");
//         }
//     }
// }


//________________________________
// Tratamento de erros
//________________________________

// namespace aula23_03_21
// {
//     class Program
//     {
//      static void Main(string[] args)
//         {
//             try
//             {
//                 int x, total;
//                 x = 0 ;

//                 total = 100/x;

//                 Console.WriteLine("Resultado: " +total);

//             }
//             catch (Exception)
//             {
//                 Console.WriteLine("Nao é possível dividir por zero");
//             }
          
//         }
//     }
// }

namespace aula23_03_21
{
    class Program
    {
     static void Main(string[] args)
        {
            int ind = 0;
            Random o_Rand = new Random();
            int vlrRand;

            vlrRand = o_Rand.Next(0, 100);



            for (ind = 0; ind < vlrRand; ind ++)
            {
                Console.WriteLine("Marcelo");
            }

            Console.WriteLine(vlrRand);           
          
        }
    }
}