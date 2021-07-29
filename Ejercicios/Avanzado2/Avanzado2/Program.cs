//Autor: Carlo Rodrigo Diaz Portilla
using System;

namespace Avanzado2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila1, columna1fila2, columna2;
            Console.Write("Ingrese filas de la primera matriz: ");
            fila1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese columnas de la primera matriz y filas de la segunda matriz: ");
            columna1fila2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese columnas de la segunda matriz: ");
            columna2 = int.Parse(Console.ReadLine());
            int[,] matriz1 = rellenarMatriz(fila1, columna1fila2);
            int[,] matriz2 = rellenarMatriz(columna1fila2, columna2);
            int[,] multiplicacion = matrizMultiplicacion(matriz1, matriz2, fila1, columna1fila2, columna2);
            Console.WriteLine("Matriz 1: ");
            imprimirMatriz(matriz1, fila1, columna1fila2);
            Console.WriteLine("Matriz 2: ");
            imprimirMatriz(matriz2, columna1fila2, columna2);
            Console.WriteLine("Matriz multiplicación: ");
            imprimirMatriz(multiplicacion, fila1, columna2);
            Console.ReadKey();
        }
        static int [,] rellenarMatriz(int filas,int columnas)
        {
            Random random = new Random();
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    matriz[i, j] = random.Next(30) + 1;
            return matriz;
        }
        static int[,] matrizMultiplicacion(int[,] matriz1, int[,] matriz2,int fila1,int columna1fila2, int columna2)
        {
            int[,] matriz = new int[fila1, columna2];
            for (int k=0;k<columna2;k++ )
                for (int j=0;j<fila1;j++)
                    for(int i=0;i<columna1fila2;i++)
                        matriz[j,k] += matriz1[j, i] * matriz2[i, k];
            return matriz;
        }
        static void imprimirMatriz(int [,] matriz,int filas, int columnas)
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

