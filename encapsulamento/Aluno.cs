using System;

class Aluno
{
    //Atributos
    private double nota1, nota2, nota3;

    //Metodos
    private double media()
    {
        return (nota1 + nota2 + nota3)/3;
    }

    public void resultado()
    {
        Console.Write("Informe a 1 nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a 2 nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a 3 nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A média é " + media);
    }
}