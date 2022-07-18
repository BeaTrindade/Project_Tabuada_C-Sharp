using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Tabuada no C# <--- \n");
            double numero;
            Console.WriteLine("Digite o NUMERO da Tabuada que deseja: \n");

            numero = double.Parse(Console.ReadLine());

            for (int y = 0; y <= 10; y++)
            {
                double total = numero * y;
                Console.WriteLine(numero + " X " + y + " = " + total);

            }
            Console.WriteLine("\n Para calcular novamente, reinicie! \n");
        }
    }
}
