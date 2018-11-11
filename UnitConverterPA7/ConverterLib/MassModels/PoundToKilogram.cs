using System;

namespace ConverterLib.MassModels
{
    public class PoundToKilogram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn / 2.2046M), 2);
        }
    }
}