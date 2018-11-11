using System;

namespace ConverterLib.MassModels
{
    public class OunceToGram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn / 0.035274M), 2);
        }
    }
}