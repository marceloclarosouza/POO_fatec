namespace aula30_03_21
{
    public class Criptografia
    {
        public int dado;
        public int Dado
        {
            get
            {
                int valorDescriptografado;
                valorDescriptografado = dado/30;
                return valorDescriptografado;
            }
            set
            {
                int valorCriptografado;
                valorCriptografado = value * 30;
                dado = valorCriptografado;
            }
        }        
    }
}