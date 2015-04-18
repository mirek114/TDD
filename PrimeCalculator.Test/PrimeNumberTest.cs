using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCalculator;

namespace PrimeCalculator.Test
{
    [TestClass]
    public class PrimeNumberTest
    {
        PrimeNumber primeNumber = new PrimeNumber();

        [TestMethod]
        public void IsPrimeTest()
        {
            Assert.IsTrue(primeNumber.IsPrime(3));
        }

        [TestMethod]
        public void GetSumOfPrimeTest()
        {
            Assert.AreEqual(primeNumber.GetSumOfPrime(10), 17ul);
        }
    }
}
