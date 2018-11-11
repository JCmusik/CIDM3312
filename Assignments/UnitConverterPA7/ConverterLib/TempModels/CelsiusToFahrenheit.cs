using System;

namespace ConverterLib.TempModels
{
    public class CelsiusToFahrenheit
    {
        public static decimal Convert(decimal tempIn)
        {
            return Math.Round((((tempIn * 9M) / 5M) + 32), 2);
        }
    }
}