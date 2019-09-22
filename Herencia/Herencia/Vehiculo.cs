using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Vehiculo
    {
        private decimal _velocidadActual { get; set; }
        public decimal VelocidadActual
        {
            get
            {
                return _velocidadActual + 2;
            }
            set
            {
                _velocidadActual = value;
            }
        }
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void Arrancar()
        {
            Console.Write("Arrancar vehiculo");
        }
    }
}
