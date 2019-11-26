using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? enteroNulo = null;
            enteroNulo = 12;

            int enteroNormal = 34;
            
            if (enteroNulo.HasValue)
            {
                enteroNormal = enteroNulo.Value;
            }

            Console.ReadLine();
        }
    }
}
