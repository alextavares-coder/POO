using System;

class Desconto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrão do Vale Alimentação {salario * 0.1:c}");
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do Vale Transporte {salario * 0.06:c}");
    }
}
