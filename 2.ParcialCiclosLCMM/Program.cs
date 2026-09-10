using System;


namespace _2.ParcialCiclosLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;

            float cantM = 0;
            float cantH = 0;
            float cantT = 0;
            float cantE = 0;

            string gene;
            string ocu;

            int cantMUJtra = 0;
            int cantHOMest = 0;
            do
            {
                Console.WriteLine("Usted Trabaja o Estudia?: T Trabajo // E Estudio");
                ocu = Console.ReadLine();

                if (ocu == "T")
                {
                    cantT++;
                }
                else if (ocu == "E")
                {
                    cantE++;
                }
                else
                {
                    Console.WriteLine("ERROR. Ingrese data valido.");
                }


                Console.WriteLine("Genro: H Hombre // M Mujer");
                gene = Console.ReadLine();

                if (gene == "H")
                {
                    cantH++;
                }
                else if (gene == "M")
                {
                    cantM++;
                }
                else
                {
                    Console.WriteLine("ERROR. Ingrese data valido.");
                }

                Console.WriteLine("\n--//--//--//--//--//--//--\n");

                if (ocu == "T" && gene == "M")
                {
                    cantMUJtra++;
                }

                if (ocu == "E" && gene == "H")
                {
                    cantHOMest++;
                }


                acum++;

            } while (acum < 15) ;


            Console.WriteLine("\n--//--//--//-- REPORTE FINAL --//--//--//--\n");

            Console.WriteLine($"\nEl procentaje de Estudiantes es: {(cantE / 15) * 100}%, Total de estos {cantE}");
            Console.WriteLine($"El procentaje de Trabajadores es: {(cantT / 15) * 100}%, Total de estos {cantT}\n");

            Console.WriteLine("\n--//--//--//--//--//--//--\n");

            Console.WriteLine($"La cantidad de Mujeres que Trabaja es: {cantMUJtra}");
            Console.WriteLine($"La cantidad de Hombres que Estudia es: {cantHOMest}");
            
        }
    }
}
