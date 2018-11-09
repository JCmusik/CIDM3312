using System;

namespace ConverterLib.TempModels
{
    public class KelvinToFahrenheit
    {
        public static decimal Convert(decimal tempIn)
        {
            return Math.Round((tempIn * (9M / 5M) - 459.67M), 2);
        }
    }
}