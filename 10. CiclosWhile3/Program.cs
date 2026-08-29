using System;


namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numR = random.Next(1, 101);

            int intoU = 0;
            

            Console.WriteLine("Adivina el un número de 1 hasta 100");

           
            while (intoU != numR)
            {
                Console.Write("Ingresa tu intento: ");

               
                if (int.TryParse(Console.ReadLine(), out intoU))
                {
                    

                    if (intoU < numR)
                    {
                        Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                    }

                    else if (intoU > numR)
                    {

                        Console.WriteLine("Demasiado alto. Intenta de nuevo.");

                    }

                    else
                    {

                        Console.WriteLine($"¡Felicidades! ¡Adivinaste el número {numR}!");
                       
                    }
                }

                else
                {

                    Console.WriteLine("Por favor, ingresa un número entero válido.");

                }
            }
        }
    }
}