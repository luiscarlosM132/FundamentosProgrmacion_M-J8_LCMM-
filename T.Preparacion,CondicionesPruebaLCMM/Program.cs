using System;
using System.Security.Cryptography;


namespace T.Preparacion_CondicionesPruebaLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            /* int A; int B; int C;

             Console.WriteLine("Ingresar número 1: ");
             A = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresar número 2: ");
             B = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresar número 3: ");
             C = int.Parse(Console.ReadLine());


             if (A > B && A > C)
             {

                 if (B > C)
                 {
                     Console.WriteLine("El número A:" + A + " Es mayor y el orden de menor a mayor seria: " + C + " " + B + " " +A);
                 }

                 else if (C == B)
                 {
                     Console.WriteLine("El número A:" + A + " Es mayor y los números B: " + B + " y C: " + C + " Son iguales");
                 }

                 else if(B < C)
                 {
                     Console.WriteLine("El número A:" + A + " Es mayor y el orden de menor a mayor seria: " + B + " " + C + " " + A);
                 }

             }

             else if (A < B && C < B)
             {

                 if (A > C)
                 {
                     Console.WriteLine("El número B:" + B + " Es mayor y el orden de menor a mayor seria: " + C + " " + A + " " + B);
                 }

                 else if (C == A)
                 {
                     Console.WriteLine("El número B:" + B + " Es mayor y los números B: " + A + " y C: " + C + " Son iguales");
                 }

                 else if (A < C)
                 {
                     Console.WriteLine("El número B:" + B + " Es mayor y el orden de menor a mayor seria: " + A + " " + C + " " + B);
                 }


             }

             else if (C > A && C > B)
             {

                 if (A > B)
                 {
                     Console.WriteLine("El número C:" + C + " Es mayor y el orden de menor a mayor seria: " + B + " " + A + " " + C);
                 }

                 else if (B == A)
                 {
                     Console.WriteLine("El número C:" + C + " Es mayor y los números B: " + A + " y B: " + C + " Son iguales");
                 }

                 else if (A < B)
                 {
                     Console.WriteLine("El número C:" + C + " Es mayor y el orden de menor a mayor seria: " + A + " " + B + " " + C);
                 }


             }

             else
             {

                 if (A > B && A == C)
                 {
                     Console.WriteLine("Los Números A: " + A + " y C: " + C + "Son iguales y B: " + B + " es el menor.");
                 }

                 else if (B > A && B == C)
                 {
                     Console.WriteLine("Los Números B: " + B + " y C: " + C + "Son iguales y A: " + A + " es el menor.");
                 }

                 else if (C < A && A == B)
                 {
                     Console.WriteLine("Los Números B: " + B + " y A: " + A + "Son iguales y C: " + C + " es el menor.");
                 }

                 else {  Console.WriteLine(A + " " + B + " " + C + " Son iguales."); }

             }
 */
            // 2.

            int est;
            Console.WriteLine("INGRESE ESTADO DE INVECIVILIDAD (1 = SI , 2 = N0");
            est = int.Parse(Console.ReadLine());

            byte muni;
            Random rnd = new Random();
            muni = (byte)rnd.Next(1, 11);

        }
    }
}
