using System;


namespace _5.C.AnidadosDiagramaF.LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Condicionales Anidados - Diagrama Flujo
            // B. Diseñar un algoritmo que lea tres múmeros A, B, C y visualice en pantalla el valor más grande. El usuario dede ingresar tres números

            int A;
            int B;
            int C;

            Console.WriteLine("Ingrese 3 números: ");

            Console.WriteLine("Ingrese el valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de C: ");
            C = int.Parse(Console.ReadLine());



            if (A > B)
            {
                if (A > C)
                {

                    Console.WriteLine("El número A es el mayor.");

                }
                else
                {

                    Console.WriteLine("El número C es el mayor.");

                }


            }



            else
            {

                if ( B > C)
                {

                    Console.WriteLine("El número B es el mayor.");

                }
                else
                {

                    Console.WriteLine("El número C es el mayor.");

                }


            }



        }
    }
}
