using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using calc = TreinaWeb.Calculadora.Util;
namespace TreinaWeb.Calculadora.xUnitTest
{
    public class MultiplicacaoTests : IDisposable
    {
        private calc.Calculadora _calc;
        public MultiplicacaoTests()
        {
            _calc = new calc.Calculadora(2);
        }

        [Fact]
        public void TestMultiplicacao()
        {
            Assert.Equal(9 ,_calc.Multiplicar(3, 3));
        }

        [Fact]
        public void TestMultiplicacaoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calc.Multiplicar(1, 3)); 
        }

        [Fact]
        public void TestMultiplicacaoSegundoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calc.Multiplicar(3, 1));
        }


        [Fact]
        public void TestMultiplicacaoTodosAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calc.Multiplicar(1, 1));
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}
