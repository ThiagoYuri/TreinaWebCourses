using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Calculadora.Util
{
    public class Calculadora
    {
        private int _limiteMinimo;

        public Calculadora(int limiteMinimo = 0)
        {
            _limiteMinimo = limiteMinimo;
        }

        public int Somar(int a, int b)
        {
            Validar(a, b);
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            Validar(a, b);
            return a - b;
        }


        public int Multiplicar(int a, int b)
        {
            Validar(a, b);
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("O segundo argumento não pode ser 0 ");
            Validar(a, b);
            return a / b;
        }

        private void Validar(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
                throw new ArgumentOutOfRangeException("O argumento está abaixo do limite");
        }
    }
}
