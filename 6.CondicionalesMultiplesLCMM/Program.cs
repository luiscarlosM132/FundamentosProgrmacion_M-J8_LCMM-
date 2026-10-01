using System;

namespace _6.CondicionalesMultiplesLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resp;
            Console.WriteLine("-------------MENU-------------");
            Console.WriteLine("1. opción 1        2. opción 2");
            Console.WriteLine("3. opción 3        4. opción 4");
            Console.WriteLine("5. opción 5");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Elija una opción del menú: ");
            resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    Console.WriteLine("Eligío opción 1.");
                    break;

                case 2:
                    Console.WriteLine("Eligío opción 2.");
                    break;

                case 3:
                    Console.WriteLine("Eligío opción 3.");
                    break;

                case 4:
                    Console.WriteLine("Eligío opción 4.");
                    break;

                case 5:
                    Console.WriteLine("Eligío opción 5.");
                    break;

                default: Console.WriteLine("Error, ingrese solo 1, 2, 3, 4, 5");
                    break;
            }


            }
    }
}
