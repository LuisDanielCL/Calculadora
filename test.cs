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

        //---------------------------Test resta---------------------------------------------------------------

        [TestCase]
        //Prueba de resta en caso de que los numeros sean simples
        //no se encuantrar en los limites, ni sean de punto decimal
        public void RestaNumeroNormal()
        {
            Calc calculadora = new Calc();
            Assert.AreEqual(20, calculadora.Resta(28, 8));
        }

        [TestCase]
        //Prueba de resta en caso de que los numeros sean simples
        //se encuentra en el limite minimo
        public void RestaLimiteMenor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Resta(float.MinValue, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite minimo."));
        }

        [TestCase]
        //Prueba de resta en caso de que los numeros sean simples
        //se encuentra en el limite maximo
        public void RestaLimiteMayor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Resta(float.MaxValue, float.MinValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

        //-----------------------Test multiplicacion-------------------------------------------------------------

        [TestCase]
        //Prueba de multiplicacion en caso de que los numeros sean simples
        //se encuentra en el limite maximo
        public void MultiplicacionLimiteMayor()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Multiplica(float.MaxValue, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

        [TestCase]
        //Prueba de multiplicacion en caso de que los numeros sean simples
        //se encuentra en el limite minimo
        public void MultiplicacionLimiteMinimo()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Multiplica(float.MaxValue, float.MinValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite minimo."));
        }

        //-------------------------Tests division-------------------------
        [TestCase]
        //Prueba de suma en caso de que los numeros sean simples
        //no se encuentren en los limites, ni sean de punto decimal
        public void DivisionNormal()
        {
            Calc calculadora = new Calc();
            Assert.AreEqual(2, calculadora.Divide(10, 5));
        }

        [TestCase]
        //Prueba de division limite maximo
        public void DivisionMaxima()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Divide(float.MaxValue, 0.05f));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite maximo."));
        }

        [TestCase]
        //Prueba de division limite minimo
        public void DivisionMinimo()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Divide(-0.05f, float.MaxValue));
            Assert.That(ex.Message, Is.EqualTo("El resultado supera el limite minimo."));
        }

        [TestCase]
        //Prueba de division entre cero
        public void DivisionEntreCero()
        {
            Calc calculadora = new Calc();
            var ex = Assert.Throws<Exception>(() => calculadora.Divide(10, 0));
            Assert.That(ex.Message, Is.EqualTo("No se puede dividir entre cero."));
        }

        //-------------------------Tests Memoria-------------------------
        [TestCase]
        //Prueba que se guarde la memoria
        public void GuardarMemoria()
        {
            Calc calculadora = new Calc();
            calculadora.SalvarMemoria(8);
            Assert.That(calculadora.memoria == 8);
        }

        [TestCase]
        //Prueba que se cargue la memoria
        public void CargarMemoria()
        {
            Calc calculadora = new Calc();
            calculadora.memoria = 10;
            Assert.That(calculadora.GetMemoria() == 10);
        }

        [TestCase]
        //Prueba que se guarde 'borre
        public void BorarMemoria()
        {
            Calc calculadora = new Calc();
            calculadora.memoria = 10;
            calculadora.BorrarMemoria();
            Assert.That(calculadora.memoria == 0);
        }
    }
}
