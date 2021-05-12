using System;
namespace prova1
{
    public class Invoice
    {
        private int numItem;
        private string numDescricao;
        private int qtdItem;
        private float precoItem;

        public Invoice(int numItem, string numDescricao, int qtdItem, float precoItem)
        {

            this.numItem = numItem;
            this.numDescricao = numDescricao;
            this.qtdItem = qtdItem;
            this.precoItem = precoItem;

        }

        public int NumItem
        {
            get
            {
                return numItem;
            }
            set
            {
                numItem = value;
            }
        }

         public string NumDescricao
        {
            get
            {
                return numDescricao;
            }
            set
            {
                numDescricao = value;
            }
        }

         public int QtdItem
        {
            get
            {
                return qtdItem;
            }
            set
            {
                if (qtdItem < 0)
                    {
                        qtdItem = 0;
                    }
                qtdItem = value;
            }
        }

         public float PrecoItem
        {
            get
            {
                return precoItem;
            }
            set
            {
                if (precoItem < 0)
                    {
                        precoItem = 0.0f;
                    }
                precoItem = value;
            }
        }

        public float getInvoiceAmount ()
        {
            float valorFatura;
            valorFatura = qtdItem * precoItem;
            return valorFatura;
    
        }

        public void imprimirDados()
        {
            Console.WriteLine("Numero do Item: " + numItem);
            Console.WriteLine("Descriçao: " + numDescricao);
            Console.WriteLine("Quantidade: " + qtdItem);
            Console.WriteLine("Preço do Item: " + precoItem);
            Console.WriteLine("Fatura: " + getInvoiceAmount());

        }
        
    }
}