using System;

namespace _2.ConstantesTiposDatosOperadoresLCMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string IVA = "19%";

            string nom = "Luis";
            nom = "Carlos";
            //IVA = "20%"; a una constante no le puedo cambiar el valor.

            //Tipos de datos.

            byte dato1 = 255;

            int dat2 = -12366;

            long dat3 = 1234567890098765434;

            float dat4 = 9.8f;

            double dat5 = 3.1417d;

            decimal dat6 = 1234567890987655554321.2345678909876543212345678900000987654321m;

            char dat7 = '&'; // Un solo caracter.

            string dat8 = "8 datos sobre $$$_$$$";

            bool dat9 = false; // true o flase.

            object dat10 = new object();

            //OPERADORES
            //Ope numéricos
            //Cambio de signo

            int dat11 = 5;
            int dat12 = -dat11;

            Console.WriteLine("dato11: {0}, dato12 {1}", dat11, dat12);

            //Ope Aritmeticos

            int dat13 = dat2 + dat11;
            Console.WriteLine("La suma es: {0},", dat13);

            int dat14 = dat13 - dato1;
            Console.WriteLine("La resta es: {0},", dat14);

            int dat15 = dat14 * dato1;
            Console.WriteLine("El producto es: {0},", dat15);

            //float dat16 =(float) dat15 / dato1;
            float dat16 = dat15 / dato1;
            Console.WriteLine("La División es: {0}}", dat16);



        
        }
    }
}
