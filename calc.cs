using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{


    class Calc
    {
        public float memoria = 0;

        public float Suma(float primerNumero,float segundoNumero) {
            float salida = primerNumero + segundoNumero;
            if (salida == float.PositiveInfinity) {
                throw new System.Exception("El resultado supera el limite maximo.");
            }
            if (salida == float.NegativeInfinity)
            {
                throw new System.Exception("El resultado supera el limite minimo.");
            }
            SalvarMemoria(salida);
            return memoria;
        }

        public float Resta(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero - segundoNumero;
            if (salida == float.PositiveInfinity)
            {
                throw new System.Exception("El resultado supera el limite maximo.");
            }
            if (salida == float.NegativeInfinity)
            {
                throw new System.Exception("El resultado supera el limite minimo.");
            }
            SalvarMemoria(salida);
            return memoria;
        }

        public float Multiplica(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero * segundoNumero;
            if(salida == float.PositiveInfinity)
            {
                throw new System.Exception("El resultado supera el limite maximo.");
            }
            if (salida == float.NegativeInfinity)
            {
                throw new System.Exception("El resultado supera el limite minimo.");
            }
            SalvarMemoria(salida);
            return memoria;
        }

        public float Divide(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero / segundoNumero;

            if (segundoNumero == 0)
            {
                throw new System.Exception("No se puede dividir entre cero.");
            }
            if (salida == float.PositiveInfinity)
            {
                throw new System.Exception("El resultado supera el limite maximo.");
            }
            if (salida == float.NegativeInfinity)
            {
                throw new System.Exception("El resultado supera el limite minimo.");
            }

            SalvarMemoria(salida);
            return memoria;
        }

        public void BorrarMemoria()
        {
            memoria = 0;
        }

        public void SalvarMemoria(float numero) {
            memoria = numero;
        }

        public float GetMemoria()
        {
            return memoria;
        }
    }
}
