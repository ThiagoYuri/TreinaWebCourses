using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calc = TreinaWeb.Calculadora.Util;
using Xunit;
using System;
namespace TreinaWeb.Calculadora.xUnitTest
{
    public class DivisaoTest
    {
        private calc.Calculadora _calc;
        public DivisaoTest()
        {
                _calc = new calc.Calculadora(2); 
        }

        [Fact]
        public void TestDividir()
        {
            Assert.Equal(1, _calc.Dividir(3, 3));
        }


        [Fact]
        public void TestDividirAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Assert.Equal(1, _calc.Dividir(1,3));
            });
        }

        [Fact]
        public void TestDividirSegundoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Assert.Equal(3, _calc.Dividir(3, 1));
            });
        }

        [Fact]
        public void TestDividirTodosAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Assert.Equal(1, _calc.Dividir(1, 1));
            });
        }

        [Fact]
        public void TestDividirSegundoArgZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calc.Dividir(1, 0);
            });
        }
    }
}
