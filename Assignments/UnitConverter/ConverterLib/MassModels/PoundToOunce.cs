namespace ConverterLib.MassModels
{
    public class PoundToOunce : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 16M;
        }
    }
}