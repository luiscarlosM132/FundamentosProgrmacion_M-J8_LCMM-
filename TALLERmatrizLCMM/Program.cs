using System;
using System.Runtime.ConstrainedExecution;


namespace TALLERmatrizLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*// 1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            int [,] matriz = new int[10, 20];
            int[] suma = new int [20];

            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }


            for(int j = 0; j < 20; j++)
            {
                for(int i = 0; i < 10; i++)
                {
                    suma[j] += matriz[i, j];
                }
            }

            Console.WriteLine("Matriz generada:");
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Suma de cada columna:");
            for(int j = 0; j < 20; j++)
            {
                Console.Write(suma[j] + " ");
            }*/

            /*//2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas. 

            Console.WriteLine("ingrese el número de filas de la matriz:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número de columnas de la matriz:");
            int m = int.Parse(Console.ReadLine());
            char[,] matriz = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("ingrese un carácter para la posición [{0},{1}]: ", i, j);
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            for (int j = 0; j < m; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }
        
            Console.WriteLine("Matriz intercambiada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            /*//3.  Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios.El algoritmo debe permitir: 1. Usa la función Random para generar los números aleatorios. 2. Crea un arreglo adicional para almacenar la frecuencia de cada número. 3. Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número

            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10];
            Random rand = new Random();

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 11);
                    frecuencia[matriz[i, j] - 1]++;
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("Frecuencia de cada número:");
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Número {0}: {1}", k + 1, frecuencia[k]);
            }*/

            /*// 4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la posición de una "X". El algoritmo debe permitir: 1. Usar la función Random para colocar las "X" en la matriz. 2. Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 3. Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. 

            char[,] tablero = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = '-';
                }
            }

            Random rand = new Random();
            for (int k = 0; k < 3; k++)
            {
                int fila = rand.Next(0, 5);
                int columna = rand.Next(0, 5);
                while (tablero[fila, columna] == 'X')
                {
                    fila = rand.Next(0, 5);
                    columna = rand.Next(0, 5);
                }
                tablero[fila, columna] = 'X';
            }

            for (int intentos = 0; intentos < 3; intentos++)
            {
                Console.WriteLine("Intento {0}: Ingrese la fila (0-4):", intentos + 1);
                int filaUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la columna (0-4):");
                int columnaUsuario = int.Parse(Console.ReadLine());
                if (tablero[filaUsuario, columnaUsuario] == 'X')
                {
                    Console.WriteLine("¡Felicidades! Has acertado la posición de una 'X' en ({0},{1})", filaUsuario, columnaUsuario);
                    break;
                }
                else
                {
                    Console.WriteLine("Lo siento, no hay una 'X' en esa posición.");
                }
            }

            Console.WriteLine("Tablero de juego:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            // 5.  Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz de enteros. A. Cargue los datos de la matriz ingresándolos por teclado. B. Muestre la matriz ingresada. C. Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1. D. Mostrar la nueva matriz

        }
    }
}
