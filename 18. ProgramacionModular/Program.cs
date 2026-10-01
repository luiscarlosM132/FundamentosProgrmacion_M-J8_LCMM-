using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ProgramacionModular
{
    internal class Program
    {

        static int añoActual = 2026;
        static void Main(string[] args)
        {

            Console.WriteLine("BIENVENIDO AL CURSO DE FUNDAMENTOS DE PROGRAMACIÓN");
            int añoNacido = 2008;
            MostrarMensaje($"Caliche tiene {CalcularEdad(añoActual,añoNacido)}");
            MostrarMensaje("Camilo");
            MostrarMensaje("Blanquis", "Piñas");
            Console.ReadKey();
            


            BorrarPantalla();

        }

        static int CalcularEdad(int añoActual, int añoNacido)
        {
            return añoActual - añoNacido ;
        }




        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMensaje(string name)
        {
            Console.WriteLine($"BIENVENIDO {name}, AL CURSO DE FUNDAMENTOS DE PROGRAMACIÓN");
        }

        static void MostrarMensaje(String name, string apellido) 
        {
            Console.WriteLine($"BIENVENIDO {name} {apellido}, AL CURSO DE FUNDAMENTOS DE PROGRAMACIÓN");
            
        }

    }
}
