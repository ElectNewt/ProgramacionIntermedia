using System;

namespace Dynamictype
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic variableDinamica = 1;
            Console.WriteLine(variableDinamica);
            variableDinamica = "Hola";

            Console.WriteLine(variableDinamica.GetType().ToString());

            variableDinamica = new EjemploTest() { Valor = "Test valor" };
            Console.WriteLine(variableDinamica.GetType().ToString());
            TestDynamic(new EjemploTest() { Valor = "Test valor" });
            TestDynamic("Hola");

        }

        static void TestDynamic(dynamic valor)
        {
            Console.WriteLine(valor.Valor);
        }

        public class EjemploTest
        {
            public string Valor { get; set; }

        }
    }
}
