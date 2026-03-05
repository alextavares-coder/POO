using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Matematica
    {
        public void Somar(int valor1, int valor2)
        {
            Console.WriteLine("A Soma é: " + (valor1 + valor2));
        }

        public void Subtrair(int valor1, int valor2)
        {
            Console.WriteLine("A Subtração é: " + (valor1 - valor2));
        }
    }
}
