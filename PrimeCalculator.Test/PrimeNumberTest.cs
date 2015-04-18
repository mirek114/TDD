using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCalculator;

namespace PrimeCalculator.Test
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void IsPrimeTest()
        {
            PrimeNumber primeNumber = new PrimeNumber();

            Assert.IsTrue(primeNumber.IsPrime(3));
        }
    }
}
