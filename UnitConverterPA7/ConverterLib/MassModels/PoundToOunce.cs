using System;

namespace ConverterLib.MassModels
{
    public class PoundToOunce
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn * 16M), 2);
        }
    }
}