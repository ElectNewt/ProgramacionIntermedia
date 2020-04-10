using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploLinq
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public Libro(int id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
        }
    }
}
