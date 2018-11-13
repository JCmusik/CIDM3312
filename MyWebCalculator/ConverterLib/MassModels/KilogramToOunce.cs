using System;

namespace ConverterLib.MassModels
{
    public class KilogramToOunce
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn * 35.274M), 2);
        }
    }
}