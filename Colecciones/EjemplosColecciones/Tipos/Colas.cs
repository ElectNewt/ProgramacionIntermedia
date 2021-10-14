using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Tipos
{
    public class Colas
    {
        public static void Execute()
        {
            Queue<string> marcas = new Queue<string>();
            marcas.Enqueue("Audi");
            marcas.Enqueue("Opel");
            marcas.Enqueue("BMW");


            foreach (string marca in marcas)
                Console.WriteLine(marca);

            Console.WriteLine($"La primera marca es {marcas.Peek()}"); //Audi
            Console.WriteLine($"La primera marca (otra vez) es {marcas.Dequeue()}"); //Audi
            Console.WriteLine($"La segunda marca es {marcas.Dequeue()}"); //Opel
        }

    }
}
