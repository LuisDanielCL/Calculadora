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

        float Suma(float primerNumero,float segundoNumero) {
            float salida = primerNumero + segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        float Resta(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero - segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        float Multiplica(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero * segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        float Divide(float primerNumero, float segundoNumero)
        {
            float salida = primerNumero / segundoNumero;
            SalvarMemoria(salida);
            return memoria;
        }

        void BorrarMemoria()
        {
            memoria = 0;
        }

        void SalvarMemoria(float numero) {
            memoria = numero;
        }

        float GetMemoria()
        {
            return memoria;
        }
    }
}
