namespace ConverterLib.MassModels
{
    public class GramToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 1000M;
        }
    }
}