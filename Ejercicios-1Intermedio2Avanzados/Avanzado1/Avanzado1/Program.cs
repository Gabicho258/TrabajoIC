//Autor: Carlo Rodrigo Diaz Portilla
using System;

namespace Avanzado1
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas,accion;
            Console.Write("Ingresa las filas de la matriz: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Ingresa las columnas de la matriz: ");
            columnas = int.Parse(Console.ReadLine());
            int[,] _matriz1 = matriz(filas,columnas);
            int[,] _matriz2 = matriz(filas, columnas);
            Console.WriteLine("Matriz 1 generada aleatoriamente: ");
            imprimirMatriz(_matriz1, filas, columnas);
            Console.WriteLine("Matriz 2 generada aleatoriamente: ");
            imprimirMatriz(_matriz2, filas, columnas);
            for (; ; )
            {
                Console.Write("<1>Suma <2>Resta <3>MultiplicaciónPunto <4>Finalizar: ");
                accion = int.Parse(Console.ReadLine());
                if (accion == 4)
                    break;
                switch (accion)
                {
                    case 1: int[,] _matrizSuma = suma(_matriz1, _matriz2, filas, columnas);
                        imprimirMatriz(_matrizSuma, filas, columnas);
                        break;
                    case 2: int[,] _matrizResta = resta(_matriz1, _matriz2, filas, columnas);
                        imprimirMatriz(_matrizResta, filas, columnas);
                        break;
                    case 3:
                        int[,] _matrizMultiplicacionPunto = multiplicacionPunto(_matriz1, _matriz2, filas, columnas);
                        imprimirMatriz(_matrizMultiplicacionPunto, filas, columnas);
                        break;
                }
            }
            Console.ReadKey();
        }
        static int [,] matriz(int filas, int columnas)
        {
            int[,] _matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    _matriz[i, j] = completarMatriz();
            return _matriz;
        }
        static int completarMatriz()
        {
            Random random = new Random();
            return random.Next(30) + 1;
        }
        static int [,] suma(int [,] matriz1, int [,] matriz2,int filas,int columnas)
        {
            int[,] _matriz = new int [filas,columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    _matriz[i, j] = matriz1[i, j] + matriz2[i, j];
            return _matriz;
        }
        static int[,] resta(int[,] matriz1, int[,] matriz2, int filas, int columnas)
        {
            int[,] _matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    _matriz[i, j] = matriz1[i, j] - matriz2[i, j];
            return _matriz;
        }
        static int[,] multiplicacionPunto(int[,] matriz1, int[,] matriz2, int filas, int columnas)
        {
            int[,] _matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    _matriz[i, j] = matriz1[i, j] * matriz2[i, j];
            return _matriz;
        }
        static void imprimirMatriz(int [,] matriz,int filas,int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                    Console.Write("(" + matriz[i, j] + ")");
                Console.WriteLine("");
            }
        }
    }
}
