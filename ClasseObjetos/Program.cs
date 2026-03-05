namespace ClasseObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaAlex = new ContaBancaria("Alex",123456789);
            contaAlex.ExibirSaldo();
            contaAlex.Depositar(100);
            contaAlex.ExibirSaldo();
            contaAlex.Sacar(55.5);
            contaAlex.ExibirSaldo();

            Console.ReadKey();

        //    contaAlex.titular = "Alex Tavares";
        //    contaAlex.saldo = 0;
        //    contaAlex.numeroConta = 45267353;

        //    ContaBancaria contaTavares = new ContaBancaria()
        //    {
        //        titular = "Tavares",
        //        saldo = 100,
        //        numeroConta = 45566544
        //    };

        //    Console.WriteLine("Titular da Conta");
        }
    }   
}
