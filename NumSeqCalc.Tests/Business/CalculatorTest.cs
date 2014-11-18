using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NumSeqCalc.Tests.Business
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ValidatePositive()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            bool result = calc.ValidatePositive("1.1");
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void GetAllNumbersIncTo()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            var result = calc.GetAllNumbersIncTo("3");
            var valid = new List<string>() {"0","1","2","3" };
            CollectionAssert.Equals(result, valid);
        }

        [TestMethod]
        public void GetOddNumbersIncTo()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            var result = calc.GetAllNumbersIncTo("3");
            var valid = new List<string>() { "1", "3" };
            CollectionAssert.Equals(result, valid);
        }

        [TestMethod]
        public void GetEvenNumbersIncTo()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            var result = calc.GetAllNumbersIncTo("3");
            var valid = new List<string>() { "0", "2" };
            CollectionAssert.Equals(result, valid);
        }

        [TestMethod]
        public void GetAllNumbersIncToCase()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            var result = calc.GetAllNumbersIncTo("3");
            var valid = new List<string>() { "0", "1", "2", "C" };
            CollectionAssert.Equals(result, valid);
        }

        [TestMethod]
        public void GetAllFibonacciNumbersIncTo()
        {
            var calc = new NumSeqCalc.Business.Calculator();
            var result = calc.GetAllNumbersIncTo("3");
            var valid = new List<string>() { "0", "1", "2", "3" };
            CollectionAssert.Equals(result, valid);
        }
    }
}
