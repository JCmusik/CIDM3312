namespace ConverterLib
{
    public class MassConversions : IMassConversions
    {
        public decimal OunceToPound(int Ounce) => Ounce * 0.062500M;

        public decimal PoundToOunce(int Pound) => Pound * 16M;

        public decimal OunceToGram(int Ounce) => Ounce / 0.035274M;

        public decimal GramToOunce(int Gram) => Gram * 0.035274M;

        public decimal OunceToKilogram(int Ounce) => Ounce / 35.274M;

        public decimal KilogramToOunce(int Kilogram) => Kilogram * 35.274M;

        public decimal PoundToGram(int Pound) => Pound / 0.0022046M;

        public decimal GramToPound(int Gram) => Gram * 0.0022046M;

        public decimal PoundToKilogram(int Pound) => Pound / 2.2046M;

        public decimal KilogramToPound(int Kilogram) => Kilogram * 2.2046M;

        public decimal GramToKilogram(int Gram) => Gram * 1000M;

        public decimal KilogramToGram(int Kilogram) => Kilogram / 1000M;

    }
}