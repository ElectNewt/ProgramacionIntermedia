using System;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayoriaEdad = 18;
            int edadActual = 22;
            string resultado;

            if (mayoriaEdad <= edadActual)
            {
                resultado = "El usuario es mayor de edad";
            }
            else
            {
                resultado = "El usuario es menor de edad";
            }

            resultado = mayoriaEdad <= edadActual ? "El usuario es mayor de edad" : "El usuario es menor de edad";

            //int votar = 21, conducir = 25;

            //resultado = conducir <= edadActual ? "puede conducir y votar" : votar <= edadActual ?
            //    "puede votar" : mayoriaEdad <= edadActual ?
            //    "es mayor de edad" : "No puede hacer nada";


            Console.WriteLine(resultado);

            Console.ReadKey();
        }

        public static int ExecuteFunciton()
        {
            Console.WriteLine("El usuario es mayor de edad");
            return 1;
        }

    }
}
