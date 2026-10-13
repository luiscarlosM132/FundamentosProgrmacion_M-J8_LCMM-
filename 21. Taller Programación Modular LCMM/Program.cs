using System;
using System.Collections.Generic;
using System.Linq;


namespace _21.Taller_Programación_Modular_LCMM
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            // Taller Programación Modular 
            PedirPalabra();
            ContarVocalesConsonantes("");

        }


        static void PedirPalabra()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            int espacios = palabra.Count(c => c == ' ');
            var (vocales, consonantes) = ContarVocalesConsonantes(palabra);
            Console.WriteLine($"La palabra '{palabra}' tiene {vocales} vocales, {consonantes} consonantes y {espacios} espacios.");
        }
  
        static (int, int) ContarVocalesConsonantes(string palabra)
        {
            int vocales = 0;
            int consonantes = 0;
            foreach (char c in palabra.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vocales++;
                }
                else if (char.IsLetter(c))
                {
                    consonantes++;
                }
            }
            return (vocales, consonantes);
        }*/

        /*static void Main(string[] args)
        {
            // Taller Programación Modular 
            MostrarMenu();


        }
        // 2.  Crear un programa que permita gestionar una lista de tareas:  A. Agregar tareas.  B. Eliminar tareas  C. Mostrar la lista de tareas. 

        // static void donde muetre un menu dentro de un switch con las opciones de agregar, eliminar, mostrar tareas y salir del programa, y lo lleve a un bucle while hasta que el usuario decida salir del programa.
       
        static void MostrarMenu()
        {
            List<string> listaTareas = new List<string>();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar lista de tareas");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarTarea(listaTareas);
                        break;
                    case "2":
                        EliminarTarea(listaTareas);
                        break;
                    case "3":
                        MostrarListaTareas(listaTareas);
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // A. Agregar tareas

        static void AgregarTarea(List<string> listaTareas)
        {
            Console.WriteLine("Ingrese la tarea a agregar: ");
            string tarea = Console.ReadLine();
            listaTareas.Add(tarea);
            Console.WriteLine($"Tarea '{tarea}' agregada.");
        }

        // B. Eliminar tareas

        static void EliminarTarea(List<string> listaTareas)
        {
            Console.WriteLine("Ingrese el número de la tarea a eliminar: ");
            int numeroTarea = int.Parse(Console.ReadLine());
            if (numeroTarea > 0 && numeroTarea <= listaTareas.Count)
            {
                string tareaEliminada = listaTareas[numeroTarea - 1];
                listaTareas.RemoveAt(numeroTarea - 1);
                Console.WriteLine($"Tarea '{tareaEliminada}' eliminada.");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.");
            }
        }

        // C. Mostrar la lista de tareas.

        static void MostrarListaTareas(List<string> listaTareas)
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < listaTareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaTareas[i]}");
            }

        }*/


        static void Main(string[] args)
        {
            // Taller Programación Modular 

        }

    }
}
