//Autor: Carlo Rodrigo Diaz Portilla
using System;

namespace Basico2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool primo = true;
            Console.Write("¿Número primo?: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                Console.WriteLine(num + " es un número primo.");
            }
            else
            {
                Console.WriteLine(num + " no es un número primo.");
            }
            Console.ReadKey();
        }
    }
}
