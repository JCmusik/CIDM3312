using System;

namespace ConverterLib.LengthModels
{
    public class YardsToMeters
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn * 0.9144M), 2);
        }
    }
}