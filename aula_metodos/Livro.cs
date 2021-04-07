namespace aula_metodos.classes
{
    public class Livro
    {
        private string titulo;
        private float preco;
        private int qtdeEstoque = 50;

        public string Titulo{
            get{
                return titulo;
            }
            set{
                titulo = value;
            }
        }
        public float Preco{
            get{
                return preco;
            }
            set{
                preco = value;
            }
        }

        public float efetuarDesconto(float porcentagem)
        {
            float desconto;
            desconto = preco - ((preco * porcentagem)/100);
            return desconto;
        }
        public void efetuarVenda(int qtdeVendida)
        {
            qtdeEstoque -= qtdeVendida;
        }
        public void imprimirDados()
        {
            System.Console.WriteLine("=============================");
            System.Console.WriteLine("Titulo: "+titulo);
            System.Console.WriteLine("Preço: "+preco);
            System.Console.WriteLine("Qtde Estoque: "+qtdeEstoque);
            System.Console.WriteLine("=============================");
        }
        
    }
}