namespace aula30_03_21
{
    public class Aluno
    {
       public string nome;
       public int codigo;
       public float p1;
       public float p2;

       public int Codigo
       {
           get
           {
               return codigo;
           }
           set
           {
               if (value <= 0)
               {
                   throw new System.Exception("Codigo invalido");
               }
               codigo = value;
           }


       }

       public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.Exception("Nome inválido");
                }
                nome = value;
            }


        }

        public float P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 0 || value >10)
                {
                    throw new System.Exception("Nota p1 inválida");
                }
                p1 = value;

            }
        }

        public float P2
        {
            get
            {
                return p2;
            }
            set
            {
                if (value < 0 || value >10)
                {
                    throw new System.Exception("Nota p2 inválida");
                }
                p2 = value;
            }
        }        
    }
}