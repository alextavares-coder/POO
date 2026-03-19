using System;

class Atendente : Desconto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Atendente do Vale Alimentação {salario * 0.2:c}");
    }
}
