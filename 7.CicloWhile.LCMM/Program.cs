using System;

namespace _7.CicloWhile.LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int contador = 1; 
                int acumulador = 1;

            while (contador < 5) 
            {
                contador++;
                acumulador = acumulador + contador;
            }

            Console.WriteLine($"Suma de los primeros 5 números enteros es: {acumulador}");*/
            int num;
            Console.WriteLine("Ingrese un Número: ");
            num = int.Parse(Console.ReadLine());

            int factorial = 1;
            int i = 1;
            while (i <= num)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");
        

        }
    }
}
