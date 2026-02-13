using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace ModelTest
{
    [TestClass]
    public class TCalculator
    {
        [TestMethod]
        public void TMultiplication()
        {
            int a = 3;
            int b = 5;
            int c = 2;

            var calculated = new TestLibrary.Multiplication();
            int result = calculated.multiplication(a, b, c);
            Assert.AreEqual(30, result);
        }
    }
}
