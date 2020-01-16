using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new OperationResult<Persona>();
            Persona p = resultado.Contenido;


            var resultadoCar = new OperationResult<Car>();
            Car coche = new Car("Opel", "Vectra");
            resultadoCar.SetSuccesResponse(coche);

            Car c = resultadoCar.Contenido;


            Ejemplo ej = new Ejemplo();
            ej.Metodo2();

            _ = ej.EjemploGenericMethod(coche);



        }
    }
}
