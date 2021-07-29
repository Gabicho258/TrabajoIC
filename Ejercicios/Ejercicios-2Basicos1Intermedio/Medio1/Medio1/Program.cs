//Autor: Carlo Rodrigo Diaz Portilla
using System;

namespace Medio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numFibonacci;
            Console.Write("Ingrese el número para obtener Fibonacci: ");
            num = int.Parse(Console.ReadLine());
            numFibonacci = fibonacci(num);
            Console.WriteLine("El número Fibonacci de " + num + " es: " + numFibonacci);
            Console.ReadKey();
        }
        static int fibonacci(int num)
        {
            if (num == 1 || num == 0)
                return num;
            else
                return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
}
