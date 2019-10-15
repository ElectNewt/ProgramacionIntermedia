using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public abstract class TrianguloBase
    {
        public abstract decimal Perimetro();
        public abstract decimal Area();

        public double CalcularAreaTrianguloconHipotenusa(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado * ladob / 2;
        }
    }

    public class Escaleno : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }



    }
    public class Acutangulo : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }

        public int CalcularAreaEnBaseAngulos(int angulo1, int angulo2, int angulo3)
        {
            throw new NotImplementedException();
        }

    }
}
