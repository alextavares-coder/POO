using System;

class PessoaFisica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa Empréstimo para PF {valor * 0.1:c}");
    }
}
