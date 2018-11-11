using System;

namespace ConverterLib.LengthModels
{
    public class FeetToYards
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn * 0.3333333333M), 2);
        }
    }
}