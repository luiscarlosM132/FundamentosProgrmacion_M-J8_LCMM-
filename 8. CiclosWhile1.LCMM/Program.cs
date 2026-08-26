using System;


namespace _8.CiclosWhile1.LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.

           Console.WriteLine("Ingresa un número, positivo para seguir sumando, o negativo para finalizar y sumor el total de números ingreados: "); 
            int num = 0; 
            int suma = 0;
            num = Convert.ToByte(Console.ReadLine());

            while (num >= 0)
            {
                suma += num;
                Console.WriteLine("Ingrese otro número entero positivo o un número negativo para finalizar.");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma total de los números ingresados es: " + suma);
        }

    }
    
}

