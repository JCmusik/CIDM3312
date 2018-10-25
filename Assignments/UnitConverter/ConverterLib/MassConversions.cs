namespace ConverterLib
{
    public class MassConversions
    {
        public static decimal OunceToPound(int Ounce) => Ounce * 0.062500M;

        public static decimal PoundToOunce(int Pound) => Pound * 16M;

        public static decimal OunceToGram(int Ounce) => Ounce / 0.035274M;

        public static decimal GramToOunce(int Gram) => Gram * 0.035274M;

        public static decimal OunceToKilogram(int Ounce) => Ounce / 35.274M;

        public static decimal KilogramToOunce(int Kilogram) => Kilogram * 35.274M;

        public static decimal PoundToGram(int Pound) => Pound / 0.0022046M;

        public static decimal GramToPound(int Gram) => Gram * 0.0022046M;

        public static decimal PoundToKilogram(int Pound) => Pound / 2.2046M;

        public static decimal KilogramToPound(int Kilogram) => Kilogram * 2.2046M;

        public static decimal GramToKilogram(int Gram) => Gram * 1000M;

        public static decimal KilogramToGram(int Kilogram) => Kilogram / 1000M;

    }
}