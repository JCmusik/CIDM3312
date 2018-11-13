using ConverterLib.LengthModels;
using ConverterLib.MassModels;
using ConverterLib.TempModels;

namespace ConverterLib
{
    public class Converter : IConverter
    {
        public decimal GetConversion(string type, decimal numIn)
        {
            switch (type)
            {
                case "c2f":
                    return CelsiusToFahrenheit.Convert(numIn);
                case "f2c":
                    return FahrenheitToCelsius.Convert(numIn);
                case "c2k":
                    return CelsiusToKelvin.Convert(numIn);
                case "k2c":
                    return KelvinToCelsius.Convert(numIn);
                case "f2k":
                    return FahrenheitToKelvin.Convert(numIn);
                case "k2f":
                    return KelvinToFahrenheit.Convert(numIn);
                case "f2m":
                    return FeetToMeters.Convert(numIn);
                case "m2f":
                    return MetersToFeet.Convert(numIn);
                case "f2y":
                    return FeetToYards.Convert(numIn);
                case "y2f":
                    return YardsToFeet.Convert(numIn);
                case "m2y":
                    return MetersToYards.Convert(numIn);
                case "y2m":
                    return YardsToMeters.Convert(numIn);
                case "g2k":
                    return GramToKilogram.Convert(numIn);
                case "k2g":
                    return KilogramToGram.Convert(numIn);
                case "g2o":
                    return GramToOunce.Convert(numIn);
                case "o2g":
                    return OunceToGram.Convert(numIn);
                case "g2p":
                    return GramToPound.Convert(numIn);
                case "p2g":
                    return PoundToGram.Convert(numIn);
                case "k2o":
                    return KilogramToOunce.Convert(numIn);
                case "o2k":
                    return OunceToKilogram.Convert(numIn);
                case "k2p":
                    return KilogramToPound.Convert(numIn);
                case "p2k":
                    return PoundToKilogram.Convert(numIn);
                case "p2o":
                    return PoundToOunce.Convert(numIn);
                case "o2p":
                    return OunceToPounds.Convert(numIn);
                default:
                    return numIn;
            }
        }
    }
}