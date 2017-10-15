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
            var ex = Assert.Throws<Exception>(() => calculadora.Suma(float.MinValue, float.MinValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite minimo."));

        }

        [TestCase]
        //Prueba de suma en caso de que los numeros contengan decimales
        public void SumaDecimal() { 
            Calc calculadora = new Calc();
            Assert.AreEqual(0.5f, calculadora.Suma(10.9f, -10.4f));
        }

<<<<<<< HEAD
    [TestCase]
=======
        [TestCase]
>>>>>>> a634ca159543bcd355f519267b8914a33714cde1
        //Prueba de resta en caso de que los numeros sean simples
        //no se encuantrar en los limites, ni sean de punto decimal
        public void RestaNumeroNormal()
        {
            Calc calculadora = new Calc();
            Assert.AreEqual(20, calculadora.Resta(28, 8));
        }

        [TestCase]
        //Prueba de suma en caso de que los numeros sean simples
        //se encuentra en el limite minimo
        public void RestaLimiteMenor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Resta(float.MinValue, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite minimo."));
        }

        [TestCase]
        //Prueba de suma en caso de que los numeros sean simples
        //se encuentra en el limite maximo
        public void RestaLimiteMayor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Resta(float.MaxValue, float.MinValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

    }
}
