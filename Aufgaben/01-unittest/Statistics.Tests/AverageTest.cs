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
            List<int> numbers = new List<int> { 2, 4 };
            double expected = 6;

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
            List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
            double expected = 3;

            //Act
            double actual = Average.Median(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
