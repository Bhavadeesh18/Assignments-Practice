using NUnit.Framework;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Multiply_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Divide_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }

        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            double result = calculator.Add(7, 0);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Subtract_SameNumbers_ReturnsZero()
        {
            double result = calculator.Subtract(5, 5);
            Assert.AreEqual(0, result);
        }
    }
}
