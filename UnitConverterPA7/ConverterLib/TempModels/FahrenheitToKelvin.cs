using System;

namespace ConverterLib.TempModels
{
    public class FahrenheitToKelvin
    {
        public static decimal Convert(decimal tempIn)
        {
            return Math.Round(((tempIn + 459.67M) * 5M / 9M), 2);
        }
    }
}