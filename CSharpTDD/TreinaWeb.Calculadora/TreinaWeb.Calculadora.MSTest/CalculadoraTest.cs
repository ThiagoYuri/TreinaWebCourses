using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calc = TreinaWeb.Calculadora.Util;

namespace TreinaWeb.Calculadora.MSTest
{
    [TestClass]
    public class CalculadoraTest : IDisposable
    {
        private calc.Calculadora _calc;
        public CalculadoraTest()
        {
            _calc = new calc.Calculadora(3);
        }

        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(8, _calc.Somar(4, 4));
        }

        [TestMethod]
        public void TestSomarLimite()
        {
            Assert.AreEqual(8, _calc.Somar(4, 4));
        }

        [TestMethod]
        public void TestForaLimite()
        {
            try
            {
                _calc.Somar(2, 2);
                Assert.AreEqual(1, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.AreEqual(1, 1);

            }
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}