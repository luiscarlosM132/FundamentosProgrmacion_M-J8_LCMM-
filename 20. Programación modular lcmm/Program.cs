
using System;

class Program
{

    static void Main()
    {
        int filas = CapturarFilas();
        int columnas = CapturarColumnas();

        int[,] matriz = new int[filas, columnas];

        BorrarPantalla();
        LlenarMatriz(matriz);
        MostrarMatriz(matriz);

        Console.ReadKey();
    }


    static int CapturarFilas()
    {
        Console.Write("Ingrese el numero de filas: ");
        return int.Parse(Console.ReadLine());
    }

    static int CapturarColumnas()
    {
        Console.Write("Ingrese el numero de columnas: ");
        return int.Parse(Console.ReadLine());
    }

    static void BorrarPantalla()
    {
        Console.Clear();
    }

    static bool EsMultiplo(int numero)
    {
        return numero % 5 == 0;
    }

    static void LlenarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int numero;

                do
                {
                    Console.Write($"Ingrese un multiplo de 5 para [{i},{j}]: ");
                    numero = int.Parse(Console.ReadLine());

                    if (!EsMultiplo(numero))
                    {
                        Console.WriteLine("Error: el numero debe ser multiplo de 5.");
                    }

                } while (!EsMultiplo(numero));

                matriz[i, j] = numero;
            }
        }
    }

    static void MostrarMatriz(int[,] matriz)
    {
        Console.WriteLine("\nMatriz ingresada:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    
}
