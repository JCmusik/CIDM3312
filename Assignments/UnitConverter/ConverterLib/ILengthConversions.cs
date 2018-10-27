namespace ConverterLib
{
    public interface ILengthConversions
    {
        decimal MetersToFeet(decimal Meters);

        decimal FeetToMeters(decimal Feet);

        decimal MetersToYards(decimal Meters);

        decimal YardsToMeters(decimal Yards);

        decimal FeetToYards(decimal Feet);

        decimal YardsToFeet(decimal Yards);
    }
}