namespace ConverterLib
{
    interface ILengthConversions
    {
        decimal MetersToFeet(int Meters);

        decimal FeetToMeters(int Feet);

        decimal MetersToYards(int Meters);

        decimal YardsToMeters(int Yards);

        decimal FeetToYards(int Feet);

        decimal YardsToFeet(int Yards);
    }
}