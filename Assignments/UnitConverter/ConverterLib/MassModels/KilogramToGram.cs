namespace ConverterLib.MassModels
{
    public class KilogramToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 1000M;
        }
    }
}