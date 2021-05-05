using System;
namespace aula_construtores
{
    public class RepresentanteComercial
    {
        private string nome;
        private int cnpj;
        private float comissao;
        private float bonus;
        private float porcentagem;
        private int dias;

        public RepresentanteComercial (){

            
        }

        public RepresentanteComercial (string nome, int cnpj, float comissao){

            this.nome = nome;
            this.cnpj = cnpj;
            this.comissao = comissao;
            
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }

        public float Comissao
        {
            get
            {
                return comissao;
            }
            set
            {
                comissao = value;
            }
        }
        public float Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

         public float Porcentagem
        {
            get
            {
                return porcentagem;
            }
            set
            {
                porcentagem = value;
            }
        }

         public int Dias
        {
            get
            {
                return dias;
            }
            set
            {
                dias = value;
            }
        }


        public void calcularBonus(float comissao, float porcentagem){
            bonus = (comissao*porcentagem)/100;

        }

        public void calcularBonus(float comissao, float porcentagem, int dias){
            
            float valordia = comissao/30;
            bonus = valordia*dias;

        }

        public void imprimirDados(){
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CNPJ: " + cnpj);
            Console.WriteLine("Comissão: " + comissao.ToString("N2"));
            Console.WriteLine("Bonus: " + bonus.ToString("N2"));
        }

        internal void calcularBonus(float v)
        {
            throw new NotImplementedException();
        }
    }
}