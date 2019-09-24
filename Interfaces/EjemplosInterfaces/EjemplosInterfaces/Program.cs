using ExplicacionInterface;
using System;

namespace EjemplosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPieza triangulo = new TrianguloRectangulo(3, 4);
            IPieza cuadrado = new Cuadrado(4);
            Console.WriteLine($"el area del cuadrado es {cuadrado.Area()} y su perimetro { cuadrado.Perimetro()}");
            Console.WriteLine($"el area del triangulo es {triangulo.Area()} y su perimetro { triangulo.Perimetro()}");
            Console.ReadKey();
        }
    }
}
