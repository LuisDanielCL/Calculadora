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
        //-------------------------Tests suma-------------------------

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



        //-------------------------Tests resta-------------------------

        [TestCase]
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



        //-------------------------Tests resta-------------------------
        [TestCase]
        //Prueba de division en caso de que los numeros sean simples
        public void DivicionSimple()
        {
            Calc calculadora = new Calc();
            Assert.AreEqual(12.5, calculadora.Divide(500, 40));
        }


        [TestCase]
        //Prueba de division limite maximo
        public void DivicionMaxima()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Divide(float.MaxValue, 0.05f));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

        [TestCase]
        //Prueba de division entre cero
        public void DivicionEntreCero()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Divide(10, 0));
            Assert.That(ex.Message, Is.EqualTo("No se puede dividir entre cero."));
        }
        

    }
}
