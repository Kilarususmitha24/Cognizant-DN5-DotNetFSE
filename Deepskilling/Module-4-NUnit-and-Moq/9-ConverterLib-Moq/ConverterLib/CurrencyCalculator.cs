namespace ConverterLib
{
    public class CurrencyCalculator
    {
        private readonly ICurrencyConverter converter;

        public CurrencyCalculator(ICurrencyConverter converter)
        {
            this.converter = converter;
        }

        public double Convert(double usd)
        {
            return converter.ConvertToEuro(usd);
        }
    }
}
