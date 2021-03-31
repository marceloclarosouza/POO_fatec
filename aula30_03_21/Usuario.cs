using System;
using System.Linq;

namespace aula30_03_21
{
    public class Usuario
    {
        //Atributos (estado)
        private string nome;
        private string senha;
        private int anoNasc;

        public string Nome{ get=> nome; set => nome = value;}

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (value.Count() < 6)
                {
                    throw new System.Exception("Senha inválida!");
                }
                senha = value;
            }

        }

        public int AnoNasc
        {
            get
            {
                return anoNasc;
            }
            set
            {
                if (value < DateTime.Now.Year)
                {
                    throw new System.Exception("Ano de nascimento inválido!");
                }
                anoNasc = value;
            }

        }

        
    }
}