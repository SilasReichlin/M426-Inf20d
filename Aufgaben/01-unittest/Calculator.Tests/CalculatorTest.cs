using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;

            // Act
            int actual = Calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;

            // When
            int actual = Calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_TwoFactors_ReturnsProductOfFactors()
        {
            //Arrange
            int factor1 = 10;
            int factor2 = 10;
            int expected = 100;
            //Act
            int actual = Calculator.Multiply(factor1, factor2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_DivdendAndDivisiorValidNumbers_ReturnsQuotientOfDividenAndDivisor()
        {
            //Arrange
            double dividend = 1;
            double divisor = 3;
            double expected = 0.333;
            int precision = 3;

            //Act
            double actual = Calculator.Division(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual, precision);
        }

        [Fact]
        public void Division_DivdendAndDivisorZero_ReturnsArgumentException()
        {
            //Arrange
            double dividend = 1;
            double divisor = 0;
            string excepted = "Man kann nicht durch 0 dividieren.";
            //Act
            void act() => Calculator.Division(dividend, divisor);

            //Assert
            ArgumentException argumentException = Assert.Throws<ArgumentException>(act);
            Assert.Equal(excepted, argumentException.Message);
        }
    }
}
