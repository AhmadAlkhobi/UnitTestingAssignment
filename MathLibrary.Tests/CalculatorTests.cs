using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            int a = 2, b = 3;
            int result = Calculator.Multiply(a, b);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_NumberWithZero_ReturnsZero()
        {
            int a = 0, b = 5;
            int result = Calculator.Multiply(a, b);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
        {
            int a = -2, b = 3;
            int result = Calculator.Multiply(a, b);
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void Multiply_TwoNegativeNumbers_ReturnsPositive()
        {
            int a = -2, b = -3;
            int result = Calculator.Multiply(a, b);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            // Act
            int result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DivisionByZero_ReturnsZero()
        {
            // Arrange
            int a = 10;
            int b = 0;
            int expected = 0;

            // Act
            int result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_NegativeAndPositiveNumber_ReturnsNegative()
        {
            // Arrange
            int a = -10;
            int b = 2;
            int expected = -5;

            // Act
            int result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            int a = 4;
            bool expected = true;

            // Act
            bool result = Calculator.IsEven(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            int a = 3;
            bool expected = false;

            // Act
            bool result = Calculator.IsEven(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsEven_Zero_ReturnsTrue()
        {
            // Arrange
            int a = 0;
            bool expected = true;

            // Act
            bool result = Calculator.IsEven(a);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}