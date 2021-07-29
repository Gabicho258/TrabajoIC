//Autor: Carlo Rodrigo Diaz Portilla
using System;

namespace Basico1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese el número a evaluar: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= (num / 2); i++)
            {
                if (num % i == 0)
                    Console.Write(i + ", ");
            }
            Console.Write(num);
            Console.ReadKey();
        }

    }
}
