using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");
        }
    }
}
