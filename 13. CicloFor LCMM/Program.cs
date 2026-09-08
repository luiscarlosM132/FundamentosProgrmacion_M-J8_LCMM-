using System;


namespace _13.CicloFor_LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el número inicial del rango: ");
            int numinicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número final del rango: ");
            int numfin = int.Parse(Console.ReadLine());

            Console.WriteLine($"Múltiplos de 5 entre {numinicio} y {numfin}:");

            for (int i = numinicio; i <= numfin; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}