using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicacionInterface
{
    public class Cuadrado : IPieza
    {
        readonly decimal Lado;
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal Area()
        {
            return Lado * Lado;
        }

        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
