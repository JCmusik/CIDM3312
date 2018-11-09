using ConverterLib.LengthModels;

namespace ConverterLib
{
    public class LengthConverter : ILengthConversions
    {
        public decimal GetLength(string type, decimal tempIn)
        {
            switch (type)
            {
                case "Feet to Meters":
                    return FeetToMeters.Convert(tempIn);
                case "Meters to Feet":
                    return MetersToFeet.Convert(tempIn);
                case "Feet to Yards":
                    return FeetToYards.Convert(tempIn);
                case "yYards to Feet2f":
                    return YardsToFeet.Convert(tempIn);
                case "Meters to Yards":
                    return MetersToYards.Convert(tempIn);
                case "Yards to Meters":
                    return YardsToMeters.Convert(tempIn);
                default:
                    return tempIn;
            }
        }
    }
}