using System;

namespace TALLERvectorLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* //2.

             int[] num1 = new int[5];
             num1[0] = 15;
             num1[1] = 56;
             num1[2] = 20;
             num1[3] = 47;
             num1[4] = 27;

             int[] num2 = new int[5];

             num2[0] = 1;
             num2[1] = 6;
             num2[2] = 0;
             num2[3] = 7;
             num2[4] = 27;

             int igul = 0;

             for (int i =0; i < 5; i++)
             {
                 if (num1[i] == num2[i])
                 {
                     igul++;
                 }

             }

             Console.WriteLine($"Vectores iguales: {igul}");*/


            //3.

            /*
                        char[] name = new char[7];

                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write($"Ingrese ingrese un caracter para la posicion {i + 1}: indice {i}: ");
                            name[i] = char.Parse(Console.ReadLine());
                        }

                        Console.Write($"CARACTERES ORIGINALES: \n");
                        for (int i = 0; i < name.Length; i++)
                        {
                            Console.Write($"{name[i]} ");
                        }
                        Console.Write($"\nCARACTERES INVERTIDOS: \n");
                        for (int i = name.Length - 1; i >= 0; i--)
                        {
                            Console.Write($"{name[i]} ");
                        }
            */


            //4.

            int[] vector = new int[20];
            int num;
            Random rad = new Random();

            for (int i = 0; i < 20; i++)
            {
                vector[i] = rad.Next(0, 51);
            }

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("No valido");
            }

            for (int i = 0; i < 20; i++)
            {
                if (vector[i] == num)
                {

                }
            }

        }
    }
}
