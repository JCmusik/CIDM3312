using ConverterLib.MassModels;

namespace ConverterLib
{
    public class MassConverter : IMassConversions
    {
        public decimal GetMass(string type, decimal massIn)
        {
            switch (type)
            {
                case "g2k":
                    return GramToKilogram.Convert(massIn);
                case "k2g":
                    return KilogramToGram.Convert(massIn);
                case "g2o":
                    return GramToOunce.Convert(massIn);
                case "o2g":
                    return OunceToGram.Convert(massIn);
                case "g2p":
                    return GramToPound.Convert(massIn);
                case "p2g":
                    return PoundToGram.Convert(massIn);
                case "k2o":
                    return KilogramToOunce.Convert(massIn);
                case "o2k":
                    return OunceToKilogram.Convert(massIn);
                case "k2p":
                    return KilogramToPound.Convert(massIn);
                case "p2k":
                    return PoundToKilogram.Convert(massIn);
                case "p2o":
                    return PoundToOunce.Convert(massIn);
                case "o2p":
                    return OunceToPounds.Convert(massIn);
                default:
                    return massIn;
            }
        }
    }
}