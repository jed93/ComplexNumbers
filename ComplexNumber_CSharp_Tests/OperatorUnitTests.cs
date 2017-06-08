using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers_CSharp;

namespace ComplexNumber_CSharp_Tests
{
    [TestClass]
    public class OperatorUnitTests
    {
        [TestMethod]
        public void StringCastOperatorTest()
        {
            ComplexNumber number = new ComplexNumber(2, 10);
            string targetConvertedNumber = "2 + 10i";

            string convertedNumber = (string)number;
            Assert.AreEqual(targetConvertedNumber, convertedNumber);
        }

        [TestMethod]
        public void AddOperatorTest()
        {
            ComplexNumber numberOne = new ComplexNumber(3, 8);
            ComplexNumber numberTwo = new ComplexNumber(6, 14);
            ComplexNumber targetNumber = new ComplexNumber(9, 22);

            ComplexNumber sum = numberOne + numberTwo;
            Assert.AreEqual(targetNumber.GetReal(), sum.GetReal());
            Assert.AreEqual(targetNumber.GetImaginary(), sum.GetImaginary());
        }

        [TestMethod]
        public void MultiplyOperatorTest()
        {
            ComplexNumber numberOne = new ComplexNumber(2, 5);
            ComplexNumber numberTwo = new ComplexNumber(4, 9);
            ComplexNumber targetNumber = new ComplexNumber(-37, 38);

            ComplexNumber product = numberOne * numberTwo;
            Assert.AreEqual(targetNumber.GetReal(), product.GetReal());
            Assert.AreEqual(targetNumber.GetImaginary(), product.GetImaginary());
        }
    }
}
