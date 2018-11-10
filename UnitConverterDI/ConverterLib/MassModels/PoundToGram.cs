using System;

namespace ConverterLib.MassModels
{
    public class PoundToGram
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn / 0.0022046M), 2);
        }
    }
}