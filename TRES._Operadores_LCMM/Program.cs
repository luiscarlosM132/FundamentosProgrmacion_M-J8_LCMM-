using System;

namespace TRES._Operadores_LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores númericos
            //Incremento decremento

            int dat1 = 0;

            dat1++; //Dato 1 = dat1 + 1; crece

            dat1--; //Dato 1 = dat1 - 1; decrece

            dat1 += 5; //Dato 1 = dat1 + 5; crece 5 unidades

            dat1 *= 6; // Dato 1 = dat1 * 6;

            dat1 /= 7; // Dato 1 = dat1 / 7;

            dat1 += dat1;


            // Orden evaluación de operadores númerios

            float dat2 = 1 / 3 * 2;

            float dat3 = (1 / 3) * 2;

            float dat4 = 1 + 3 * 2;

            float dat5 = 1 + 3 * (2 - 0);

            float dat6 = dat2 * dat3 - dat4 / dat5;


            // Operadores Lógicos
            // Conjunción - AND - Y - &&

            Console.WriteLine("------ TABLA DE LA CONJUNCIÓN ------");

            Console.WriteLine("V && V = "+ (true && true));

            Console.WriteLine("V && F = " + (true && false));

            Console.WriteLine("F && V = " + (false && true));

            Console.WriteLine("F && F = " + (false && false));

            Console.WriteLine("------------------------------------");


            //Disyunción - OR - O - ||

            Console.WriteLine("------ TABLA DE LA DISYUNCIÓN ------");

            Console.WriteLine("V && V = " + (true || true));

            Console.WriteLine("V && F = " + (true || false));

            Console.WriteLine("F && V = " + (false || true));

            Console.WriteLine("F && F = " + (false || false));

            Console.WriteLine("------------------------------------");

            bool dat7 = true;
            bool dat8 = !dat7;

            //Operadores de Comparación

            bool dat9 = 5 > 4;
            bool dat10 = 100 <= 99;
            bool dat11 = 25 == 25;
            bool dat12 = 4 != 4;
            bool dat13 = 5 < 4 && dat7;
            bool dat14 = 0 == 1 || 12 > 3 && dat9;

        }
    }
}
