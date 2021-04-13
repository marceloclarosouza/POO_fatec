namespace aula_metodos.classes
{
    public class Produto
    {
        public int codProduto;
        public string descricao;
        public float preco;

        public int CodProduto{
            get{return codProduto;}
            set{codProduto = value;}
        }
         public string Descricao{
            get{return descricao;}
            set{descricao = value;}
        }
        public float Preco{
            get{return preco;}
            set{preco = value;}
        }


        // Metodo Aumentar Preco Livro

        public void aumentarPreco(float porcentagem)
        {
            float vlrAumento;

            vlrAumento = preco * (porcentagem / 100);

            preco += vlrAumento;
        }
        // Calcular o Imposto

        public float calcularImposto(float porcentagem)
        {
            float imposto;

            imposto = preco * (porcentagem / 100);

            return imposto;
        }
        public void imprimirDados()
        {
            System.Console.WriteLine("Código Produto: " + codProduto);
            System.Console.WriteLine("Descrição: " + descricao);
            System.Console.WriteLine("Preço: " + preco);
        }

    }
        
}