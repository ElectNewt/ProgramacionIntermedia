using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploStatic
{
    public static class Calculadora
    {
        public static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static double Media(List<int> listaEnteros)
        {
            return listaEnteros.Average();
        }

    }
}
