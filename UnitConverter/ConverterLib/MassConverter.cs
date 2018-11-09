using ConverterLib.MassModels;

namespace ConverterLib
{
    public class MassConverter : IMassConversions
    {
        public decimal GetMass(string type, decimal massIn)
        {
            switch (type)
            {
                case "G to K":
                    return GramToKilogram.Convert(massIn);
                case "K to G":
                    return KilogramToGram.Convert(massIn);
                case "G to Oz":
                    return GramToOunce.Convert(massIn);
                case "Oz to G":
                    return OunceToGram.Convert(massIn);
                case "G to Lb":
                    return GramToPound.Convert(massIn);
                case "Lb to G":
                    return PoundToGram.Convert(massIn);
                case "Kg to Oz":
                    return KilogramToOunce.Convert(massIn);
                case "Oz to Kg":
                    return OunceToKilogram.Convert(massIn);
                case "Kg to Lb":
                    return KilogramToPound.Convert(massIn);
                case "Lb to Kg":
                    return PoundToKilogram.Convert(massIn);
                case "Lb to Oz":
                    return PoundToOunce.Convert(massIn);
                case "Oz to Lb":
                    return OunceToPounds.Convert(massIn);
                default:
                    return massIn;
            }
        }
    }
}