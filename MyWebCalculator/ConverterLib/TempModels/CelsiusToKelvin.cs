using System;

namespace ConverterLib.TempModels
{
    public class CelsiusToKelvin
    {
        public static decimal Convert(decimal tempIn)
        {
            return Math.Round((tempIn + 273.15M), 2);
        }

    }
}