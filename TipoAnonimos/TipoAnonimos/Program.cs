using System;
using System.Collections.Generic;
using System.Linq;

namespace TipoAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Nombre = "Raul", Apellido = "Albiol", Edad = 33 });
            personas.Add(new Persona() { Nombre = "Iago", Apellido = "Aspas", Edad = 30 });


            var resultado = personas.Where(a => a.Edad == 30)
                .Select(a=> new { NombreCompleto = $"{a.Nombre} {a.Apellido}" });

            foreach(var r  in resultado)
            {
                Console.WriteLine(r.NombreCompleto);
            }
            
           
          

            Console.ReadLine();
        }

        
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}
