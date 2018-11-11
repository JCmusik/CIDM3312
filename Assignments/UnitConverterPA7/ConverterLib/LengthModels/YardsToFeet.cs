using System;

namespace ConverterLib.LengthModels
{
    public class YardsToFeet
    {
        public static decimal Convert(decimal lenghtIn)
        {
            return Math.Round((lenghtIn * 3M), 2);
        }
    }
}