using System;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui le daremos los valores a los numeros
            int num1 = 15, num2 = 50;
            //veremos que numero es mayor para que se cumpla la condicion
            if (num1 >= num2)
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor");
            }
            Console.ReadKey();
        }
    }
}
