using System;

namespace ConverterLib.TempModels
{
    public class FahrenheitToCelsius
    {
        public static decimal Convert(decimal tempIn)
        {
            return Math.Round(((tempIn - 32) / 9M * 5M), 2);
        }
    }
}