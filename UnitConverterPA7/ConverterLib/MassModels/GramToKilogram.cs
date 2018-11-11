using System;

namespace ConverterLib.MassModels
{
    public class GramToKilogram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn * 1000M), 2);
        }
    }
}