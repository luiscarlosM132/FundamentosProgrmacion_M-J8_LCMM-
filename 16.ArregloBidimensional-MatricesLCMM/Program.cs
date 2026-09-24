using System;


namespace _16.ArregloBidimensional_MatricesLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int[,] num = new int [2,3];

             num [0,0] = 12;

             num [0,1] = 89;

             num [0,2] = 46;

             num [1,0] = 2;

             num[1, 1] = 54;

             num [1,2] = 25;

             Console.WriteLine ($"El número almacenado en num[1,1] es: {num[1,1]}");

             char[,] simb = new char[3, 2];

             for (int i=0; i<3; i++) 
             { 
                 for (int j=0; j<2; j++)
                 {
                     Console.Write($"Escriba el caracter para los simbolos [{i},{j}]: ");
                     simb[i, j] = char.Parse(Console.ReadLine());
                 }
             }

             Console.Clear();

             for (int i=0; i<simb.GetLength(0); i++)
             {
                 for(int j=0; j<simb.GetLength(1); j++)
                 {
                     Console.Write($"| {simb[i, j]} |");
                 }
                 Console.WriteLine();
             }


             string[,] nomb =
             {
                 {"Alba", "Fer", "Alex", "Free Hugs"},
                 {"Big Bang", "Peacock", "Filia", "Annie" },
                 {"Marie", "Fukua", "Umbrella", "Parasoul" }
             };
 */
            ////////////////////1.

            /*int[,] num = new int[10, 20];


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    num[i, j] = 100;
                }
            }
            Console.Clear();

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write($"| {num[i, j]} |");
                }
                Console.WriteLine();
            }*/

            ////////////////////2.


            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i}, {j}] de la primera matriz: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i}, {j}] de la segunda matriz: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine("Matriz suma:");
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    Console.Write($"| {matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }
        }



    }
}
