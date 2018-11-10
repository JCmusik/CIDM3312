using System;

namespace ConverterLib.LengthModels
{
    public class FeetToMeters
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn * 3.2808M), 2);
        }
    }
}