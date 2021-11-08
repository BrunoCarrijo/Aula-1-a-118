using System;
using System.Globalization;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Digitar um número e mostrar sua raiz quadrada com três casas decimais,
depois repetir o procedimento.Quando o usuário digitar um número
negativo(podendo inclusive ser na primeira vez), mostrar uma mensagem
"Número negativo" e terminar o programa.*/


            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
