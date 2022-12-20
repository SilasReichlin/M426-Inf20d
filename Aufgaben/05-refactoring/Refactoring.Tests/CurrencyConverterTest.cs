using Xunit;

namespace Refactoring.Tests;

public class CurrencyConverterTest
{
    [Fact]
    public void ConvertTo_CorrectCurrency_ReturnsCorrectAmount()
    {
        double expected = 1.09;
        CurrencyConverter currencyConverter = new CurrencyConverter(CurrencyConverter.Currency.USD);

        double actual = currencyConverter.ConvertTo(1.0);

        Assert.Equal(expected, actual);
    }
}