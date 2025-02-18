using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange & Act
            double result = SimpleMath.Add(num1, num2);
            
            // Assert
            Assert.AreEqual(num1 + num2, result);
        }

        [TestMethod]
        [DataRow(10, 2)]
        [DataRow(15, 3)]
        [DataRow(-6, 2)]
        [DataRow(0, 5)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange & Act
            double result = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(num1 * num2, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Arrange
            double numerator = 10;
            double denominator = 0;

            // Act & Assert
            ArgumentException ex = Assert.ThrowsException<ArgumentException>(() =>
                SimpleMath.Divide(numerator, denominator));
            Assert.AreEqual("Denominator cannot be zero", ex.Message);
        }

        [TestMethod]
        [DataRow(10, 2)]
        [DataRow(15, 3)]
        [DataRow(-6, 2)]
        [DataRow(0, 5)]
        // TODO: Test Divide method with two valid numbers
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            // Arrange & Act
            double result = SimpleMath.Divide(num1, num2);
            // Assert
            Assert.AreEqual(num1 / num2, result);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(10, 5)]
        [DataRow(0, 0)]
        [DataRow(-5, -3)]
        [DataRow(3, 5)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            // Arrange & Act
            double result = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(num1 - num2, result);
        }

    }
}