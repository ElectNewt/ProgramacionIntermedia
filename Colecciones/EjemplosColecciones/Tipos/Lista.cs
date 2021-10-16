using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Tipos
{
    public class Lista
    {

        public static void Execute()
        {
            //Iniciación, asignando valores
            List<string> firstList = new List<string>()
            {
                "Opel",
                "BMW"
            };

            List<string> marcas = new List<string>();
            //Añadir un elemento
            marcas.Add("Audi");
            //Añadir una lista a otra lista
            marcas.AddRange(firstList);


            //acceder por índice
            Console.WriteLine(marcas[0]); //Audi

            //iterar
            foreach (string item in marcas)
                Console.WriteLine(item);


            IReadOnlyList<string> readonlyMarcas = marcas;
            IList<string> IlistMarcas = marcas;

            //Insertar en index especifico
            marcas.Insert(1, "Skoda");

            marcas.RemoveAt(0); //Elimina Audi
            marcas.Remove("Skoda");//Elimina skoda


            SortedList<int, string> listaCochesOrdenada = new SortedList<int, string>()
            {
                {3,"bmw" },
                {1, "audi" },
                {2, "opel" }
            };

            foreach (var item in listaCochesOrdenada)
                Console.WriteLine(item.Value); //imprime: audi, opel, bmw

        }
    }
}
