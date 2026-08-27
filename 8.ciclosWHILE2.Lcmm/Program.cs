using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMcero = 0;
            int nummcero = 0;
            int numIcero = 0;

            int cont = 0;

            Console.WriteLine("Confirme la cantidad de números que va ingresar: ");
            int cant = int.Parse(Console.ReadLine());

            while (cont < cant)
            {

                Console.WriteLine($"Ingrese {cant} números enteros al azar: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    numMcero++;
                }
                else if (num < 0)
                {
                    nummcero++;
                }
                else
                {
                    numIcero++;
                }
                cont++;
            }


            Console.WriteLine("---- RESULTADO: ----");
            Console.WriteLine($"Cantidad de números enteros mayores que cero: {numMcero}");
            Console.WriteLine($"Cantidad de números enteros menores que cero: {nummcero}");
            Console.WriteLine($"Cantidad de números enteros iguales que cero: {numIcero}");

        }
    }
}
