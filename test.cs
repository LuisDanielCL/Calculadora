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
        //Prueba de suma en caso de que los numeros sean simples
        //se encuentra en el limite maximo
        public void SumaLimiteMayor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Suma(float.MaxValue, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

        [TestCase]
        //Prueba de suma en caso de que los numeros sean simples
        //se encuentra en el limite minimo
        public void SumaLimiteMenor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Suma(float.MaxValue, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite menor."));
        }
    }
}
