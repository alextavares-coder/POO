using System;

abstract class Padrao
{
    //Obrigatório
    public abstract void taxaEmprestimo(double valor);

    //Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Ganhos Gerados pela poupança {valor * taxa:c}");
    }
}
