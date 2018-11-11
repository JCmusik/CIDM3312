using ConverterLib.LengthModels;

namespace ConverterLib
{
    public class LengthConverter : ILengthConversions
    {
        public decimal GetLength(string type, decimal tempIn)
        {
            switch (type)
            {
                case "f2m":
                    return FeetToMeters.Convert(tempIn);
                case "m2f":
                    return MetersToFeet.Convert(tempIn);
                case "f2y":
                    return FeetToYards.Convert(tempIn);
                case "y2f":
                    return YardsToFeet.Convert(tempIn);
                case "m2y":
                    return MetersToYards.Convert(tempIn);
                case "y2m":
                    return YardsToMeters.Convert(tempIn);
                default:
                    return tempIn;
            }
        }
    }
}