using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Coche : Vehiculo
    {
        public string Traccion { get; set; }

        public Coche(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            Traccion = traccion;
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancar coche");
        }
    
    }
}
