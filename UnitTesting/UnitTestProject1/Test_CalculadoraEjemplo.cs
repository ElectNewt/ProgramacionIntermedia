using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Test_CalculadoraEjemplo
    {
        [TestMethod]
        public void Test_Suma_correcta()
        {
            //Arrange: inicializar las variables
            int sumando1 = 2;
            int sumando2 = 5;

            //Act: ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Suma(sumando1, sumando2);

            //Assert: comprobacion de los valores
            Assert.AreEqual(25, resultado);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void test_excepcion()
        {

            int dividendo = 120;
            int divisor = 0;
            double resultado = CalculadoraEjemplo.Division(dividendo, divisor);

        }

    }
}
