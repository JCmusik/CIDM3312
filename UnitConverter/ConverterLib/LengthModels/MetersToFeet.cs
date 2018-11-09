using System;

namespace ConverterLib.LengthModels
{
    public class MetersToFeet
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn / 0.3048M), 2);
        }
    }
}