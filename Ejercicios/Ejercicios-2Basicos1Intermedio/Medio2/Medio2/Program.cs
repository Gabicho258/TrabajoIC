//Autor: Carlo Rodrigo Diaz Portilla.
using System;

namespace Medio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dadoJugador, dadoComputadora,respuesta;
            for (; ; )
            {
                dadoJugador = lanzarDados();
                dadoComputadora = lanzarDados();
                if (dadoJugador > dadoComputadora)
                    Console.WriteLine("Has ganado!");
                else
                    Console.WriteLine("Has perdido!");
                Console.WriteLine("Resultados: \nJugador: {0}\nComputadora: {1}", dadoJugador, dadoComputadora);
                Console.WriteLine("¿Desea volver a jugar?<1>Si <2>No");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                    continue;
                else if (respuesta == 2)
                    break;
            }
            Console.ReadKey();
        }
        static int lanzarDados()
        {
            Random random = new Random();
            return random.Next(12) + 1;
        }
    }
}
