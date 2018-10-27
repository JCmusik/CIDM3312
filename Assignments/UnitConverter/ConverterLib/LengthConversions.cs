namespace ConverterLib
{
    public class LengthConversions : ILengthConversions
    {
        public decimal MetersToFeet(decimal Meters) => Meters / 0.3048M;

        public decimal FeetToMeters(decimal Feet) => Feet * 3.2808M;

        public decimal MetersToYards(decimal Meters) => Meters * 1.0936132983M;

        public decimal YardsToMeters(decimal Yards) => Yards * 0.9144M;

        public decimal FeetToYards(decimal Feet) => Feet * 0.3333333333M;

        public decimal YardsToFeet(decimal Yards) => Yards * 3M;
    }
}