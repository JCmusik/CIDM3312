using System;

namespace ConverterLib.MassModels
{
    public class OunceToPounds
    {
        public static decimal Convert(decimal massIn)
        {
            return Math.Round((massIn * 0.062500M), 2);
        }
    }
}