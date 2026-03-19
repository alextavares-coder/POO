using System;

class Gerente : Desconto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Gerente do Vale Alimentação {salario * 0.2:c}");
    }
}
