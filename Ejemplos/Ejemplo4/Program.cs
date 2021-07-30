using System;

namespace Ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //El programa escribira todos los numeros menores a 100
            int x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(";");
                x++;
                //cada vez que escriba un numero se sumara mas uno hasta llegar a 100
            }
            Console.ReadKey();
        }
    }
}
