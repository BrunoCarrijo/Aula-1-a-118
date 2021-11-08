using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora para calcular a soma de uma quantidade variável de valores.

            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 27);
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
