using System;

namespace _15.Vectores_LCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[15];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese el número para la posición [{i}]: ");
                num[i] = int.Parse(Console.ReadLine());
            }

           
            Console.WriteLine("\n--- Elementos registrados en el arreglo ---");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Posición [{i}]: {num[i]}");
            }

        
            int mayor = num[0];
            int posicionMayor = 0;

            int menor = num[0];
            int posicionMenor = 0;

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > mayor)
                {
                    mayor = num[i];
                    posicionMayor = i;
                }

                if (num[i] < menor)
                {
                    menor = num[i];
                    posicionMenor = i;
                }
            }

          
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"El número MAYOR es {mayor} y se encuentra en la posición [{posicionMayor}].");
            Console.WriteLine($"El número MENOR es {menor} y se encuentra en la posición [{posicionMenor}].");
        }
    }

}
    
