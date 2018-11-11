using System;

namespace ConverterLib.MassModels
{
    public class KilogramToGram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn / 1000M), 2);
        }
    }
}