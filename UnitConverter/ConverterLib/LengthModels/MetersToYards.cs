using System;

namespace ConverterLib.LengthModels
{
    public class MetersToYards
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn * 1.0936132983M), 2);
        }
    }
}