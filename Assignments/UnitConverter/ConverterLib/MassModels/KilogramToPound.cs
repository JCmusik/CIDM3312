namespace ConverterLib.MassModels
{
    public class KilogramToPound : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 2.2046M;
        }
    }
}