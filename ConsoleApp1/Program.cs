using System;

class Program
{
    // Arreglos para guardar un maximo de 10 cursos
    static int[] ids = new int[10];
    static string[] nombres = new string[10];
    static string[] descripciones = new string[10];

    // Arreglos para guardar hasta 100 estudiantes por curso
    static string[,] estudiantes = new string[10, 100];
    static int[] cantidadEstudiantes = new int[10];

    static int cantidadCursos = 0;
    static int siguienteId = 1;

    // MENU PRINCIPAL
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Gestion de cursos");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    GestionDeCursos();
                    break;

                case 2:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 2);
    }

    // MENU DE GESTION DE CURSOS
    static void GestionDeCursos()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("===== GESTION DE CURSOS =====");
            Console.WriteLine("1. Crear curso");
            Console.WriteLine("2. Ver lista de cursos");
            Console.WriteLine("3. Editar o eliminar un curso");
            Console.WriteLine("4. Asignar alumno a un curso");
            Console.WriteLine("5. Ver estudiantes de un curso");
            Console.WriteLine("6. Regresar al menu principal");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearCurso();
                    break;

                case 2:
                    VerCursos();
                    break;

                case 3:
                    EditarCurso();
                    break;

                case 4:
                    AsignarAlumno();
                    break;

                case 5:
                    VerEstudiantesCurso();
                    break;

                case 6:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 6);
    }

    // 1. CREAR CURSO
    static void CrearCurso()
    {
        Console.Clear();

        Console.WriteLine("===== CREAR CURSO =====");

        if (cantidadCursos < 10)
        {
            ids[cantidadCursos] = siguienteId++;

            Console.Write("Nombre del curso: ");
            nombres[cantidadCursos] = Console.ReadLine();

            Console.Write("Descripcion del curso: ");
            descripciones[cantidadCursos] = Console.ReadLine();

            cantidadEstudiantes[cantidadCursos] = 0;

            Console.WriteLine("\nCurso creado correctamente.");
            Console.WriteLine("ID del curso: "
                + ids[cantidadCursos].ToString("D4"));

            cantidadCursos++;
        }
        else
        {
            Console.WriteLine("No se pueden crear mas cursos. Limite: 10.");
        }

        Console.ReadKey();
    }

    // 2. VER LISTA DE CURSOS
    static void VerCursos()
    {
        Console.Clear();

        Console.WriteLine("===== LISTA DE CURSOS =====");

        if (cantidadCursos == 0)
        {
            Console.WriteLine("No hay cursos registrados.");
        }
        else
        {
            for (int i = 0; i < cantidadCursos; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("ID: " + ids[i].ToString("D4"));
                Console.WriteLine("Nombre: " + nombres[i]);
                Console.WriteLine("Descripcion: " + descripciones[i]);
                Console.WriteLine("Cantidad de estudiantes: "
                    + cantidadEstudiantes[i]);
            }
        }

        Console.ReadKey();
    }

    // 3. EDITAR O ELIMINAR CURSO
    static void EditarCurso()
    {
        Console.Clear();

        Console.WriteLine("===== EDITAR O ELIMINAR CURSO =====");

        if (cantidadCursos == 0)
        {
            Console.WriteLine("No hay cursos registrados.");
            Console.ReadKey();
            return;
        }

        int id;
        int posicion = -1;

        Console.Write("Ingrese el ID del curso: ");
        id = int.Parse(Console.ReadLine());

        // Buscar curso por ID
        for (int i = 0; i < cantidadCursos; i++)
        {
            if (ids[i] == id)
            {
                posicion = i;
                break;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("No existe un curso con ese ID.");
            Console.ReadKey();
            return;
        }

        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("===== OPCIONES DEL CURSO =====");
            Console.WriteLine("Curso: " + nombres[posicion]);
            Console.WriteLine("ID: " + ids[posicion].ToString("D4"));
            Console.WriteLine();
            Console.WriteLine("1. Cambiar nombre");
            Console.WriteLine("2. Cambiar descripcion");
            Console.WriteLine("3. Eliminar un estudiante");
            Console.WriteLine("4. Borrar el curso completo");
            Console.WriteLine("5. Regresar");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nuevo nombre: ");
                    nombres[posicion] = Console.ReadLine();

                    Console.WriteLine("Nombre actualizado.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Write("Ingrese la nueva descripcion: ");
                    descripciones[posicion] = Console.ReadLine();

                    Console.WriteLine("Descripcion actualizada.");
                    Console.ReadKey();
                    break;

                case 3:
                    EliminarEstudiante(posicion);
                    break;

                case 4:
                    Console.Write("¿Seguro que desea borrar el curso? (1=Si, 2=No): ");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        EliminarCurso(posicion);

                        Console.WriteLine("Curso eliminado correctamente.");
                        Console.ReadKey();

                        return;
                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada.");
                        Console.ReadKey();
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 5);
    }

    // ELIMINAR UN ESTUDIANTE DE UN CURSO
    static void EliminarEstudiante(int posicion)
    {
        Console.Clear();

        Console.WriteLine("===== ELIMINAR ESTUDIANTE =====");

        if (cantidadEstudiantes[posicion] == 0)
        {
            Console.WriteLine("Este curso no tiene estudiantes.");
            Console.ReadKey();
            return;
        }

        // Mostrar estudiantes
        for (int i = 0; i < cantidadEstudiantes[posicion]; i++)
        {
            Console.WriteLine((i + 1) + ". "
                + estudiantes[posicion, i]);
        }

        Console.Write("Seleccione el numero del estudiante que desea eliminar: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= cantidadEstudiantes[posicion])
        {
            int indice = numero - 1;

            // Mover los estudiantes para llenar el espacio
            for (int i = indice; i < cantidadEstudiantes[posicion] - 1; i++)
            {
                estudiantes[posicion, i] = estudiantes[posicion, i + 1];
            }

            cantidadEstudiantes[posicion]--;

            Console.WriteLine("Estudiante eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Numero de estudiante incorrecto.");
        }

        Console.ReadKey();
    }

    // ELIMINAR UN CURSO COMPLETO
    static void EliminarCurso(int posicion)
    {
        // Mover los cursos siguientes una posicion hacia atras
        for (int i = posicion; i < cantidadCursos - 1; i++)
        {
            ids[i] = ids[i + 1];
            nombres[i] = nombres[i + 1];
            descripciones[i] = descripciones[i + 1];
            cantidadEstudiantes[i] = cantidadEstudiantes[i + 1];

            for (int j = 0; j < cantidadEstudiantes[i]; j++)
            {
                estudiantes[i, j] = estudiantes[i + 1, j];
            }
        }

        cantidadCursos--;
    }

    // 4. ASIGNAR ALUMNO A UN CURSO
    static void AsignarAlumno()
    {
        Console.Clear();

        Console.WriteLine("===== ASIGNAR ALUMNO =====");

        if (cantidadCursos == 0)
        {
            Console.WriteLine("No hay cursos registrados.");
            Console.ReadKey();
            return;
        }

        int id;
        int posicion = -1;

        Console.Write("Ingrese el ID del curso: ");
        id = int.Parse(Console.ReadLine());

        // Buscar el curso
        for (int i = 0; i < cantidadCursos; i++)
        {
            if (ids[i] == id)
            {
                posicion = i;
                break;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("No existe un curso con ese ID.");
        }
        else if (cantidadEstudiantes[posicion] >= 100)
        {
            Console.WriteLine("El curso esta lleno.");
        }
        else
        {
            Console.Write("Nombre del alumno: ");
            string alumno = Console.ReadLine();

            estudiantes[posicion, cantidadEstudiantes[posicion]] = alumno;
            cantidadEstudiantes[posicion]++;

            Console.WriteLine("Alumno asignado correctamente.");
        }

        Console.ReadKey();
    }

    // 5. VER ESTUDIANTES DE UN CURSO
    static void VerEstudiantesCurso()
    {
        Console.Clear();

        Console.WriteLine("===== ESTUDIANTES DEL CURSO =====");

        if (cantidadCursos == 0)
        {
            Console.WriteLine("No hay cursos registrados.");
            Console.ReadKey();
            return;
        }

        int id;
        int posicion = -1;

        Console.Write("Ingrese el ID del curso: ");
        id = int.Parse(Console.ReadLine());

        // Buscar el curso por ID
        for (int i = 0; i < cantidadCursos; i++)
        {
            if (ids[i] == id)
            {
                posicion = i;
                break;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("No existe un curso con ese ID.");
        }
        else
        {
            Console.WriteLine("\nCurso: " + nombres[posicion]);
            Console.WriteLine("ID: " + ids[posicion].ToString("D4"));
            Console.WriteLine("Estudiantes inscritos:");

            if (cantidadEstudiantes[posicion] == 0)
            {
                Console.WriteLine("No hay estudiantes inscritos.");
            }
            else
            {
                for (int i = 0; i < cantidadEstudiantes[posicion]; i++)
                {
                    Console.WriteLine((i + 1) + ". "
                        + estudiantes[posicion, i]);
                }
            }
        }

        Console.ReadKey();
    }
}