using System;

namespace UnitConverterClient
{
    public class TemperatureConversions
    {
        public static decimal CelsiusToFahrenheit(int TempC)
        {
            return ((TempC * 9M) / 5M) + 32;
        }
    }
}
