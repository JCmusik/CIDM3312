namespace ConverterLib
{
    public class MassConversions : IMassConversions
    {
        public decimal OunceToPound(decimal Ounce) => Ounce * 0.062500M;

        public decimal PoundToOunce(decimal Pound) => Pound * 16M;

        public decimal OunceToGram(decimal Ounce) => Ounce / 0.035274M;

        public decimal GramToOunce(decimal Gram) => Gram * 0.035274M;

        public decimal OunceToKilogram(decimal Ounce) => Ounce / 35.274M;

        public decimal KilogramToOunce(decimal Kilogram) => Kilogram * 35.274M;

        public decimal PoundToGram(decimal Pound) => Pound / 0.0022046M;

        public decimal GramToPound(decimal Gram) => Gram * 0.0022046M;

        public decimal PoundToKilogram(decimal Pound) => Pound / 2.2046M;

        public decimal KilogramToPound(decimal Kilogram) => Kilogram * 2.2046M;

        public decimal GramToKilogram(decimal Gram) => Gram * 1000M;

        public decimal KilogramToGram(decimal Kilogram) => Kilogram / 1000M;

    }
}