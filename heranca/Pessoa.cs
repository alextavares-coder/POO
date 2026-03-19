using System;

class Pessoa
{
    //Atributos
    protected string nome;
    protected int idade;

    //Métodos
    protected void dadosPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("idade: " + idade);
    }
}