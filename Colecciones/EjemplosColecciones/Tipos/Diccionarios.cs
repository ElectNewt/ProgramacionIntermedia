using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Tipos
{
    class Diccionarios
    {
        public static void Execute()
        {
            //inicialización y crear a valores
            Dictionary<string, string> comunidadesCapitales = new Dictionary<string, string>()
            {
                {"Aragon", "Zaragoza"},
                {"Navarra", "Pamplona"}
            };
            //añadir valores
            comunidadesCapitales.Add("Castilla la mancha", "Toledo");


            //acceder a valores
            Console.WriteLine(comunidadesCapitales["Aragon"]); //devuelve Zaragoza

            KeyValuePair<string, string> resultado = comunidadesCapitales.ElementAt(0);
            Console.WriteLine(resultado.Value); //devuelve Zaragoza


            //Acceder correctamente a los valores
            if (comunidadesCapitales.TryGetValue("Aragon", out string resultadoCapital))
            {
                Console.WriteLine(resultadoCapital); //zaragoza
            }
            else
            {
                Console.WriteLine("el parámetro no existe");
            }


            //actalizar valores de un diccionario
            if (comunidadesCapitales.ContainsKey("Aragon"))
            {
                comunidadesCapitales["Aragon"] = "Teruel Existe";
            }

            //eliminar elementos
            comunidadesCapitales.Remove("Aragon");
            comunidadesCapitales.Clear();
        }
    }
}
