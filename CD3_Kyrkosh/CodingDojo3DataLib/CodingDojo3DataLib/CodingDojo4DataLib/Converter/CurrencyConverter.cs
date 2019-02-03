using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo4DataLib.Converter
{
    public static class CurrencyConverter
    {

        public static double ConvertFromEuroTo(Currencies currency, double amount)
        {
            Random rand = new Random();

            switch (currency)
            {
                case Currencies.USD:
                    return amount * 1.278;
                case Currencies.EUR:
                    return amount;
                case Currencies.GBP:
                    return amount * 0.799;
                case Currencies.AUD:
                    return amount * 1.235;
                case Currencies.CAD:
                    return amount * 1.249;
                case Currencies.CHF:
                    return amount * 1.208;
                case Currencies.RUB:
                    return amount * 40.57;
                default:
                    return amount;
            }

        }
    }


    public enum Currencies
    {
        USD,
        EUR,
        GBP,
        AUD,
        CAD,
        CHF,
        RUB
    }
}
