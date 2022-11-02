using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 1, 3 };
            double expected = 2;

            double actual = Average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Mean_EmptyList_ReturnsArgumentException()
        {
            //Assert
            List<int> numbers = new List<int>();
            string expected = "Die Liste ist leer.";

            //Act
            void act() => Average.Mean(numbers);

            //Assert
            ArgumentException argumentException = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expected, argumentException.Message);
        }

        [Fact]
        public void Median_OddNumbersOfElements_ReturnsCorrectMedian()
        {
            //Arrange
            List<double> numbers = new List<double> { 1, 9, 4, 5, 6, 8, 2 };
            double expected = 5;

            //Act
            double actual = Average.Median(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Median_EvenNumbersOfElements_ReturnsCorrectMedian()
        {
            //Arrange
            List<double> numbers = new List<double> { 1, 2, 8, 4, 5, 6, 8, 9 };
            double expected = 5.5;

            //Act
            double actual = Average.Median(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Median_EmptyList_ReturnsArgumentException()
        {
            //Arrange
            List<double> numbers = new List<double>();
            string expected = "Die Liste ist leer.";

            //Act
            void act() => Average.Median(numbers);

            //Assert
            ArgumentException argumentException = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expected, argumentException.Message);
        }
    }
}
