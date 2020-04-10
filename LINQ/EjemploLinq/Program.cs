using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Libro> arrayLibros = new Libro[] {
                new Libro(1, "Poeta en nueva york", "Federico García Lorca"),
                new Libro(2, "Los asesinos del emperador", "Santiago Posteguillo"),
                new Libro(3, "circo máximo", "Santiago Posteguillo"),
                new Libro(4, "La noche en que Frankenstein leyó el Quijote", "Santiago Posteguillo"),
                new Libro(5, "El origen perdido", "Matilde Asensi")
            };


            //Forma1
            var libros = from libro in arrayLibros
                         where libro.Autor == "Santiago Posteguillo"
                         select libro;

            var librosOrdenados = arrayLibros.Where(a => a.Autor == "Santiago Posteguillo").OrderBy(a=>a.Titulo);

            

            Libro f = arrayLibros.First(a => a.Id == 1);
            Libro sin = arrayLibros.SingleOrDefault(a => a.Id == 1);

            Libro ultimo = arrayLibros.LastOrDefault (a => a.Id == 0);
            

            Libro librosFirstDefault = arrayLibros.SingleOrDefault(a => a.Id == 1);



            var agrupacion = arrayLibros.GroupBy(a => a.Autor);

            foreach(var autorLibro in agrupacion)
            {
                Console.WriteLine(autorLibro.Key);

                foreach(var libro in autorLibro)
                {
                    Console.WriteLine(libro.Titulo);
                }

            }


            IEnumerable<Libro> librosExtension = arrayLibros.Filtro(a => a.Autor == "Santiago Posteguillo");



        }
    }
}
