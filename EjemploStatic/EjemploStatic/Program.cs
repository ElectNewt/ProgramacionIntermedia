using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploStatic
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int resultadoSuma = Calculadora.Suma(1, 2);
                Calculadora.Media(new List<int>() { 1, 2, 5 });

            }catch(Exception e)
            {
                EjemploLog.LogError(e.Message);
            }


        }
    }

    
}
