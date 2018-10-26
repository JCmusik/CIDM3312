namespace ConverterLib
{
    public class LengthConversions : ILengthConversions
    {
        public decimal MetersToFeet(int Meters) => Meters / 0.3048M;

        public decimal FeetToMeters(int Feet) => Feet * 3.2808M;

        public decimal MetersToYards(int Meters) => Meters * 1.0936132983M;

        public decimal YardsToMeters(int Yards) => Yards * 0.9144M;

        public decimal FeetToYards(int Feet) => Feet * 0.3333333333M;

        public decimal YardsToFeet(int Yards) => Yards * 3M;
    }
}