using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _19.ProgramacionModularLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MostrarMENU();
            OperacionesRET(CapturarOPC());
        }


        static float Multplicacion()
        {
            float multi = 1;
            char respuest = ' ';
            float num = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                num = float.Parse(Console.ReadLine());
                multi *= num;
                Console.WriteLine("Desea sefuir sumando? (s : continuar");
                respuest = char.Parse(Console.ReadLine());
            } while (respuest == 'S');
            return multi;

        }


        static float Suma()
        {
            float sum = 0;
            char respuest = ' ';
            float num = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                num = float.Parse(Console.ReadLine());
                sum += num;
                Console.WriteLine("Desea sefuir sumando? (s : continuar");
                respuest = char.Parse(Console.ReadLine());
            } while (respuest == 'S');
            return sum;

        }

        static float Resta()
        {
            Console.WriteLine("Ingrese un número1: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número2: ");
            float num2 = float.Parse(Console.ReadLine());

            return num1 - num2;
        }
        static float TheDivision()
        {
            Console.WriteLine("Ingrese un número1: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número2: ");
            float num2 = float.Parse(Console.ReadLine());

            return num1 / num2;
        }


        static void OperacionesRET(int opcion)
        {
            while (opcion != 0) { 

                        switch (opcion) 
                        {
                            case 1:
                                Console.WriteLine($"La suma de los numeros ingresados es: {Suma()}");
                                break;

                            case 2:
                                Console.WriteLine($"La resta de los numeros ingresados es: {Resta()}");
                                break;

                            case 3:
                                Console.WriteLine($"La multiplicacion de los numeros ingresados es: {Multplicacion()}");
                                break;

                            case 4:
                                Console.WriteLine($"La división de los numeros ingresados es: {TheDivision()}");
                            break;

                            default: 
                                Console.WriteLine("Mala elección"); 
                                break;

                        }
                Console.ReadKey();
                Console.Clear();
                MostrarMENU();
                opcion = CapturarOPC();
            }

        }

        static int CapturarOPC()
        {
            return int.Parse(Console.ReadLine());
        }

        static void MostrarMENU()
        {
            Console.WriteLine("---------------------MENÚ----------------------");
            Console.WriteLine("1. Suma            2. Resta");
            Console.WriteLine("3. Multiplicación  4. The Divion");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ingrese una opción del menú: ");
        }
    }
}
