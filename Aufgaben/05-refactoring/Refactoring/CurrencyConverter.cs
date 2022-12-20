namespace Refactoring;

public class CurrencyConverter
{
    public enum Currency
    {
        USD = 0,
        EUR,
        GBP,
        RUB
    }

    private readonly Dictionary<Currency, double> _currencies = new Dictionary<Currency, double>
    {
        [Currency.USD] = 1.09,
        [Currency.EUR] = 0.96,
        [Currency.GBP] = 0.82,
        [Currency.RUB] = 79.78,
    };

    private readonly Currency _currency;

    public CurrencyConverter(Currency currency)
    {
        this._currency = currency;
    }

    public double ConvertTo(double amount)
    {
        return amount * _currencies[_currency];
    }
}