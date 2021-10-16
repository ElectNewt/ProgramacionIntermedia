using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Tipos
{
    public class TipoStack
    {
        public static void Execute()
        {
            Stack<string> marcas = new Stack<string>();
            marcas.Push("Audi");
            marcas.Push("Opel");
            marcas.Push("BMW");

            foreach (string marca in marcas)
                Console.WriteLine(marca);

            Console.WriteLine($"La última marca insertada es {marcas.Peek()}"); //BMW
            Console.WriteLine($"La última marca insertada (otra vez) es {marcas.Pop()}"); //BMW
            Console.WriteLine($"La penúltima marca insertada es {marcas.Pop()}"); //Opel

        }
    }
}
