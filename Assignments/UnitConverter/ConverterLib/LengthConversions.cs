namespace ConverterLib
{
    public class LengthConversions
    {
        public static decimal MetersToFeet(int Meters) => Meters / 0.3048M;

        public static decimal FeetToMeters(int Feet) => Feet * 3.2808M;

        public static decimal MetersToYards(int Meters) => Meters * 1.0936132983M;

        public static decimal YardsToMeters(int Yards) => Yards * 0.9144M;

        public static decimal FeetToYards(int Feet) => Feet * 0.3333333333M;

        public static decimal YardsToFeet(int Yards) => Yards * 3M;
    }
}