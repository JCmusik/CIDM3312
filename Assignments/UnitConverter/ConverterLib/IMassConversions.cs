namespace ConverterLib
{
    public interface IMassConversions
    {
        decimal OunceToPound(int Ounce);

        decimal PoundToOunce(int Pound);

        decimal OunceToGram(int Ounce);

        decimal GramToOunce(int Gram);

        decimal OunceToKilogram(int Ounce);

        decimal KilogramToOunce(int Kilogram);

        decimal PoundToGram(int Pound);

        decimal GramToPound(int Gram);

        decimal PoundToKilogram(int Pound);

        decimal KilogramToPound(int Kilogram);

        decimal GramToKilogram(int Gram);

        decimal KilogramToGram(int Kilogram);

    }
}