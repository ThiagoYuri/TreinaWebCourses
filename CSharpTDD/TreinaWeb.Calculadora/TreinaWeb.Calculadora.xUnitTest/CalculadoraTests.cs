using System;
using Xunit;
using calc = TreinaWeb.Calculadora.Util;


namespace TreinaWeb.Calculadora.xUnitTest
{
    public class CalculadoraTests: IDisposable
    {
        private calc.Calculadora _calc;
        public CalculadoraTests()
        {
            _calc = new calc.Calculadora(3);
        }

        [Fact]
        public void TestSomar()
        {
            Assert.Equal(8, _calc.Somar(4, 4));
        }

        [Fact]
        public void TestSomarLimite()
        {
            Assert.Equal(8, _calc.Somar(4, 4));
        }

        [Fact]
        public void TestForaLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Somar(2, 2);
            }
            );        
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}