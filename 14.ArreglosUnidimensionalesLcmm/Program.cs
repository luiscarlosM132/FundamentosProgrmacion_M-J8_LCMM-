using System;
using System.Xml.Linq;


namespace _14.ArreglosUnidimensionalesLcmm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int[] num = new int[5];

             num[0] = 15;
             num[1] = 56;
             num[2] = 20;
             num[3] = 47;
             num[4] = 27;

             Console.WriteLine($"El dato almacenado en la posición 4 en el indice 3 es:\n{num[4]}");

             float[] not = new float[3];
             not[0] = 3.6f;
             not[1] = 4.3f;
             not[2] = 5.0f;

             char[] simbol = new char[] { 'L', 'K', '$' };
             bool[] verdadfalso = { true, false, true, false };


             string[] name = new string[7];

             for (int i=0; i < 7; i++)
             {
                 Console.WriteLine($"Ingrese el nombre para la posicion {i+1}: indice {i}");
                 name[i] = Console.ReadLine();
             }


             for (int i=0;i < name.Length; i++)
             {
                 Console.Write($"{name[i]} | ");
             }*/

            int[] num = new int[100];

            for (int i = 0; i < 100; i++)
            { 
                num[i] = 10;
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} | ");
            }



        }
    }
}
