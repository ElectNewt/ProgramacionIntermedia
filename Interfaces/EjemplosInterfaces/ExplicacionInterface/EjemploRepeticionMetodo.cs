using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicacionInterface
{
    public interface interfaz1
    {
        void MetodoRepetido();
    }
    public interface interfaz2
    {
        void MetodoRepetido();
    }

    public class EjemploRepeticionMetodo : interfaz1, interfaz2
    {
        void interfaz1.MetodoRepetido()
        {
            throw new NotImplementedException();
        }

        void interfaz2.MetodoRepetido()
        {
            throw new NotImplementedException();
        }
    }
}
