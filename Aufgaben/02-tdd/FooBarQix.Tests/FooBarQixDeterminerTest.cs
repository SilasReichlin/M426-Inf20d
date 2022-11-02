using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(8, "8")]
        public void Determine_NotDividableNumber_ReturnsNumber(int number, string expected)
        {
            var acutal = FooBarQixDeterminer.Determine(number);

            Assert.Equal(expected, acutal);
        }

        [Theory]
        [InlineData(3, "FooFoo")]
        [InlineData(5, "BarBar")]
        [InlineData(7, "QixQix")]
        [InlineData(10, "Bar")]
        [InlineData(13, "Foo")]
        [InlineData(15, "FooBarBar")]
        [InlineData(21, "FooQix")]
        [InlineData(33, "FooFooFoo")]
        [InlineData(51, "FooBar")]
        [InlineData(53, "BarFoo")]
        [InlineData(105, "FooBarQixBar")]
        public void Determine_DiviableNumber_ReturnsCorrectString(int number, string expected)
        {
            var actual = FooBarQixDeterminer.Determine(number);

            Assert.Equal(expected, actual);
        }
    }
}