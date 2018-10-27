namespace ConverterLib.MassModels
{
    public class PoundToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 2.2046M;
        }
    }
}