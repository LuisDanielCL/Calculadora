using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    [TestFixture]
    class Test
    {
        [TestCase]
        //Prueba de suma en caso de que los numeros sean simples
        //no se encuentren en los limites, ni sean de punto decimal
        public void SumaNumeroNormal() {
            Calc calculadora = new Calc();
            Assert.AreEqual(15, calculadora.Suma(10, 5));
        }

        [TestCase]
        //Prueba de resta en caso de que los numeros sean simples
        //no se encuantrar en los limites, ni sean de punto decimal
        public void RestaNumeroNormal()
        {
            Calc calculadora = new Calc();
            Assert.AreEqual(20, calculadora.Resta(28, 8));
        }
    }
}
