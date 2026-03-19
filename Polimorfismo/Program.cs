namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        //Implementação Estagiario
        Desconto objE = new Estagiario();
        objE.valeAlimentacao(1000);
        objE.valeTransporte(1000);
        Console.WriteLine(
            "---------------------------------------------------------------------------"
        );

        //Implementação Atendente
        Desconto objA = new Atendente();
        objA.valeAlimentacao(2000);
        objA.valeTransporte(2000);
        Console.WriteLine(
            "---------------------------------------------------------------------------"
        );

        //Implementação Gerente
        Desconto objG = new Gerente();
        objG.valeAlimentacao(3000);
        objG.valeTransporte(3000);
        Console.WriteLine(
            "---------------------------------------------------------------------------"
        );
    }
}
