using System;
using System.Globalization;

namespace CondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(condição) ? valor se true : valor se false
            //(2 > 4) ? 50 : 80                 OUTPUT-> 80
            //(10 != 3 ) ? "Maria" : "Alex"     OUTPUT-> "Maria"

            //SOLUÇÃO COM IF/ELSE
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto;
            //if (preco < 100.0)
            //{
            //    desconto = preco * 0.05;
            //}
            //else
            //{
            //    desconto = preco * 0.1;
            //}
            //Console.WriteLine(desconto);

            //SOLUÇÃO COM EXPRESSÃO CONDICIONAL TERNÁRIA
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 100) ? preco * 0.05 : preco * 0.1;
           
            Console.WriteLine(desconto);

        }
    }
}
