namespace SistemaNotificacaoBancariaPOO
{

    class Program
    {
        static void EnviarEmail(string msg)
        {
            Console.WriteLine("Enviando E-mail: " + msg);
        }

        static void EnviarSMS(string msg)
        {
            Console.WriteLine("Enviando SMS: " + msg);
        }

        static void Main(string[] args)
        {
            ContaBancaria minhaConta = new ContaBancaria("Alex", 500, 500);

            minhaConta.Sacar(50.0, EnviarEmail);
            minhaConta.Sacar(20.0, EnviarSMS);
            minhaConta.Depositar(1000);
        }
    }

}