using Microsoft.VisualStudio.TestTools.UnitTesting;
using MisClases;
using System;

namespace ElPlato.Test
{
    [TestClass]
    public class PlatoTest
    {
        [TestMethod]
        public void TestPrecioValido1()
        {

            Plato unPlato = new Plato("Milanesa a la napolitana", 3);
            double precioEsperado = 210;


            Assert.AreEqual(precioEsperado, unPlato.GetPrecio());

        }


        [TestMethod]
        public void TestPrecioValido2()
        {

            Plato unPlato = new Plato("Milanesa a la napolitana", 4);
            double precioEsperado = 410;


            Assert.AreEqual(precioEsperado, unPlato.GetPrecio());

        }


        [TestMethod]
        public void TestPrecioValido3()
        {

            Plato unPlato = new Plato("Milanesa a la napolitana", 0);
            double precioEsperado = 150;


            Assert.AreEqual(precioEsperado, unPlato.GetPrecio());

        }
    }
}
