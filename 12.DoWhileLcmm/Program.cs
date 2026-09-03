using System;
using System.ComponentModel.Design;

namespace _12.DoWhileLcmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prom = 0;
            string nom;
            int numeC;
            int saldo = 0;
            int saldoacum = 0;
            int selec = 0;
            
            do
            {

                Console.WriteLine("Ingrese su nombre: ");
                nom = Console.ReadLine();

                Console.WriteLine("Ingrese su número de cuenta: ");
                numeC = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su número de saldo: ");
                saldo = int.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Su nombre es: {nom}, su número de cuenta {numeC}, su saldo es {saldo}, Eres apto para el crédito.");
                }
                else
                {
                    Console.WriteLine($"Su nombre es: {nom}, su número de cuenta {numeC}, su saldo es {saldo}, No eres apto para el crédito.");
                }

                Console.WriteLine("Deseas continuar? 1 para si // cualquier otro numero para no");
                selec = int.Parse(Console.ReadLine());

                saldoacum += saldo;

                prom++;

            } while (selec == 1);

            

            Console.WriteLine($"Sele pregunto a {prom} usuarios, y el promedio de los sueldos es: {saldoacum / prom}");
            

        }
    }
}
