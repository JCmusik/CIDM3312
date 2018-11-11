using System;

namespace ConverterLib.MassModels
{
    public class OunceToKilogram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn / 35.274M), 2);
        }
    }
}