using System;

namespace _13.CicloForLcmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;

            for (int cont = 1; cont <= 5; cont++)
            {
                acum += cont;
            }
            Console.WriteLine($"La suma de los primeros cinco primeros números es: {acum}");
        }
    }
}
