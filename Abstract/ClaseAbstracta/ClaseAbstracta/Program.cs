using System;
using System.Collections.Generic;
using System.Linq;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Acutangulo acutangulo = new Acutangulo();
            Escaleno escaleno = new Escaleno();

            acutangulo.Area();
            escaleno.Area();

            acutangulo.CalcularAreaEnBaseAngulos(2, 3, 4);

            escaleno.CalcularAreaTrianguloconHipotenusa(2, 5);
            acutangulo.CalcularAreaTrianguloconHipotenusa(2, 5);

            Console.WriteLine("Hello World!");
        }

    }

}
