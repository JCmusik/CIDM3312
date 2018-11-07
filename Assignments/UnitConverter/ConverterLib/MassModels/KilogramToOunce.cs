namespace ConverterLib.MassModels
{
    public class KilogramToOunce : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 35.274M;
        }
    }
}