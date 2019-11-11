using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!".PrimeraLetraMayuscula());
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string PrimeraLetraMayuscula(this string frase)
        {
            char primeraLetra = char.ToUpper(frase[0]);
            string restoFrase = frase.Substring(1);
            return primeraLetra + restoFrase;
        }

    }

}
