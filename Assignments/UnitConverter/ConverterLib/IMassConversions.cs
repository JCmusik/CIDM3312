namespace ConverterLib
{
    public interface IMassConversions
    {
        decimal OunceToPound(decimal Ounce);

        decimal PoundToOunce(decimal Pound);

        decimal OunceToGram(decimal Ounce);

        decimal GramToOunce(decimal Gram);

        decimal OunceToKilogram(decimal Ounce);

        decimal KilogramToOunce(decimal Kilogram);

        decimal PoundToGram(decimal Pound);

        decimal GramToPound(decimal Gram);

        decimal PoundToKilogram(decimal Pound);

        decimal KilogramToPound(decimal Kilogram);

        decimal GramToKilogram(decimal Gram);

        decimal KilogramToGram(decimal Kilogram);

    }
}