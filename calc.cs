using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{


    class Calc
    {
        private float memoria = 0;

        public float Suma(float primerNumero,float segundoNumero) {
            float salida = primerNumero + segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        public float Resta(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero - segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        public float Multiplica(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero * segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        public float Divide(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero / segundoNumero;
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
