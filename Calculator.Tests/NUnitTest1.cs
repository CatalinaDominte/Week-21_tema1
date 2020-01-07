using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{

    [TestFixture]
    public class NUnitTest1
    {
        public CalculatorApp calc;

        [SetUp]
        public void Setup()
        {
            // Arrange
            calc = new CalculatorApp();
        }

        [Test]
        [TestCase(8, 6, 14)]
        [TestCase(0, 5, 5)]
        [TestCase(-1, 4, 3)]
        [TestCase(-5, -1, -6)]
        public void Add_Two_Numbers(int first, int last, int expected)
        {
            // Act
            int actual = calc.Add(first, last);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(5, 2, 10)]
        [TestCase(0, 2, 0)]
        [TestCase(-5, 2, -10)]
        [TestCase(-5, -2, 10)]
        public void Mul_Two_Numbers(int first, int last, int expected)
        {
            int actual = calc.Mul(first, last);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(5, 2, 3)]
        [TestCase(0, 2, -2)]
        [TestCase(-5, 2, -7)]
        [TestCase(10, 8, 2)]
        public void Sub_Two_Numbers(int first, int last, int expected)
        {
            int actual = calc.Sub(first, last);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(4,2,2)]
        [TestCase(35, 2, 17.5)]
        [TestCase(0, 2, 0)]
        public void Div_Two_Numbers(int first, int last, decimal expected)
        {
            decimal actual = calc.Div(first, last);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Divide_By_Zero_Exception()
        {
            
            Assert.Throws<DivideByZeroException>(() => calc.Div(4, 0));
        }
    }
    
}
