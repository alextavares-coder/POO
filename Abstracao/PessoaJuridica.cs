using System;

class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa Empréstimo para PJ {valor * 0.2:c}");
    }
}
